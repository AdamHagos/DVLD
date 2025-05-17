using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public int ApplicationTypeID { get; private set; }
        public string ApplicationTypeTitle { get; set; }
        public float ApplicationFees { get; set; }
        public enum enApplicationTypes { NewLocalDrivingLicenseService = 1, RenewDrivingLicenseService, ReplacementForALostDrivingLicense, ReplacementForADamagedDrivingLicense, ReleaseDetainedDrivingLicense, NewInternationalLicense, RetakeTest }
        private clsApplicationType(int applicationTypeID, string applicationTypeTitle, float applicationFees)
        {
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;
        }
        public clsApplicationType()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = "";
            ApplicationFees = 0;
        }
        public static bool DeleteApplicationTypeByID(int ID)
        {
            return clsApplicationTypesDataAccess.DeleteApplicationType(ID);
        }
        private int _AddNewApplicationType()
        {
            return clsApplicationTypesDataAccess.AddNewApplicationType(this.ApplicationTypeTitle,this.ApplicationFees);
        }
        private bool _UpdateApplicationType()
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }
        public bool Save()
        {
            if (this.ApplicationTypeID == -1)
            {
                this.ApplicationTypeID = _AddNewApplicationType();
                return (this.ApplicationTypeID != -1);
            }
            else
            {
                return _UpdateApplicationType();
            }
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }
        public static clsApplicationType GetApplicationTypeInfoByID(int ID)
        {
            string ApplicationTypeTitle = "";
            float ApplicationFees = 0;

            bool IsFound = clsApplicationTypesDataAccess.GetApplicationTypeByID(ID, ref ApplicationTypeTitle, ref ApplicationFees);

            if (IsFound)
            {
                return new clsApplicationType(ID,ApplicationTypeTitle,ApplicationFees);
            }
            else
            {
                return null;
            }
        }
    }
}
