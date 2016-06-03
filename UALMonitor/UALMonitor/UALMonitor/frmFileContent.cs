using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UALMonitor.BusinessObjects;

namespace UALMonitor
{
    public partial class FrmFileContent : Form
    {
        private string _fileContent;
        public FrmFileContent()
        {
            InitializeComponent();
        }

        private void FileContent_Load(object sender, EventArgs e)
        {

        }

        public void ShowContent(string strContent,string strFileName)
        {
            _fileContent = strContent;
            rtContent.Text = strContent;
            lblFileName.Text = strFileName;
            ParseTheLog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ParseTheLog()
        {
            string strContenet = rtContent.Text;
            MatchCollection coll = Regex.Matches(rtContent.Text, "EXECUTED:", RegexOptions.IgnoreCase);

            var ualDetails = new List<CUalDetail>();
            int iTotal = coll.Count;


            for (int i = 0; i < iTotal; i += 2)
            {
                int iBeginStartPos, iBeginEndPos, iEndStartPos, iEndEndPos;

                Match m = coll[i];
                iBeginStartPos = m.Index;
                iBeginEndPos = rtContent.Text.IndexOf("\n", iBeginStartPos + 5);
                string startCmdtext = "";
                string endCmdtext = "";
                string strCommandOutput = "";

                DateTime startTime = DateTime.MinValue, endTime = DateTime.MinValue;

                //Find start posion for command
                if (iBeginEndPos > iBeginStartPos)
                {
                    rtContent.Select(iBeginStartPos, iBeginEndPos - iBeginStartPos);
                    rtContent.SelectionBackColor = Color.Orange;
                    startCmdtext = rtContent.SelectedText;
                }

                //find start time
                if (startCmdtext != "")
                    startTime = DateTime.Parse(startCmdtext.Substring(10));


                //If the command output contaisnsfligt information

                if (i < iTotal - 1)
                {
                    m = coll[i + 1];

                    iEndStartPos = m.Index;
                    iEndEndPos = rtContent.Text.IndexOf("\n", iEndStartPos + 5);

                    if (iEndEndPos > iBeginStartPos)
                        strCommandOutput = strContenet.Substring(iBeginStartPos, iEndEndPos - iBeginStartPos);

                    if (strCommandOutput.Contains("Funtion:") || strCommandOutput.Contains("GetPriceResponse"))
                        i++;


                    if (strCommandOutput.Contains("Hitting payment"))
                    {
                        i++;

                        iBeginStartPos = iEndEndPos;
                        m = coll[i + 1];

                        iEndStartPos = m.Index;
                        iEndEndPos = rtContent.Text.IndexOf("\n", iEndStartPos + 5);

                        strCommandOutput = strContenet.Substring(iBeginStartPos, iEndEndPos - iBeginStartPos);

                        //if there is 2nd payment service hit

                        if (strCommandOutput.Contains("Hitting payment"))
                        {
                            i++;

                            iBeginStartPos = iEndEndPos;
                            m = coll[i + 1];

                            iEndStartPos = m.Index;
                            iEndEndPos = rtContent.Text.IndexOf("\n", iEndStartPos + 5);

                            strCommandOutput = strContenet.Substring(iBeginStartPos, iEndEndPos - iBeginStartPos);

                            //if there is 2nd payment service hit
                            if (strCommandOutput.Contains("Hitting payment"))
                                i++;
                        }
                    }
                }
                
                if (i < iTotal - 1)
                {
                    m = coll[i + 1];

                    iEndStartPos = m.Index;
                    iEndEndPos = rtContent.Text.IndexOf("\n", iEndStartPos + 5);
                    
                    if (iEndEndPos > iEndStartPos)
                    {
                        rtContent.Select(iEndStartPos, iEndEndPos - iEndStartPos);
                        endCmdtext = rtContent.SelectedText;

                        if (endCmdtext != "")
                            endTime = DateTime.Parse(endCmdtext.Substring(10));

                        if (startTime > DateTime.MinValue && endTime > DateTime.MinValue)
                        {
                            if ((endTime - startTime).TotalSeconds > 10)
                                rtContent.SelectionBackColor = Color.Red;
                            else
                                rtContent.SelectionBackColor = Color.PowderBlue;
                        }
                        else

                            rtContent.SelectionBackColor = Color.BlanchedAlmond;
                        strCommandOutput = strContenet.Substring(iBeginStartPos, iEndEndPos - iBeginStartPos);
                    }

                    if (startTime > DateTime.MinValue && endTime > DateTime.MinValue)
                    {
                        CUalDetail details = new CUalDetail();
                        details.CommandStartTime = startTime.ToLongTimeString();
                        details.CommandEndTime = endTime.ToLongTimeString();
                        details.CommandOutput = strCommandOutput;
                        details.StartPos = iBeginStartPos;
                        details.TimeTaken = (endTime - startTime).TotalSeconds;

                        ualDetails.Add(details);
                    }
                }
            }
            dgLogDetails.AutoGenerateColumns = false;
            dgLogDetails.MultiSelect = false;
            dgLogDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLogDetails.ReadOnly = true;
            dgLogDetails.Columns.Clear();

            var col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = @"CommandStartTime";
            col1.HeaderText = @"StartTime";
            col1.Width = dgLogDetails.Width/3 + 10;
            dgLogDetails.Columns.Add(col1);

            var col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "CommandEndTime";
            col2.HeaderText = @"EndTime";
            col2.Width = dgLogDetails.Width/3;
            dgLogDetails.Columns.Add(col2);

            var col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "TimeTaken";
            col3.HeaderText = "Time(Sec)";
            col3.Width = dgLogDetails.Width/3 - 45;
            dgLogDetails.Columns.Add(col3);

            var col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "CommandOutput";
            col4.Visible = false;
            dgLogDetails.Columns.Add(col4);

            var col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "StartPos";
            col5.Visible = false;
            dgLogDetails.Columns.Add(col5);

            dgLogDetails.DataSource = ualDetails;
            dgLogDetails.Refresh();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            rtContent.Text = _fileContent;
            dgLogDetails.DataSource = null;
            dgLogDetails.Refresh();
            ParseTheLog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
                FindMatchAndHighLight(txtSearch.Text);
        }


        private void FindMatchAndHighLight(string pattern)
        {
            int iStartPos, iEndPos;

            try
            {
                MatchCollection coll = Regex.Matches(rtContent.Text, pattern, RegexOptions.IgnoreCase);
                MessageBox.Show("Total matche(s) " + coll.Count.ToString());
                foreach (Match m in coll)
                {
                    iStartPos = m.Index;
                    iEndPos = rtContent.Text.IndexOf("\n", iStartPos + 5);
                    if (iEndPos > iStartPos)
                    {
                        rtContent.Select(iStartPos, iEndPos - iStartPos);
                        rtContent.SelectionBackColor = Color.Yellow;
                    }
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string sourceFile = lblFileName.Text;
            SaveFileDialog sd=new SaveFileDialog();
            sd.Filter = "Log files (*.log)|*.log";
            sd.FileName = sourceFile.Substring(sourceFile.LastIndexOf("\\") + 1);
            sd.FilterIndex = 2;
            sd.RestoreDirectory = true;

            if (sd.ShowDialog() == DialogResult.OK)
            {
                
                string destFile = sd.FileName;

                if (sourceFile != "" && destFile != "")
                    File.Copy(sourceFile,destFile,true);
            }

        }

        private void dgLogDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rtbCommandOutput.Text = dgLogDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtContent.SelectionStart = Int32.Parse(dgLogDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
            
            Font f = new Font(FontFamily.GenericSerif,16);
            rtContent.SelectionFont = f;
            rtContent.Focus();
        }

        private void dgLogDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter && txtSearch.Text.Length > 0)
                FindMatchAndHighLight(txtSearch.Text);
        }

        private void btnExtractStats_Click(object sender, EventArgs e)
        {

        }
    }
}
