using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        public int DetainID { get; private set; }
        public int LicenseID { get; set; }
        public clsLicense LicenseInfo { get; private set; }
        public DateTime DetainDate { get; set; }
        public float FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        private clsDetainedLicense(int detainID, int licenseID, DateTime detainDate, float fineFees, int createdByUserID, bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            DetainID = detainID;
            LicenseID = licenseID;
            LicenseInfo = clsLicense.GetLicenseInfoByID(licenseID);
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }
        public clsDetainedLicense()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = new DateTime(1900,1,1);
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
        }
        public static bool DeleteDetainedLicenseByID(int ID)
        {
            return clsDetainedLicensesDataAccess.DeleteDetainedLicense(ID);
        }
        private int _AddNewDetainedLicense()
        {
            return clsDetainedLicensesDataAccess.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }
        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicensesDataAccess.UpdateDetainedLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }
        public bool Save()
        {
            if (this.DetainID == -1)
            {
                this.DetainID = _AddNewDetainedLicense();
                this.LicenseInfo = clsLicense.GetLicenseInfoByID(this.LicenseID);
                return (this.DetainID != -1);
            }
            else
            {
                this.LicenseInfo = clsLicense.GetLicenseInfoByID(this.LicenseID);
                return _UpdateDetainedLicense();
            }
        }
        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesDataAccess.GetAllDetainedLicenses();
        }
        public static clsDetainedLicense GetDetainedLicenseInfoByID(int ID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = clsDetainedLicensesDataAccess.GetDetainedLicenseByID(ID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);
            if (IsFound)
            {
                return new clsDetainedLicense(ID,LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }
        public static clsDetainedLicense GetDetainedLicenseInfoByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool IsFound = clsDetainedLicensesDataAccess.GetDetainedLicenseByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);
            if (IsFound)
            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsDetained(int LicenseID)
        {
            return clsDetainedLicensesDataAccess.IsDetained(LicenseID);
        }
    }
}
