using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UALMonitor
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.Show();
        }

      
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.Show();
        }

  
        private void cSLServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("Vt100Monitoring.exe");
        }

        private void telnetServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("C:\\Control\\TelnetManager\\TelnetManager.exe");
        }

        private void telnetSessionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new TelnetSessions();
            frm.MdiParent = this;
            frm.Show();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Taskmgr.exe");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("Taskmgr.exe");
        }

        private void toolTelNetSessions_Click(object sender, EventArgs e)
        {
            var frm = new TelnetSessions();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tollFind_Click(object sender, EventArgs e)
        {
            Process.Start("AstroGrep.exe");
        }

        private void grepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("AstroGrep.exe");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FlightData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void boardingLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new BoardingLog();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userActionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
