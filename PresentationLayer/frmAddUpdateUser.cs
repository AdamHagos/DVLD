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
                //User = clsUser.GetUserInfoByID(UserID);
                //ctrlPersonCardWithFitler1.LoadPersonInfo(UserID);
                //LbTitle.Text = "Update User";
            }
            this.UserID = UserID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!clsPerson.DoesPersonExists(ctrlPersonCardWithFitler1._PersonID))
            {
                MessageBox.Show("Person Does not Exist");
                return;
            }
            if (clsPerson.IsUser(ctrlPersonCardWithFitler1._PersonID))
            {
                MessageBox.Show("Person Is already a user");
                return;
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
            }
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
            TbUserName.Text = this.User.UserName;
            TbPassword.Text = this.User.Password.ToString();
            TbConfirmPassword.Text = this.User.Password;
            CBIsActive.Checked = this.User.IsActive;

            ctrlPersonCardWithFitler1.LoadPersonInfo(this.User.PersonID);
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            if (!clsPerson.DoesPersonExists(ctrlPersonCardWithFitler1._PersonID))
            {
                MessageBox.Show("Enter a valid Person");
                return;
            }
            if (TbPassword.Text != TbConfirmPassword.Text)
            {
                MessageBox.Show("the 2 passwords should match");
                return;
            }
            this.User.PersonID = ctrlPersonCardWithFitler1._PersonID;
            this.User.Password = TbPassword.Text;
            this.User.UserName = TbUserName.Text;
            this.User.IsActive = CBIsActive.Checked;
            if (this.User.Save())
            {
                MessageBox.Show("user saved successfully");
            }
            else
            {
                MessageBox.Show("user could not be saved");
            }
            this.Mode = enMode.Update;
            LbTitle.Text = "Update User";
        }
    }
}
