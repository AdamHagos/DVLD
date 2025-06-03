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
    public partial class frmChangePassword : Form
    {
        clsUser User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            this.User = clsUser.GetUserInfoByID(UserID);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (User != null)
            {
                ctrlPersonCard1.LoadPersonInfo(User.PersonID);
                //return true;
            }
            else
            {
                //return false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (User.Password != TbCurrentPassword.Text)
            {
                errorProvider1.SetError(TbCurrentPassword, "Password is wrong");
            }
            else
            {
                errorProvider1.SetError(TbCurrentPassword, "");
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TbConfirmPassword.Text != tbNewPassword.Text)
            {
                errorProvider1.SetError(TbConfirmPassword, "It should Match with New Password");
            }
            else
            {
                errorProvider1.SetError(TbConfirmPassword, "");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(tbNewPassword.Text == TbConfirmPassword.Text))
            {
                MessageBox.Show("The Two Passwords are not the same");
            }
            else
            {
                this.User.Password = tbNewPassword.Text;
                if (User.Save())
                {
                    MessageBox.Show("Saved Succesfully");
                }
                else
                {
                    MessageBox.Show("Cant be saved");
                }
            }
        }
    }
}
