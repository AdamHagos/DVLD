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
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public bool LoadUserInfo(int UserID)
        {
            int PersonID = clsUser.GetPersonID(UserID);

            if (!ctrlPersonCard1.LoadPersonInfo(PersonID))
            {
                return false;
            }
            clsUser User = clsUser.GetUserInfoByID(UserID);
            if (User != null)
            {
                LbUserID.Text = UserID.ToString();
                LbUsername.Text = User.UserName;
                if (User.IsActive)
                {
                    LbIsActive.Text = "True";
                }
                else
                {
                    LbIsActive.Text = "False";
                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
