using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Global.CurrentUser = clsUser.GetUserInfoByUserNameANDPassword(tbUserName.Text, tbPassword.Text);
            
            if (Global.CurrentUser != null)
            {
                if (Global.CurrentUser.IsActive == false )
                {
                    MessageBox.Show("Please Contact Your Admin");
                    return;
                }
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or Password Is incorrect");
            }
        }
    }
}
