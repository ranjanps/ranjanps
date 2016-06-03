using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using UALMonitor.BusinessObjects;

namespace UALMonitor
{
    public partial class BoardingLog : Form
    {
        string serverListPath;
        XmlDocument xml;
        List<Server> servers;
        List<LogFileInfo> _logFiles;
        bool isThreadOn;
        public BoardingLog()
        {
            InitializeComponent();
        }

        private void btnGetLogs_Click(object sender, EventArgs e)
        {
            _logFiles = new List<LogFileInfo>();
            lblLogCount.Text = "";

            bool isAnyChecked = false;
            for (int i = 0; i < dgServers.Items.Count; i++)
            {
                if (dgServers.GetItemChecked(i))
                {
                    isAnyChecked = true;
                    break;
                }
            }

            if (isAnyChecked)
            {
                if (txtAgentid.Text != "")
                {
                    ClearGrids();
                    LoadLogs(txtAgentid.Text);
                }
                else
                {
                    ClearGrids();
                    LoadLogs();
                }
            }
            else
                MessageBox.Show("No server selected to extract logs");

        }


        private void BoardingLog_Load(object sender, EventArgs e)
        {

            InitializeXML();
            ListServers();

            rtbInterval.Checked = true;
            rtbSpcInterval.Checked = false;
            dpStart.Value = DateTime.Today;
            isThreadOn = false;
        }

        private void ClearGrids()
        {
            dgLogs.DataSource = null;
            dgLogs.Refresh();
        }

        private void InitializeXML()
        {
            serverListPath = Application.StartupPath + "\\ServerList.xml";
            xml = new XmlDocument();
            xml.Load(serverListPath);

            //Add Interval
            for (int i = 10; i <= 600; i += 10)
            {
                cmbInterval.Items.Add(i);
            }
            cmbInterval.Text = "10";
        }

        private void ListServers()
        {
            servers = new List<Server>();
            string serverName, ualPath;

            foreach (XmlNode rootNode in xml.ChildNodes)
            {
                foreach (XmlNode serverNode in rootNode)
                {
                    serverName = "";
                    ualPath = "";

                    foreach (XmlNode innerNode in serverNode)
                    {
                        if (innerNode.Name == "Name")
                            serverName = innerNode.InnerText;

                        if (innerNode.Name == "UALPath")
                            ualPath = innerNode.InnerText;
                    }
                    if (serverName != "")
                        servers.Add(new Server { Name = serverName, UALPath = ualPath });
                }
            }
            dgServers.DataSource = servers;
            dgServers.DisplayMember = "Name";
            dgServers.ValueMember = "UALPath";

        }

        private void LoadLogs(string agentId = "")
        {

            foreach (var server in servers)
            {
                if (IsChecked(server.Name))
                {
                    LoadFiles(server.Name, server.UALPath, agentId);
                }
            }
            //Load files 
            this.ClearGrids();
            LaodLogsToGrid();
        }

        private bool IsChecked(string serverName)
        {
            for (int i = 0; i < dgServers.Items.Count; i++)
            {
                if (((Server)dgServers.Items[i]).Name == serverName && dgServers.GetItemChecked(i))
                    return true;
            }
            return false;
        }


        private void LoadFiles(string serverName, string ualPath, string agentid = "")
        {
            DateTime startTime;
            DateTime endTime;
            int interval = Int32.Parse(cmbInterval.Text);
            //int fileCount = 0;

            this.Cursor = Cursors.WaitCursor;

            bool isRecentLogs = rtbInterval.Checked;

            if (isRecentLogs == false)
            {
                startTime = dpStart.Value;
                endTime = dpEnd.Value;

                if (startTime > endTime)
                {
                    MessageBox.Show(@"End time has to be bigger than start time");
                    this.Cursor = Cursors.Default;
                    return;
                }
            }

            else
            {
                startTime = DateTime.Now.AddMinutes(-1 * interval);
                endTime = DateTime.Now;
            }

            var t = new ThreadStart(() =>
            {
                string pattern;

                if (agentid == "")
                    pattern = "*.log";
                else
                {
                    pattern = agentid + "*.log";
                }


                DirectoryInfo di = new DirectoryInfo(ualPath);
                if (di.Exists)
                {
                    var files = di.GetFiles(pattern);
                    
                    if (rtbCheckAll.Checked)
                    {
                        foreach (var file in files)
                        {
                            if (GetFileContent(file.FullName).Contains(".brd"))
                                {
                                _logFiles.Add(
                                    new LogFileInfo()
                                    {
                                        ServerName = serverName,
                                        Name = file.Name,
                                        FileCreated = file.CreationTime,
                                        FileUpdated = file.LastWriteTime,
                                        Size = file.Length / 1024
                                    });
                            }
                        }
                    }
                    else
                    {

                        foreach (var file in files)
                        {
                            if (file.LastWriteTime >= startTime && file.LastWriteTime <= endTime)
                            {
                                if (GetFileContent(file.FullName).Contains(".brd"))
                                {
                                    _logFiles.Add(
                                    new LogFileInfo()
                                    {
                                        ServerName = serverName,
                                        Name = file.Name,
                                        FileCreated = file.CreationTime,
                                        FileUpdated = file.LastWriteTime,
                                        Size = file.Length / 1024
                                    });
                                }

                            }
                        }
                    }
                }

            });

            t.Invoke();
            this.Cursor = Cursors.Default;
        }


        private void LaodLogsToGrid()
        {
            List<LogFileInfo> list = _logFiles.OrderByDescending(l => l.ServerName).ThenBy(l1 => l1.FileUpdated).ToList();
            lblLogCount.Text = "Total logs found: " + list.Count.ToString();

            dgLogs.AutoGenerateColumns = false;
            dgLogs.MultiSelect = false;
            dgLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLogs.Columns.Clear();

            var col11 = new DataGridViewTextBoxColumn();
            col11.DataPropertyName = "ServerName";
            col11.HeaderText = "ServerName";
            col11.Width = dgLogs.Width / 3 - 20;
            dgLogs.Columns.Add(col11);


            var col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "PartialLogFileName";
            col1.HeaderText = "AgentId";
            col1.Width = dgLogs.Width / 4 - 30;
            dgLogs.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "FileUpdated";
            col2.HeaderText = "File Updated";
            col2.Width = dgLogs.Width / 4 - 40;
            dgLogs.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "Size";
            col3.HeaderText = "File Size(KB)";
            col3.Width = dgLogs.Width / 4 - 65;
            dgLogs.Columns.Add(col3);

            var col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "Name";
            col4.Visible = false;
            dgLogs.Columns.Add(col4);

            dgLogs.DataSource = list;
            dgLogs.Refresh();
        }


        private void LoadFileContent(string fileName)
        {
            this.Cursor = Cursors.WaitCursor;
            rtbFileContent.Text = "";
            rtbFileContent.Text = GetFileContent(fileName);
            this.Cursor = Cursors.Default;
        }

        private string GetFileContent(string fileName)
        {
            string strContent = "";
            var t = new ThreadStart(() =>
            {
                FileInfo fl = new FileInfo(fileName);
                lblFileName.Text = fileName;
                if (fl.Exists)
                {
                    StreamReader sm = new StreamReader(fileName);
                    strContent = sm.ReadToEnd();
                    sm.Close();
                }
            });
            t.Invoke();

            return strContent;
        }

        private void dgLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string serverName = dgLogs.Rows[e.RowIndex].Cells[0].Value.ToString();
                string fileName = "\\\\" + serverName + "\\\\UserActions\\\\" + dgLogs.Rows[e.RowIndex].Cells[4].Value;
                LoadFileContent(fileName);
            }
        }





    }
}
