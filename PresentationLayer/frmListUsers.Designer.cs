namespace DVLD
{
    partial class frmListUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGVListUsers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextmenustripe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextmenustripe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Users";
            // 
            // dGVListUsers
            // 
            this.dGVListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListUsers.ContextMenuStrip = this.contextmenustripe;
            this.dGVListUsers.Location = new System.Drawing.Point(12, 185);
            this.dGVListUsers.Name = "dGVListUsers";
            this.dGVListUsers.Size = new System.Drawing.Size(761, 352);
            this.dGVListUsers.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "[???]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(303, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 107);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filter By:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 37);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextmenustripe
            // 
            this.contextmenustripe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.tsmAddNewUser,
            this.tsmEdit,
            this.tsmDelete,
            this.tsmChangePassword,
            this.tsmSendEmail,
            this.tsmPhoneCall});
            this.contextmenustripe.Name = "contextmenustripe";
            this.contextmenustripe.Size = new System.Drawing.Size(181, 180);
            this.contextmenustripe.Text = "contextmenustripe";
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(180, 22);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // tsmAddNewUser
            // 
            this.tsmAddNewUser.Name = "tsmAddNewUser";
            this.tsmAddNewUser.Size = new System.Drawing.Size(180, 22);
            this.tsmAddNewUser.Text = "Add New User";
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(180, 22);
            this.tsmEdit.Text = "Edit";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(180, 22);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(180, 22);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmPhoneCall
            // 
            this.tsmPhoneCall.Name = "tsmPhoneCall";
            this.tsmPhoneCall.Size = new System.Drawing.Size(180, 22);
            this.tsmPhoneCall.Text = "Phone Call";
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVListUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListUsers";
            this.Text = "frmListUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dGVListUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextmenustripe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVListUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextmenustripe;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmPhoneCall;
    }
}