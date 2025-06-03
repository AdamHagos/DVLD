using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsLicense
    {
        public int LicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; private set; }
        public int LicenseClass { get; set; }
        public clsLicenseClass LicenseClassInfo { get; private set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public enum enIssueReasons { FirstTime = 1, Renew, ReplacementForDamaged, ReplacementForLost}
        private clsLicense(int licenseID, int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate, string notes, float paidFees, bool isActive, int issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            DriverInfo = clsDriver.GetDriverInfoByID(driverID);
            LicenseClass = licenseClass;
            LicenseClassInfo = clsLicenseClass.GetLicenseClassInfoByID(licenseClass);
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }
        public clsLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
            IsActive = false;
            IssueReason = 0;
            CreatedByUserID = -1;
        }
        public static bool DeleteLicenseByID(int ID)
        {
            return clsLicensesDataAccess.DeleteLicense(ID);
        }
        private int _AddNewLicense()
        {
            return clsLicensesDataAccess.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }
        private bool _UpdateLicense()
        {
            return clsLicensesDataAccess.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }
        public bool Save()
        {
            if (this.LicenseID == -1)
            {
                this.LicenseID = _AddNewLicense();
                return (this.LicenseID != -1);
            }
            else
            {
                LicenseClassInfo = clsLicenseClass.GetLicenseClassInfoByID(LicenseClass);
                return _UpdateLicense();
            }
        }
        public static DataTable GetAllLicenses()
        {
            return clsLicensesDataAccess.GetAllLicenses();
        }
        public static clsLicense GetLicenseInfoByID(int ID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            float PaidFees = 0;
            bool IsActive = false;
            int IssueReason = 0;
            int CreatedByUserID = -1;

            bool IsFound = clsLicensesDataAccess.GetLicenseByID(ID,ref ApplicationID,ref DriverID, ref LicenseClass,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees,ref IsActive,ref IssueReason,ref CreatedByUserID);
            if (IsFound)
            {
                return new clsLicense(ID,ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetDriverLicenses(int DriverID)
        {
            return clsLicensesDataAccess.GetDriverLicenses(DriverID);
        }
        public static int GetActiveOrdinaryLicenseID(int DriverID)
        {
            return clsLicensesDataAccess.GetActiveOrdinaryLicenseID(DriverID);
        }
        public static int GetDriverID(int LicenseID)
        {
            return clsLicensesDataAccess.GetDriverID(LicenseID);
        }
    }
}