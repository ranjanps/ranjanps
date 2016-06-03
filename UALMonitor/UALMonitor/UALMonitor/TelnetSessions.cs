using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UALMonitor.BusinessObjects;
using System.Diagnostics;

namespace UALMonitor
{
    public partial class TelnetSessions : Form
    {
        string[] ServerList = { "S217124RGVW1148", "S217124RGVW1151", "S217124RGVW1152", "S217124RGVW1154", "S217124RGVW1156", "S217124DKVW421", "S217124DKVW422", "S217124DKVW423", "S217124DKVW424", "S217124DKVW425" };
        private List<TelnetSession> _telnetSessions;
        private DataSet dsSessions;

        public TelnetSessions()
        {
            InitializeComponent();
        }

        private void btngetSessions_Click(object sender, EventArgs e)
        {
            txtSessions.Text = "";
            lblStatus.Text = "Extracting information...";
            foreach (var server in ServerList)
            {
                lblStatus.Text = "Extracting information for " + server;
                try
                {
                    txtSessions.Text = txtSessions.Text + server + @" - " + GetTelNetSessionCount(server) + Environment.NewLine;
                }
                catch(Exception ex)
                {
                    txtSessions.Text = ex.Message;
                }
            }
            lblStatus.Text = "";
        }

        
        private void btnSessions_Click(object sender, EventArgs e)
        {
            //64 telnet session(s)
            if (cmbServer.Text.Length > 0)
            {
                GetTelNetSessions(cmbServer.Text,txtAgentid.Text);
            }
            else
            {
                MessageBox.Show("Please select server");
            }


        }

        private void TelnetSessions_Load(object sender, EventArgs e)
        {
            dsSessions=new DataSet();
            _telnetSessions  = new List<TelnetSession>();
            lblStatus.Text = "";

            cmbServer.DataSource = ServerList;
        }


        private string GetTelNetSessionCount(string serverName)
        {
            string strSessions = "";
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                // this script has a sleep in it to simulate a long running script
                PowerShellInstance.AddScript("tlntadmn " + serverName + " -s #all");

                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

                if (PSOutput != null)
                {
                    if (PSOutput.Count>1)
                        strSessions = PSOutput[1].ToString();
                    else
                    {
                        strSessions = "0  telnet session";
                    }
                }
            }
            return strSessions;
        }

        private void GetTelNetSessions(string serverName,string agentId)
        {
            string strSessions = "";
            _telnetSessions.Clear();
            dgSessions.DataSource = null;

            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                // this script has a sleep in it to simulate a long running script
                PowerShellInstance.AddScript("tlntadmn " + serverName + " -s #all");
                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

                //
                if (PSOutput != null)
                {
                    strSessions = PSOutput[1].ToString();
                    if (strSessions.Contains("telnet"))
                    {
                        int sessionCount = Int32.Parse(strSessions.Substring(0, strSessions.IndexOf("telnet") - 1));
                        for (int i = 4; i < sessionCount + 4; i++)
                        {
                            string strOutput = PSOutput[i].ToString();
                            ParseData(strOutput);
                        }

                        if (agentId != "")
                        {
                            var filteredSessions = from u in _telnetSessions
                                where u.UserName == agentId
                                select u;
                            dgSessions.DataSource = filteredSessions.ToList();
                            lblStatus.Text = "Total Sessions : " + filteredSessions.ToList().Count;

                        }
                        else
                        {
                            dgSessions.DataSource = _telnetSessions;
                            lblStatus.Text = "Total Sessions : " + _telnetSessions.Count;
                        }

                        dgSessions.Refresh();
                    }
                }
            }
            dgSessions.Refresh();
        }

        private void ParseData(string content)
        {
            string st = Regex.Replace(content, @"\s+", "$");

            if (st.Length > 20)
            {
                var data = st.Split('$');
                int iCol = 1;
                TelnetSession session = new TelnetSession();

                foreach (var s in data)
                {
                    switch (iCol)
                    {
                        case 1:
                            session.Id = s.Trim();
                            break;

                        case 2:
                            session.Domain = s.Trim();
                            break;
                        case 3:
                            session.UserName= s.Trim();
                            break;
                        case 4:
                            session.Client =  s.Trim();
                            break;
                        case 5:
                            session.LogonDate =  s.Trim();
                            break;
                        case 6:
                            session.LogonTime =  s.Trim();
                            break;
                        case 7:
                            session.IdleTime =  s.Trim();
                            break;
                    }
                    
                    iCol++;
                }
                _telnetSessions.Add(session);
            }
            
        }

        private void txtAgentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtAgentid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSessions_Click(this,e);
            }
        }

    }
}
