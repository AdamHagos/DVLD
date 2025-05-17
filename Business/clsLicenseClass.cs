using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicenseClass
    {
        public int LicenseClassID { get; private set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }
        public enum enLicenseClasses { SmallMotorCycle = 1, HeavyMotorCycle, OrdinaryDrivingLicense, Commercial, Agricultural, SmallANDMediumbus, TruckANDHeavyVehicle }
        private clsLicenseClass(int licenseClassID, string className, string classDescription, byte minimumAllowedAge, byte defaultValidityLength, float classFees)
        {
            LicenseClassID = licenseClassID;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;
        }
        public clsLicenseClass()
        {
            LicenseClassID = -1;
            ClassName = "";
            ClassDescription = "";
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
        }
        public static bool DeleteLicenseClassByID(int ID)
        {
            return clsLicenseClassesDataAccess.DeleteLicenseClass(ID);
        }
        private int _AddNewLicenseClass()
        {
            return clsLicenseClassesDataAccess.AddNewLicenseClass(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }
        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassesDataAccess.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }
        public bool Save()
        {
            if (this.LicenseClassID == -1)
            {
                this.LicenseClassID = _AddNewLicenseClass();
                return (this.LicenseClassID != -1);
            }
            else
            {
                return _UpdateLicenseClass();
            }
        }
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesDataAccess.GetAllLicenseClasses();
        }
        public static clsLicenseClass GetLicenseClassInfoByID(int ID)
        {
            string ClassName = "";
            string ClassDescription = "";
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            float ClassFees = 0;

            bool IsFound = clsLicenseClassesDataAccess.GetLicenseClassByID(ID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);
            if (IsFound)
            {
                return new clsLicenseClass(ID,ClassName,ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees);
            }
            else
            {
                return null;
            }
        }
    }
}
