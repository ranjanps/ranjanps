using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using UALMonitor.BusinessObjects;

namespace UALMonitor
{
    public partial class frmMain : Form
    {
        private UALCommon _common;
        List<LogFileInfo> _logFiles;
        List<Server> servers;

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            _common = new UALCommon();
            ListServers();
            ResizeWindow();

            optRecent.Checked = true;
            optSpcInterval.Checked = false;
            dpStart.Value = DateTime.Today;
        }

        private void ListServers()
        {
            var serverListPath = Application.StartupPath + "\\ServerList.xml";
            //Get Server List
            servers = _common.GetServerList(serverListPath);

            dgServers.DataSource = servers;
            dgServers.DisplayMember = "Name";
            dgServers.ValueMember = "UALPath";

            //Add Interval
            for (int i = 5; i <= 600; i += 5)
                cmbInterval.Items.Add(i);
            
            cmbInterval.Text = "10";
        }

        private void gbContainer_Enter(object sender, EventArgs e)
        {

        }


      

        private bool IsChecked(string serverName)
        {
            for (int i = 0; i < dgServers.Items.Count; i++)
            {
                if ( ((Server)dgServers.Items[i]).Name == serverName && dgServers.GetItemChecked(i))
                    return true;
            }
            return false;
        }
               

        private void btnGetLogs_Click(object sender, EventArgs e)
        {
            lblLogCount.Text = "";
            DateTime startTime, endTime;
            int interval;
            startTime = DateTime.MinValue;
            endTime = DateTime.MinValue;
            
            bool isAnyChecked = false;
            for (int i = 0; i < dgServers.Items.Count; i++)
            {
                if (dgServers.GetItemChecked(i))
                {
                    isAnyChecked = true;
                    break;
                }
            }

            ClearGrids();

            if (isAnyChecked)
            {

                var agentid = txtAgentid.Text.Trim();

                if (optRecent.Checked || optSpcInterval.Checked)
                {
                    if (optRecent.Checked)
                    {
                        interval = Convert.ToInt32(cmbInterval.Text);
                        startTime = DateTime.Now.AddMinutes(-1 * interval);
                        endTime = DateTime.Now;
                    }
                    else
                    {
                        startTime = dpStart.Value;
                        endTime = dpEnd.Value;
                    }

                    if (startTime > endTime)
                    {
                        MessageBox.Show(@"End time has to be bigger than start time");
                        return;
                    }
                }

                LoadLogs(startTime, endTime, agentid);
            }
            else
                MessageBox.Show("No server selected to extract logs");
        }


        private void LoadLogs(DateTime startTime,DateTime endTime, string agentId = "")
        {
            this.Cursor = Cursors.WaitCursor;
            List<LogFileInfo> logFiles = new List<LogFileInfo>();
            foreach (var server in servers)
            {
                if (IsChecked(server.Name))
                {
                    if(startTime == endTime)
                        logFiles = _common.GetFiles(server.Name, server.UALPath,"", agentId);
                    else
                        logFiles = _common.GetFiles(startTime,endTime, server.Name, server.UALPath,txtSearchGrid.Text, agentId);
                }
            }
            //Load files 
            LaodLogsToGrid(logFiles);
            this.Cursor = Cursors.Default;
        }


        private void ClearGrids()
        {
            dgLogs.DataSource = null;
            dgLogs.Refresh();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                for (int i=0;i<dgServers.Items.Count;i++ )
                {
                    dgServers.SetItemChecked(i,true);
                }
            }
            else
            {
                for (int i = 0; i < dgServers.Items.Count; i++)
                {
                    dgServers.SetItemChecked(i, false);
                }
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            ResizeWindow();
        }

        private void ResizeWindow()
        {
            dgLogs.Height = this.Height - dgLogs.Top - 40;
            rtbFileContent.Height = gbpSearch.Height - 40;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                FindMatchAndHighLight(txtSearch.Text);
            }
        }


        private bool FindMatchAndHighLight(string pattern)
        {
            int iStartPos,iEndPos;
            MatchCollection coll = Regex.Matches(rtbFileContent.Text, pattern, RegexOptions.IgnoreCase);
            lblMatchesCount.Text =  coll.Count + " matches";

            cmbLineNo.Items.Clear();
            cmbLineNo.Text = "";
            string strMatchLineNo = "Matches found at line no: ";

            Random r = new Random();
            Color color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));

            foreach (Match m in coll)
            {
                strMatchLineNo += " " + rtbFileContent.GetLineFromCharIndex(m.Index);
                cmbLineNo.Items.Add(rtbFileContent.GetLineFromCharIndex(m.Index));

                iStartPos = m.Index;
                iEndPos = rtbFileContent.Text.IndexOf("\n", iStartPos + 5);
                if (iEndPos > iStartPos)
                {
                    rtbFileContent.Select(iStartPos, iEndPos - iStartPos);
                    
                    rtbFileContent.SelectionBackColor =color;
                    rtbFileContent.SelectionFont = new Font(FontFamily.GenericSansSerif,12);
                }
            }
            return (coll.Count > 0);
        }


        private void LaodLogsToGrid(List<LogFileInfo> logfiles)
        {
            List<LogFileInfo> list = logfiles.OrderByDescending(l => l.ServerName).ThenBy(l1 => l1.FileUpdated).ToList();
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






        private void btnClearFormat_Click(object sender, EventArgs e)
        {
            ClearFormat();
        }

        private void ClearFormat()
        {
            string content = rtbFileContent.Text;
            rtbFileContent.Clear();
            rtbFileContent.Text = content;
        }

        private void txtAgentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAgentid_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text.Length > 0)
                    FindMatchAndHighLight(txtSearch.Text);
            }

        }


        private void btnShowTime_Click(object sender, EventArgs e)
        {
            if (rtbFileContent.Text.Length > 0)
            {
                Cursor = Cursors.WaitCursor;
                FrmFileContent frm = new FrmFileContent();
                frm.ShowContent(rtbFileContent.Text, lblFileName.Text);
                Cursor = Cursors.Default;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a log file to parse");
            }

        }

        private void btnCopyLogs_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult result = fd.ShowDialog(this);
            string folderName = fd.SelectedPath;

            if (result == DialogResult.OK)
            {
                for (int i = 0; i < dgLogs.Rows.Count; i++)
                {
                    string serverName = dgLogs.Rows[i].Cells[0].Value.ToString();
                    string fileName = dgLogs.Rows[i].Cells[4].Value.ToString();
                    string folderPath = "\\\\" + serverName + "\\\\UserActions\\\\";

                    _common.CopyLogs(folderPath, fileName, folderName, serverName);
                }
                MessageBox.Show("The files are copied to " + folderName);
            }

            Cursor = Cursors.Default;
        }


        private void rtbInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (optRecent.Checked)
            {
                cmbInterval.Enabled = true;
                dpStart.Enabled = false;
                dpEnd.Enabled = false;
            }
        }

        private void rtbSpcInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (optSpcInterval.Checked)
            {
                cmbInterval.Enabled = false;
                dpStart.Enabled = true;
                dpEnd.Enabled = true;
            }
        }


      

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearGrids();
            txtSearch.Text = "";
            cmbInterval.Text = @"10";
        }

        private void rtbFileContanet_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {   
                //click event
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
             
                MenuItem menuItem = new MenuItem("Copy Contents");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);
                rtbFileContent.ContextMenu = contextMenu;
            }
        }
       
        void CopyAction(object sender, EventArgs e)
        {
            rtbFileContent.Copy();
        }

        private void dgLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string serverName = dgLogs.Rows[e.RowIndex].Cells[0].Value.ToString();
                string fileName = "\\\\" + serverName + "\\\\UserActions\\\\" + dgLogs.Rows[e.RowIndex].Cells[4].Value;
                rtbFileContent.Text =  _common.GetFileContent(fileName);
            }
        }

        private void rbCheckAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchGrid_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SearchText();
            this.Cursor = Cursors.Default;
        }

        private void SearchText()
        {
            if (dgLogs.Rows.Count > 1 && txtSearchGrid.Text != "")
            {
                for (int iRowIndex = 0; iRowIndex < dgLogs.Rows.Count; iRowIndex++)
                {
                    var thread = new ThreadStart(() =>
                    {
                    string serverName = dgLogs.Rows[iRowIndex].Cells[0].Value.ToString();
                    string fileName = "\\\\" + serverName + "\\\\UserActions\\\\" + dgLogs.Rows[iRowIndex].Cells[4].Value;

                    rtbFileContent.Text = fileName;

                    string strContent = _common.GetFileContent(fileName);

                    if ( _common.FindMatch(strContent, txtSearchGrid.Text))
                    {
                        dgLogs.Rows[iRowIndex].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                });
                    thread.Invoke();
                }
            }
            rtbFileContent.Text = "";
        }

        private void cmbLineNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lineNo = int.Parse(cmbLineNo.Text);
            int index = rtbFileContent.GetFirstCharIndexFromLine(lineNo - 1);
            rtbFileContent.Select(index, 0);
            rtbFileContent.Focus();
        }

        private void dgLogs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string serverName = dgLogs.Rows[e.RowIndex].Cells[0].Value.ToString();
                string fileName = "\\\\" + serverName + "\\\\UserActions\\\\" + dgLogs.Rows[e.RowIndex].Cells[4].Value;
                LoadFileContent(fileName);
            }
        }

        private void LoadFileContent(string fileName)
        {
            this.Cursor = Cursors.WaitCursor;
            rtbFileContent.Text = "";
            rtbFileContent.Text = _common.GetFileContent(fileName);
            this.Cursor = Cursors.Default;
        }

    }
}
