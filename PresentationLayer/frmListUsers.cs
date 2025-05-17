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
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(int.Parse(dGVListUsers.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUserByID(int.Parse(dGVListUsers.CurrentRow.Cells[0].Value.ToString())))
            {
                MessageBox.Show("User deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete User");
            }
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(int.Parse(dGVListUsers.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
        }
    }
}
