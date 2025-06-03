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
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        private int _LicenseID;
        public bool LoadLocalDrivingLicenseApplicationInfo(int LocalDLAInfo)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(LocalDLAInfo);
            if (LocalDrivingLicenseApplication != null)
            {
                LbDLAppID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                LbAppliedForLicense.Text = LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
                LbPassedTests.Text = clsTest.PassedTests(LocalDLAInfo).ToString() + this._TotalTests;
            }
            else
            {
                return false;
            }
            LKShowLicenseInfo.Enabled = clsLocalDrivingLicenseApplication.IsLicenseIssued(LocalDLAInfo,ref this._LicenseID);
            return ctrlApplicationBasicInfo1.LoadApplicationInfo(LocalDrivingLicenseApplication.ApplicationID);
        }
        private string _TotalTests = "/3";

        private void LKShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(this._LicenseID);
            frm.ShowDialog();
        }
    }
}
