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
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }
        public bool LoadDriverLicenseInfo(int LicenseID)
        {
            clsLicense License = clsLicense.GetLicenseInfoByID(LicenseID);
            if (License != null)
            {
                LbClass.Text = License.LicenseClassInfo.ClassName;
                LbName.Text = License.DriverInfo.PersonInfo.FullName();
                LbLicenseID.Text = License.LicenseID.ToString();
                LbNationalNo.Text = License.DriverInfo.PersonInfo.NationalNo;
                if (License.DriverInfo.PersonInfo.Gendor == 0)
                {
                    LbGendor.Text = "Male";
                }
                else
                {
                    LbGendor.Text = "Female";
                }
                LbIssueDate.Text = License.IssueDate.ToString();
                if (License.IssueReason == (byte)clsLicense.enIssueReasons.FirstTime)
                {
                    LbIssueReason.Text = "FirstTime";
                }
                else if (License.IssueReason == (byte)clsLicense.enIssueReasons.ReplacementForDamaged)
                {
                    LbIssueReason.Text = "Replacement For Damaged";
                }
                else if (License.IssueReason == (byte)clsLicense.enIssueReasons.Renew)
                {
                    LbIssueReason.Text = "Renew";
                }
                else
                {
                    LbIssueReason.Text = "Replacement For Lost";
                }
                LbNotes.Text = License.Notes;
                LbIsActive.Text = License.IsActive.ToString();
                LbDateOfBirth.Text = License.DriverInfo.PersonInfo.DateOfBirth.ToString();
                LbDriverID.Text = License.DriverID.ToString();
                LbExpirationDate.Text = License.ExpirationDate.ToString();
                if (clsDetainedLicense.IsDetained(License.LicenseID))
                {
                    LbIsDetained.Text = "True";
                }
                else
                {
                    LbIsDetained.Text = "False";
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
