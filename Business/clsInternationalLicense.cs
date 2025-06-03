using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; private set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        private clsInternationalLicense(int internationalLicenseID, int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            DriverInfo = clsDriver.GetDriverInfoByID(driverID);
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }
        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;
        }
        public static bool DeleteInternationalLicenseByID(int ID)
        {
            return clsInternationalLicensesDataAccess.DeleteInternationalLicense(ID);
        }
        private int _AddNewInternationalLicense()
        {
            return clsInternationalLicensesDataAccess.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }
        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicensesDataAccess.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }
        public bool Save()
        {
            if (this.InternationalLicenseID == -1)
            {
                this.InternationalLicenseID = _AddNewInternationalLicense();
                return (this.InternationalLicenseID != -1);
            }
            else
            {
                if (_UpdateInternationalLicense())
                {
                    DriverInfo = clsDriver.GetDriverInfoByID(this.DriverID);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static clsInternationalLicense GetInternationalLicenseInfoByID(int ID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            bool IsFound = clsInternationalLicensesDataAccess.GetInternationalLicenseByID(ID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsInternationalLicense(ID,ApplicationID,DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicensesDataAccess.GetDriverInternationalLicenses(DriverID);
        }
        public static bool DoesDriverHaveInternationalLicense(int DriverID, ref int InternationalLicenseID)
        {
            return clsInternationalLicensesDataAccess.DoesDriverHaveInternationalLicense(DriverID, ref InternationalLicenseID);
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesDataAccess.GetAllInternationalLicenses();
        }
    }
}
