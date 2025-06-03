using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication
    {
        public int LocalDrivingLicenseApplicationID { get; private set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo { get; private set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo { get; private set; }
        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
        }
        private clsLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int applicationID, int licenseClassID)
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            ApplicationID = applicationID;
            ApplicationInfo = clsApplication.GetApplicationInfoByID(applicationID);
            LicenseClassID = licenseClassID;
            LicenseClassInfo = clsLicenseClass.GetLicenseClassInfoByID(licenseClassID);
        }
        public static bool DeleteLocalDrivingLicenseApplicationByID(int ID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.DeleteLocalDrivingLicenseApplication(ID);
        }
        private int _AddNewLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.AddNewLocalDrivingLicenseApplication(this.ApplicationID,this.LicenseClassID);
        }
        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }
        public bool Save()
        {
            if (this.LocalDrivingLicenseApplicationID == -1)
            {
                this.LocalDrivingLicenseApplicationID = _AddNewLocalDrivingLicenseApplication();
                if (this.LocalDrivingLicenseApplicationID != -1)
                {
                    this.LicenseClassInfo = clsLicenseClass.GetLicenseClassInfoByID(this.LicenseClassID);
                    this.ApplicationInfo = clsApplication.GetApplicationInfoByID(this.ApplicationID);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                if (_UpdateLocalDrivingLicenseApplication())
                {
                    this.LicenseClassInfo = clsLicenseClass.GetLicenseClassInfoByID(this.LicenseClassID);
                    this.ApplicationInfo = clsApplication.GetApplicationInfoByID(this.ApplicationID);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplications();
        }
        public static int DoesApplicantHaveActiveApplication(int ApplicantID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.DoesApplicantHaveActiveApplication(ApplicantID, LicenseClassID);
        }
        public static clsLocalDrivingLicenseApplication GetLocalDrivingLicenseApplicationInfoByID(int ID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationsDataAccess.GetLocalDrivingLicenseApplicationByID(ID, ref ApplicationID, ref LicenseClassID);
            if (IsFound)
            {
                return new clsLocalDrivingLicenseApplication(ID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsLicenseIssued(int LocalDrivingLicenseApplicationID, ref int LicenseID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.IsLicenseIssued(LocalDrivingLicenseApplicationID, ref LicenseID);
        }
        public static bool CompletedOneBefore(int ApplicantID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.CompletedOneBefore(ApplicantID,LicenseClassID);
        }
        public static int GetApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetApplicationID(LocalDrivingLicenseApplicationID);
        }
    }
}
