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
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public bool LoadDriverInternationalLicenseInfo(int InternationalLicenseID)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.GetInternationalLicenseInfoByID(InternationalLicenseID);
            if (InternationalLicense != null)
            {
                LbName.Text = InternationalLicense.DriverInfo.PersonInfo.FirstName;
                LbIntLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
                LbLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
                LBNationalNo.Text = InternationalLicense.DriverInfo.PersonInfo.NationalNo;
                LbIssueDate.Text = InternationalLicense.IssueDate.ToString();
                LbApplicationID.Text = InternationalLicense.ApplicationID.ToString();
                if (InternationalLicense.DriverInfo.PersonInfo.Gendor == 0)
                {
                    LbGendor.Text = "Male";
                }
                else
                {
                    LbGendor.Text = "Female";
                }
                if (InternationalLicense.IsActive)
                {
                    LbIsActive.Text = "true";
                }
                else
                {
                    LbIsActive.Text = "false";
                }
                LbDateOfBirth.Text = InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToString();
                LbDriverID.Text = InternationalLicense.DriverID.ToString();
                LbExpirationDate.Text = InternationalLicense.ExpirationDate.ToString();

                return true;
            }
            else
            {
                MessageBox.Show("International License Does not exist");
                return false;
            }
        }
    }
}
