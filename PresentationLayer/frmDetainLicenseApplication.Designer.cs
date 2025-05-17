namespace DVLD
{
    partial class frmDetainLicenseApplication
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
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.ctrlDriverLicenseInfoWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBFineFees = new System.Windows.Forms.TextBox();
            this.LBDetainDate = new System.Windows.Forms.Label();
            this.LBCreatedBy = new System.Windows.Forms.Label();
            this.LBLicenseID = new System.Windows.Forms.Label();
            this.LBDetainID = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTClose = new System.Windows.Forms.Button();
            this.BTDetain = new System.Windows.Forms.Button();
            this.LLShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.LLShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-1, 54);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(799, 384);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseIDSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseIDSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detain License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBFineFees);
            this.groupBox1.Controls.Add(this.LBDetainDate);
            this.groupBox1.Controls.Add(this.LBCreatedBy);
            this.groupBox1.Controls.Add(this.LBLicenseID);
            this.groupBox1.Controls.Add(this.LBDetainID);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TBFineFees
            // 
            this.TBFineFees.Location = new System.Drawing.Point(145, 67);
            this.TBFineFees.Name = "TBFineFees";
            this.TBFineFees.Size = new System.Drawing.Size(74, 20);
            this.TBFineFees.TabIndex = 9;
            // 
            // LBDetainDate
            // 
            this.LBDetainDate.AutoSize = true;
            this.LBDetainDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDetainDate.Location = new System.Drawing.Point(142, 49);
            this.LBDetainDate.Name = "LBDetainDate";
            this.LBDetainDate.Size = new System.Drawing.Size(77, 13);
            this.LBDetainDate.TabIndex = 8;
            this.LBDetainDate.Text = "[??/??/????]";
            // 
            // LBCreatedBy
            // 
            this.LBCreatedBy.AutoSize = true;
            this.LBCreatedBy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCreatedBy.Location = new System.Drawing.Point(461, 49);
            this.LBCreatedBy.Name = "LBCreatedBy";
            this.LBCreatedBy.Size = new System.Drawing.Size(35, 13);
            this.LBCreatedBy.TabIndex = 7;
            this.LBCreatedBy.Text = "[???]";
            // 
            // LBLicenseID
            // 
            this.LBLicenseID.AutoSize = true;
            this.LBLicenseID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLicenseID.Location = new System.Drawing.Point(461, 24);
            this.LBLicenseID.Name = "LBLicenseID";
            this.LBLicenseID.Size = new System.Drawing.Size(35, 13);
            this.LBLicenseID.TabIndex = 6;
            this.LBLicenseID.Text = "[???]";
            // 
            // LBDetainID
            // 
            this.LBDetainID.AutoSize = true;
            this.LBDetainID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDetainID.Location = new System.Drawing.Point(142, 23);
            this.LBDetainID.Name = "LBDetainID";
            this.LBDetainID.Size = new System.Drawing.Size(35, 13);
            this.LBDetainID.TabIndex = 5;
            this.LBDetainID.Text = "[???]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Detain Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fine Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Created By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "License ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detain ID:";
            // 
            // BTClose
            // 
            this.BTClose.Location = new System.Drawing.Point(690, 502);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(75, 33);
            this.BTClose.TabIndex = 10;
            this.BTClose.Text = "Close";
            this.BTClose.UseVisualStyleBackColor = true;
            this.BTClose.Click += new System.EventHandler(this.BTClose_Click);
            // 
            // BTDetain
            // 
            this.BTDetain.Enabled = false;
            this.BTDetain.Location = new System.Drawing.Point(609, 502);
            this.BTDetain.Name = "BTDetain";
            this.BTDetain.Size = new System.Drawing.Size(75, 33);
            this.BTDetain.TabIndex = 11;
            this.BTDetain.Text = "Detain";
            this.BTDetain.UseVisualStyleBackColor = true;
            this.BTDetain.Click += new System.EventHandler(this.BTDetain_Click);
            // 
            // LLShowLicensesHistory
            // 
            this.LLShowLicensesHistory.AutoSize = true;
            this.LLShowLicensesHistory.Enabled = false;
            this.LLShowLicensesHistory.Location = new System.Drawing.Point(31, 508);
            this.LLShowLicensesHistory.Name = "LLShowLicensesHistory";
            this.LLShowLicensesHistory.Size = new System.Drawing.Size(108, 13);
            this.LLShowLicensesHistory.TabIndex = 12;
            this.LLShowLicensesHistory.TabStop = true;
            this.LLShowLicensesHistory.Text = "Show License History";
            this.LLShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLShowLicensesHistory_LinkClicked);
            // 
            // LLShowLicenseInfo
            // 
            this.LLShowLicenseInfo.AutoSize = true;
            this.LLShowLicenseInfo.Enabled = false;
            this.LLShowLicenseInfo.Location = new System.Drawing.Point(165, 508);
            this.LLShowLicenseInfo.Name = "LLShowLicenseInfo";
            this.LLShowLicenseInfo.Size = new System.Drawing.Size(94, 13);
            this.LLShowLicenseInfo.TabIndex = 13;
            this.LLShowLicenseInfo.TabStop = true;
            this.LLShowLicenseInfo.Text = "Show License Info";
            this.LLShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLShowLicenseInfo_LinkClicked);
            // 
            // frmDetainLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.LLShowLicenseInfo);
            this.Controls.Add(this.LLShowLicensesHistory);
            this.Controls.Add(this.BTDetain);
            this.Controls.Add(this.BTClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Name = "frmDetainLicenseApplication";
            this.Text = "frmDetainLicenseApplication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBFineFees;
        private System.Windows.Forms.Label LBDetainDate;
        private System.Windows.Forms.Label LBCreatedBy;
        private System.Windows.Forms.Label LBLicenseID;
        private System.Windows.Forms.Label LBDetainID;
        private System.Windows.Forms.Button BTClose;
        private System.Windows.Forms.Button BTDetain;
        private System.Windows.Forms.LinkLabel LLShowLicensesHistory;
        private System.Windows.Forms.LinkLabel LLShowLicenseInfo;
    }
}