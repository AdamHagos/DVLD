namespace DVLD
{
    partial class frmListDrivers
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGVListDrivers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIssueInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDrivers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 107);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Drivers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dGVListDrivers
            // 
            this.dGVListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListDrivers.Location = new System.Drawing.Point(27, 211);
            this.dGVListDrivers.Name = "dGVListDrivers";
            this.dGVListDrivers.Size = new System.Drawing.Size(761, 352);
            this.dGVListDrivers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "# Records:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "???";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonInfo,
            this.tsmIssueInternationalLicense,
            this.tsmShowPersonLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 92);
            // 
            // tsmShowPersonInfo
            // 
            this.tsmShowPersonInfo.Name = "tsmShowPersonInfo";
            this.tsmShowPersonInfo.Size = new System.Drawing.Size(225, 22);
            this.tsmShowPersonInfo.Text = "Show Person Info";
            this.tsmShowPersonInfo.Click += new System.EventHandler(this.tsmShowPersonInfo_Click);
            // 
            // tsmIssueInternationalLicense
            // 
            this.tsmIssueInternationalLicense.Name = "tsmIssueInternationalLicense";
            this.tsmIssueInternationalLicense.Size = new System.Drawing.Size(225, 22);
            this.tsmIssueInternationalLicense.Text = "Issue International License";
            this.tsmIssueInternationalLicense.Click += new System.EventHandler(this.tsmIssueInternationalLicense_Click);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(225, 22);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmShowPersonLicenseHistory_Click);
            // 
            // frmListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVListDrivers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListDrivers";
            this.Text = "frmListDrivers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListDrivers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dGVListDrivers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmIssueInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
    }
}