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
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private int PersonID;
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }
        public bool LoadApplicationInfo(int ApplicationID)
        {
            clsApplication Application = clsApplication.GetApplicationInfoByID(ApplicationID);
            if (Application != null)
            {
                this.PersonID = Application.ApplicantPersonID;
                LbID.Text = Application.ApplicationID.ToString();
                LbFees.Text = Application.ApplicationTypeInfo.ApplicationFees.ToString();
                LbType.Text = Application.ApplicationTypeInfo.ApplicationTypeTitle;
                LbApplicant.Text = Application.ApplicantPersonInfo.FullName();
                LbDate.Text = Application.ApplicationDate.ToString();
                LbStatusDate.Text = Application.LastStatusDate.ToString();
                LbCreatedBy.Text = Application.CreatedByUserInfo.UserName.ToString();
                if (Application.ApplicationStatus == (byte)clsApplication.enStatus.New)
                {
                    LbStatus.Text = "New";
                }
                else if (Application.ApplicationStatus == (byte)clsApplication.enStatus.Cancelled)
                {
                    LbStatus.Text = "Cancelled";
                }
                else
                {
                    LbStatus.Text = "Completed";
                }
                return true;
            }
            return false;
        }

        private void LkbViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(this.PersonID);
            frm.ShowDialog();
        }
    }
}
