namespace UALMonitor
{
    partial class FrmFileContent
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
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbCommandOutput = new System.Windows.Forms.RichTextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgLogDetails = new System.Windows.Forms.DataGridView();
            this.btnExtractStats = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // rtContent
            // 
            this.rtContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtContent.Location = new System.Drawing.Point(553, 0);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(723, 933);
            this.rtContent.TabIndex = 0;
            this.rtContent.Text = "Parse";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExtractStats);
            this.groupBox1.Controls.Add(this.rtbCommandOutput);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rtbCommandOutput
            // 
            this.rtbCommandOutput.Location = new System.Drawing.Point(5, 60);
            this.rtbCommandOutput.Name = "rtbCommandOutput";
            this.rtbCommandOutput.Size = new System.Drawing.Size(576, 274);
            this.rtbCommandOutput.TabIndex = 7;
            this.rtbCommandOutput.Text = "";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(294, 33);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(50, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(239, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(32, 34);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Text";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Location = new System.Drawing.Point(6, 12);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(37, 15);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "label1";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(345, 34);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(73, 22);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "Parse Again";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(504, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 22);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgLogDetails
            // 
            this.dgLogDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLogDetails.Location = new System.Drawing.Point(0, 340);
            this.dgLogDetails.Name = "dgLogDetails";
            this.dgLogDetails.Size = new System.Drawing.Size(553, 593);
            this.dgLogDetails.TabIndex = 2;
            this.dgLogDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLogDetails_CellContentClick);
            this.dgLogDetails.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLogDetails_CellEnter);
            // 
            // btnExtractStats
            // 
            this.btnExtractStats.Location = new System.Drawing.Point(423, 33);
            this.btnExtractStats.Name = "btnExtractStats";
            this.btnExtractStats.Size = new System.Drawing.Size(75, 23);
            this.btnExtractStats.TabIndex = 8;
            this.btnExtractStats.Text = "Exrract Stats";
            this.btnExtractStats.UseVisualStyleBackColor = true;
            this.btnExtractStats.Click += new System.EventHandler(this.btnExtractStats_Click);
            // 
            // FrmFileContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 933);
            this.Controls.Add(this.dgLogDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFileContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileContent";
            this.Load += new System.EventHandler(this.FileContent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgLogDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RichTextBox rtbCommandOutput;
        private System.Windows.Forms.Button btnExtractStats;
    }
}