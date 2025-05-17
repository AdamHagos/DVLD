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
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        private enum enMode { Add, Update }
        private enMode Mode;
        private int LocalDrivingLicenseApplicationID;
        private clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication;
        public frmAddUpdateLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            if (localDrivingLicenseApplicationID == -1)
            {
                Mode = enMode.Add;
            }
            else
            {
                Mode = enMode.Update;
                this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            }
        }
        private void fillComboBoxWithLicenseClasses()
        {
            comboxLicenseClass.DataSource = clsLicenseClass.GetAllLicenseClasses();
            comboxLicenseClass.DisplayMember = "ClassName";
        }
        private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            fillComboBoxWithLicenseClasses();

            if (Mode == enMode.Add)
            {
                LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                return;
            }

            LbTitle.Text = "Update Application";

            LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(this.LocalDrivingLicenseApplicationID);

            LBDLApplicationID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            LBApplicationDate.Text = LocalDrivingLicenseApplication.ApplicationInfo.ApplicationDate.ToString();
            LBApplicationFees.Text = LocalDrivingLicenseApplication.ApplicationInfo.PaidFees.ToString();
            LBCreatedBy.Text = LocalDrivingLicenseApplication.ApplicationInfo.CreatedByUserID.ToString();
            comboxLicenseClass;

        }
    }
}
