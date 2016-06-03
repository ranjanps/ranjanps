namespace UALMonitor
{
    partial class BoardingLog
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
            this.label13 = new System.Windows.Forms.Label();
            this.rtbCheckAll = new System.Windows.Forms.RadioButton();
            this.rtbSpcInterval = new System.Windows.Forms.RadioButton();
            this.rtbInterval = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.gbpSearch = new System.Windows.Forms.GroupBox();
            this.cmbLineNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLineNumbers = new System.Windows.Forms.Label();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.lblMatchesCount = new System.Windows.Forms.Label();
            this.btnShowTime = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClearFormat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbInterval = new System.Windows.Forms.ComboBox();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.lblLogCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchGrid = new System.Windows.Forms.TextBox();
            this.btnSearchGrid = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.TextBox();
            this.btnCopyLogs = new System.Windows.Forms.Button();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.txtAgentid = new System.Windows.Forms.TextBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnGetLogs = new System.Windows.Forms.Button();
            this.dgServers = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbpSearch.SuspendLayout();
            this.gbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "min";
            // 
            // rtbCheckAll
            // 
            this.rtbCheckAll.AutoSize = true;
            this.rtbCheckAll.Location = new System.Drawing.Point(160, 40);
            this.rtbCheckAll.Name = "rtbCheckAll";
            this.rtbCheckAll.Size = new System.Drawing.Size(73, 17);
            this.rtbCheckAll.TabIndex = 46;
            this.rtbCheckAll.TabStop = true;
            this.rtbCheckAll.Text = "Search All";
            this.rtbCheckAll.UseVisualStyleBackColor = true;
            // 
            // rtbSpcInterval
            // 
            this.rtbSpcInterval.AutoSize = true;
            this.rtbSpcInterval.Location = new System.Drawing.Point(72, 39);
            this.rtbSpcInterval.Name = "rtbSpcInterval";
            this.rtbSpcInterval.Size = new System.Drawing.Size(82, 17);
            this.rtbSpcInterval.TabIndex = 44;
            this.rtbSpcInterval.TabStop = true;
            this.rtbSpcInterval.Text = "Spc Interval";
            this.rtbSpcInterval.UseVisualStyleBackColor = true;
            // 
            // rtbInterval
            // 
            this.rtbInterval.AutoSize = true;
            this.rtbInterval.Location = new System.Drawing.Point(9, 39);
            this.rtbInterval.Name = "rtbInterval";
            this.rtbInterval.Size = new System.Drawing.Size(60, 17);
            this.rtbInterval.TabIndex = 43;
            this.rtbInterval.TabStop = true;
            this.rtbInterval.Text = "Recent";
            this.rtbInterval.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Logs in last";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "End Time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Start Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Logs in specific Time interval";
            // 
            // dpEnd
            // 
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpEnd.Location = new System.Drawing.Point(129, 33);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.ShowUpDown = true;
            this.dpEnd.Size = new System.Drawing.Size(70, 20);
            this.dpEnd.TabIndex = 10;
            // 
            // dpStart
            // 
            this.dpStart.CustomFormat = "hh:mm:ss";
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpStart.Location = new System.Drawing.Point(11, 33);
            this.dpStart.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dpStart.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.ShowUpDown = true;
            this.dpStart.Size = new System.Drawing.Size(70, 20);
            this.dpStart.TabIndex = 9;
            this.dpStart.Value = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            // 
            // gbpSearch
            // 
            this.gbpSearch.Controls.Add(this.cmbLineNo);
            this.gbpSearch.Controls.Add(this.label6);
            this.gbpSearch.Controls.Add(this.lblLineNumbers);
            this.gbpSearch.Controls.Add(this.rtbFileContent);
            this.gbpSearch.Controls.Add(this.lblMatchesCount);
            this.gbpSearch.Controls.Add(this.btnShowTime);
            this.gbpSearch.Controls.Add(this.label14);
            this.gbpSearch.Controls.Add(this.btnClearFormat);
            this.gbpSearch.Controls.Add(this.btnSearch);
            this.gbpSearch.Controls.Add(this.txtSearch);
            this.gbpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbpSearch.Location = new System.Drawing.Point(603, 0);
            this.gbpSearch.Name = "gbpSearch";
            this.gbpSearch.Size = new System.Drawing.Size(666, 752);
            this.gbpSearch.TabIndex = 47;
            this.gbpSearch.TabStop = false;
            this.gbpSearch.Text = "Search";
            // 
            // cmbLineNo
            // 
            this.cmbLineNo.FormattingEnabled = true;
            this.cmbLineNo.Location = new System.Drawing.Point(432, 12);
            this.cmbLineNo.Name = "cmbLineNo";
            this.cmbLineNo.Size = new System.Drawing.Size(78, 21);
            this.cmbLineNo.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Go to Line#";
            // 
            // lblLineNumbers
            // 
            this.lblLineNumbers.AutoSize = true;
            this.lblLineNumbers.Location = new System.Drawing.Point(8, 63);
            this.lblLineNumbers.Name = "lblLineNumbers";
            this.lblLineNumbers.Size = new System.Drawing.Size(0, 13);
            this.lblLineNumbers.TabIndex = 48;
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbFileContent.Location = new System.Drawing.Point(3, 38);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbFileContent.ShowSelectionMargin = true;
            this.rtbFileContent.Size = new System.Drawing.Size(656, 710);
            this.rtbFileContent.TabIndex = 47;
            this.rtbFileContent.Text = "";
            // 
            // lblMatchesCount
            // 
            this.lblMatchesCount.AutoSize = true;
            this.lblMatchesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatchesCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblMatchesCount.Location = new System.Drawing.Point(251, 16);
            this.lblMatchesCount.Name = "lblMatchesCount";
            this.lblMatchesCount.Size = new System.Drawing.Size(2, 15);
            this.lblMatchesCount.TabIndex = 45;
            // 
            // btnShowTime
            // 
            this.btnShowTime.Location = new System.Drawing.Point(514, 10);
            this.btnShowTime.Name = "btnShowTime";
            this.btnShowTime.Size = new System.Drawing.Size(68, 23);
            this.btnShowTime.TabIndex = 43;
            this.btnShowTime.Text = "Parse &Log";
            this.btnShowTime.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Search text";
            // 
            // btnClearFormat
            // 
            this.btnClearFormat.Location = new System.Drawing.Point(584, 10);
            this.btnClearFormat.Name = "btnClearFormat";
            this.btnClearFormat.Size = new System.Drawing.Size(75, 23);
            this.btnClearFormat.TabIndex = 42;
            this.btnClearFormat.Text = "Clear &Format";
            this.btnClearFormat.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(58, 12);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // cmbInterval
            // 
            this.cmbInterval.FormattingEnabled = true;
            this.cmbInterval.Location = new System.Drawing.Point(76, 5);
            this.cmbInterval.Name = "cmbInterval";
            this.cmbInterval.Size = new System.Drawing.Size(57, 21);
            this.cmbInterval.TabIndex = 7;
            // 
            // gbContainer
            // 
            this.gbContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbContainer.Controls.Add(this.lblLogCount);
            this.gbContainer.Controls.Add(this.label3);
            this.gbContainer.Controls.Add(this.btnReset);
            this.gbContainer.Controls.Add(this.label5);
            this.gbContainer.Controls.Add(this.label4);
            this.gbContainer.Controls.Add(this.txtSearchGrid);
            this.gbContainer.Controls.Add(this.btnSearchGrid);
            this.gbContainer.Controls.Add(this.lblFileName);
            this.gbContainer.Controls.Add(this.btnCopyLogs);
            this.gbContainer.Controls.Add(this.dgLogs);
            this.gbContainer.Controls.Add(this.txtAgentid);
            this.gbContainer.Controls.Add(this.chkSelectAll);
            this.gbContainer.Controls.Add(this.btnGetLogs);
            this.gbContainer.Controls.Add(this.dgServers);
            this.gbContainer.Controls.Add(this.groupBox1);
            this.gbContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbContainer.Location = new System.Drawing.Point(0, 0);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(603, 752);
            this.gbContainer.TabIndex = 46;
            this.gbContainer.TabStop = false;
            // 
            // lblLogCount
            // 
            this.lblLogCount.AutoSize = true;
            this.lblLogCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogCount.ForeColor = System.Drawing.Color.Red;
            this.lblLogCount.Location = new System.Drawing.Point(6, 195);
            this.lblLogCount.Name = "lblLogCount";
            this.lblLogCount.Size = new System.Drawing.Size(0, 13);
            this.lblLogCount.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Logfile Name";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(245, 115);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(57, 23);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Search in files";
            // 
            // txtSearchGrid
            // 
            this.txtSearchGrid.Location = new System.Drawing.Point(76, 142);
            this.txtSearchGrid.MaxLength = 100;
            this.txtSearchGrid.Name = "txtSearchGrid";
            this.txtSearchGrid.Size = new System.Drawing.Size(165, 20);
            this.txtSearchGrid.TabIndex = 49;
            // 
            // btnSearchGrid
            // 
            this.btnSearchGrid.Location = new System.Drawing.Point(245, 141);
            this.btnSearchGrid.Name = "btnSearchGrid";
            this.btnSearchGrid.Size = new System.Drawing.Size(57, 23);
            this.btnSearchGrid.TabIndex = 48;
            this.btnSearchGrid.Text = "Search";
            this.btnSearchGrid.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(76, 170);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(519, 20);
            this.lblFileName.TabIndex = 46;
            // 
            // btnCopyLogs
            // 
            this.btnCopyLogs.Location = new System.Drawing.Point(178, 114);
            this.btnCopyLogs.Name = "btnCopyLogs";
            this.btnCopyLogs.Size = new System.Drawing.Size(66, 23);
            this.btnCopyLogs.TabIndex = 44;
            this.btnCopyLogs.Text = "&Copy Logs";
            this.btnCopyLogs.UseVisualStyleBackColor = true;
            // 
            // dgLogs
            // 
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogs.Location = new System.Drawing.Point(7, 215);
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.Size = new System.Drawing.Size(588, 530);
            this.dgLogs.TabIndex = 42;
            this.dgLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLogs_CellContentClick);
            // 
            // txtAgentid
            // 
            this.txtAgentid.Location = new System.Drawing.Point(356, 25);
            this.txtAgentid.MaxLength = 10;
            this.txtAgentid.Name = "txtAgentid";
            this.txtAgentid.Size = new System.Drawing.Size(98, 20);
            this.txtAgentid.TabIndex = 1;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(5, 118);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(109, 17);
            this.chkSelectAll.TabIndex = 28;
            this.chkSelectAll.Text = "Select All Servers";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnGetLogs
            // 
            this.btnGetLogs.Location = new System.Drawing.Point(114, 115);
            this.btnGetLogs.Name = "btnGetLogs";
            this.btnGetLogs.Size = new System.Drawing.Size(63, 23);
            this.btnGetLogs.TabIndex = 2;
            this.btnGetLogs.Text = "&Get Logs";
            this.btnGetLogs.UseVisualStyleBackColor = true;
            this.btnGetLogs.Click += new System.EventHandler(this.btnGetLogs_Click);
            // 
            // dgServers
            // 
            this.dgServers.FormattingEnabled = true;
            this.dgServers.Location = new System.Drawing.Point(5, 14);
            this.dgServers.MultiColumn = true;
            this.dgServers.Name = "dgServers";
            this.dgServers.Size = new System.Drawing.Size(301, 94);
            this.dgServers.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.rtbCheckAll);
            this.groupBox1.Controls.Add(this.rtbSpcInterval);
            this.groupBox1.Controls.Add(this.rtbInterval);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(308, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 157);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Logs";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AgentId";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 61);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.cmbInterval);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1MinSize = 15;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.dpEnd);
            this.splitContainer1.Panel2.Controls.Add(this.dpStart);
            this.splitContainer1.Size = new System.Drawing.Size(263, 92);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 42;
            // 
            // BoardingLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 752);
            this.Controls.Add(this.gbpSearch);
            this.Controls.Add(this.gbContainer);
            this.Name = "BoardingLog";
            this.Text = "BoardingLog";
            this.Load += new System.EventHandler(this.BoardingLog_Load);
            this.gbpSearch.ResumeLayout(false);
            this.gbpSearch.PerformLayout();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rtbCheckAll;
        private System.Windows.Forms.RadioButton rtbSpcInterval;
        private System.Windows.Forms.RadioButton rtbInterval;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.GroupBox gbpSearch;
        private System.Windows.Forms.ComboBox cmbLineNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLineNumbers;
        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.Label lblMatchesCount;
        private System.Windows.Forms.Button btnShowTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClearFormat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbInterval;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Label lblLogCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchGrid;
        private System.Windows.Forms.Button btnSearchGrid;
        private System.Windows.Forms.TextBox lblFileName;
        private System.Windows.Forms.Button btnCopyLogs;
        private System.Windows.Forms.DataGridView dgLogs;
        private System.Windows.Forms.TextBox txtAgentid;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnGetLogs;
        private System.Windows.Forms.CheckedListBox dgServers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}