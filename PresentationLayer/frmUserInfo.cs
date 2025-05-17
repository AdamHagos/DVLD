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
    public partial class frmUserInfo : Form
    {
        private int UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            if (!ctrlUserCard1.LoadUserInfo(UserID))
            {
                MessageBox.Show("User Does Not Exit");
                this.Close();
            }
            
        }
    }
}
