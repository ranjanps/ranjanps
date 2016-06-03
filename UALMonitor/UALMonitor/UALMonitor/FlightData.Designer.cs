namespace UALMonitor
{
    partial class FlightData
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbToAirport = new System.Windows.Forms.ComboBox();
            this.cmbToCountry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbFromAirport = new System.Windows.Forms.ComboBox();
            this.cmbFromCountry = new System.Windows.Forms.ComboBox();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbToAirport);
            this.groupBox1.Controls.Add(this.cmbToCountry);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbFromAirport);
            this.groupBox1.Controls.Add(this.cmbFromCountry);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "To Airport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "To Country";
            // 
            // cmbToAirport
            // 
            this.cmbToAirport.FormattingEnabled = true;
            this.cmbToAirport.Location = new System.Drawing.Point(288, 38);
            this.cmbToAirport.Name = "cmbToAirport";
            this.cmbToAirport.Size = new System.Drawing.Size(146, 21);
            this.cmbToAirport.TabIndex = 10;
            // 
            // cmbToCountry
            // 
            this.cmbToCountry.FormattingEnabled = true;
            this.cmbToCountry.Location = new System.Drawing.Point(288, 13);
            this.cmbToCountry.Name = "cmbToCountry";
            this.cmbToCountry.Size = new System.Drawing.Size(146, 21);
            this.cmbToCountry.TabIndex = 9;
            this.cmbToCountry.SelectedIndexChanged += new System.EventHandler(this.cmbToCountry_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "From Airport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "From Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(604, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(604, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cmbFromAirport
            // 
            this.cmbFromAirport.FormattingEnabled = true;
            this.cmbFromAirport.Location = new System.Drawing.Point(74, 37);
            this.cmbFromAirport.Name = "cmbFromAirport";
            this.cmbFromAirport.Size = new System.Drawing.Size(146, 21);
            this.cmbFromAirport.TabIndex = 2;
            // 
            // cmbFromCountry
            // 
            this.cmbFromCountry.FormattingEnabled = true;
            this.cmbFromCountry.Location = new System.Drawing.Point(75, 12);
            this.cmbFromCountry.Name = "cmbFromCountry";
            this.cmbFromCountry.Size = new System.Drawing.Size(146, 21);
            this.cmbFromCountry.TabIndex = 1;
            this.cmbFromCountry.SelectedIndexChanged += new System.EventHandler(this.cmbFromCountry_SelectedIndexChanged);
            // 
            // grdResult
            // 
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(3, 69);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(1266, 684);
            this.grdResult.TabIndex = 2;
            // 
            // FlightData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 760);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "FlightData";
            this.Text = "FlightData";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbToAirport;
        private System.Windows.Forms.ComboBox cmbToCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbFromAirport;
        private System.Windows.Forms.ComboBox cmbFromCountry;
        private System.Windows.Forms.DataGridView grdResult;
    }
}