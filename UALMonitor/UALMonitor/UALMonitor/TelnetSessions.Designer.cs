namespace UALMonitor
{
    partial class TelnetSessions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSessions = new System.Windows.Forms.TextBox();
            this.btngetSessions = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgSessions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgentid = new System.Windows.Forms.TextBox();
            this.btnSessions = new System.Windows.Forms.Button();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSessions
            // 
            this.txtSessions.Location = new System.Drawing.Point(6, 10);
            this.txtSessions.Multiline = true;
            this.txtSessions.Name = "txtSessions";
            this.txtSessions.Size = new System.Drawing.Size(600, 154);
            this.txtSessions.TabIndex = 5;
            // 
            // btngetSessions
            // 
            this.btngetSessions.Location = new System.Drawing.Point(611, 11);
            this.btngetSessions.Name = "btngetSessions";
            this.btngetSessions.Size = new System.Drawing.Size(209, 32);
            this.btngetSessions.TabIndex = 4;
            this.btngetSessions.Text = "Get Session counts All servers";
            this.btngetSessions.UseVisualStyleBackColor = true;
            this.btngetSessions.Click += new System.EventHandler(this.btngetSessions_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(612, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(2, 15);
            this.lblStatus.TabIndex = 3;
            // 
            // dgSessions
            // 
            this.dgSessions.AllowUserToAddRows = false;
            this.dgSessions.AllowUserToDeleteRows = false;
            this.dgSessions.AllowUserToOrderColumns = true;
            this.dgSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSessions.Location = new System.Drawing.Point(3, 174);
            this.dgSessions.Name = "dgSessions";
            this.dgSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSessions.Size = new System.Drawing.Size(818, 539);
            this.dgSessions.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agent Login";
            // 
            // txtAgentid
            // 
            this.txtAgentid.Location = new System.Drawing.Point(673, 113);
            this.txtAgentid.Name = "txtAgentid";
            this.txtAgentid.Size = new System.Drawing.Size(138, 20);
            this.txtAgentid.TabIndex = 2;
            this.txtAgentid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAgentid_KeyDown);
            this.txtAgentid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentid_KeyPress);
            // 
            // btnSessions
            // 
            this.btnSessions.Location = new System.Drawing.Point(731, 141);
            this.btnSessions.Name = "btnSessions";
            this.btnSessions.Size = new System.Drawing.Size(78, 23);
            this.btnSessions.TabIndex = 3;
            this.btnSessions.Text = "Get Sessions";
            this.btnSessions.UseVisualStyleBackColor = true;
            this.btnSessions.Click += new System.EventHandler(this.btnSessions_Click);
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(663, 83);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(151, 21);
            this.cmbServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // TelnetSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 742);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSessions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAgentid);
            this.Controls.Add(this.dgSessions);
            this.Controls.Add(this.txtSessions);
            this.Controls.Add(this.btngetSessions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelnetSessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelnetSessions";
            this.Load += new System.EventHandler(this.TelnetSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSessions;
        private System.Windows.Forms.Button btngetSessions;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgSessions;
        private System.Windows.Forms.Button btnSessions;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgentid;
    }
}