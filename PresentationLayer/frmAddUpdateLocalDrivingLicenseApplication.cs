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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private bool AddNewApplication(ref int ApplicationID)
        {
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = ctrlPersonCardWithFitler1._PersonID;
            Application.ApplicationTypeID = (int)clsApplicationType.enApplicationTypes.NewLocalDrivingLicenseService;
            Application.ApplicationStatus = (int)clsApplication.enStatus.New;
            Application.PaidFees = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.NewLocalDrivingLicenseService).ApplicationFees;
            Application.CreatedByUserID = Global.CurrentUser.UserID;
            if (Application.Save())
            {
                ApplicationID = Application.ApplicationID;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void fillComboBoxWithLicenseClasses()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();
            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                comboxLicenseClass.Items.Add(row["ClassName"]);
            }
        }
        private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            fillComboBoxWithLicenseClasses();

            if (Mode == enMode.Add)
            {
                LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                LBCreatedBy.Text = Global.CurrentUser.UserName;
                LBApplicationDate.Text = DateTime.Now.ToString();
                LBApplicationFees.Text = clsApplicationType.GetApplicationTypeInfoByID((int)clsApplicationType.enApplicationTypes.NewLocalDrivingLicenseService).ApplicationFees.ToString();
                return;
            }
            
            LbTitle.Text = "Update Local Application";

            LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(this.LocalDrivingLicenseApplicationID);

            ctrlPersonCardWithFitler1.LoadPersonInfo(this.LocalDrivingLicenseApplication.ApplicationInfo.ApplicantPersonID);

            LBDLApplicationID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            LBApplicationDate.Text = LocalDrivingLicenseApplication.ApplicationInfo.ApplicationDate.ToString();
            LBApplicationFees.Text = LocalDrivingLicenseApplication.ApplicationInfo.PaidFees.ToString();
            LBCreatedBy.Text = LocalDrivingLicenseApplication.ApplicationInfo.CreatedByUserInfo.UserName;
            comboxLicenseClass.SelectedItem = LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;

        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Add)
            {
                if (!clsPerson.DoesPersonExists(ctrlPersonCardWithFitler1._PersonID))
                {
                    MessageBox.Show("Enter a valid Person");
                    return;
                }
                if (clsLocalDrivingLicenseApplication.CompletedOneBefore(ctrlPersonCardWithFitler1._PersonID, clsLicenseClass.GetLicenseClassID(comboxLicenseClass.SelectedItem.ToString())))
                {
                    MessageBox.Show("Driver already completed an application");
                    return;
                }
                int ApplicationID = clsLocalDrivingLicenseApplication.DoesApplicantHaveActiveApplication(ctrlPersonCardWithFitler1._PersonID, clsLicenseClass.GetLicenseClassID(comboxLicenseClass.SelectedItem.ToString()));
                if (ApplicationID != -1)
                {
                    MessageBox.Show($"Driver already have an active application with applicationID = {ApplicationID}");
                    return;
                }
            }

            this.LocalDrivingLicenseApplication.LicenseClassID = clsLicenseClass.GetLicenseClassID(comboxLicenseClass.SelectedItem.ToString());

            if (this.Mode == enMode.Add)
            {
                int applicationID = -1;
                if (AddNewApplication(ref applicationID))
                {
                    this.LocalDrivingLicenseApplication.ApplicationID = applicationID;
                    LBDLApplicationID.Text = applicationID.ToString();
                }
                else
                {
                    MessageBox.Show($"Could not add new appliation");
                    this.Close();
                    return;
                }
            }
            if (this.LocalDrivingLicenseApplication.Save())
            {
                MessageBox.Show($"Saved Sucessfully");
            }
            else
            {
                MessageBox.Show($"Saving Failed");
            }
            this.Mode = enMode.Update;
            LbTitle.Text = "Update Local Application";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
    }
}