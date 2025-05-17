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
    public partial class frmAddUpdateUser : Form
    {
        private enum enMode { Add, Update }
        private enMode Mode;
        private clsUser User;
        private int UserID;
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            if (UserID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Update;
                this.UserID = UserID;
                //User = clsUser.GetUserInfoByID(UserID);
                //ctrlPersonCardWithFitler1.LoadPersonInfo(UserID);
                //LbTitle.Text = "Update User";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.Add)
            {
                this.User = new clsUser();
                return;
            }

            this.User = clsUser.GetUserInfoByID(this.UserID);

            LbTitle.Text = "Update User";

            LBUserID.Text = this.User.UserID.ToString();
            TbPassword.Text = this.User.Password.ToString();
            TbConfirmPassword.Text = this.User.Password.ToString();
            CBIsActive.Checked = this.User.IsActive;

            ctrlPersonCardWithFitler1.LoadPersonInfo(this.User.PersonID);
        }

        private void BTSave_Click(object sender, EventArgs e)
        {

        }
    }
}
