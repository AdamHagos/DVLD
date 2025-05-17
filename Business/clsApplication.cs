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
    public class clsApplication
    {
        public int ApplicationID { get; private set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson ApplicantPersonInfo { get; private set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationType ApplicationTypeInfo { get; private set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo { get; private set; }

        public enum enStatus { New = 1, Cancelled, Completed };

        private clsApplication(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus, DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicantPersonInfo = clsPerson.GetPersonInfoByID(applicantPersonID);
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
        }
        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
        }
        public static bool DeleteApplicationByID(int ID)
        {
            return clsApplicationsDataAccess.DeleteApplication(ID);
        }
        private int _AddNewApplication()
        {
            return clsApplicationsDataAccess.AddNewApplication(this.ApplicantPersonID,this.ApplicationDate,this.ApplicationTypeID,this.ApplicationStatus,this.LastStatusDate,this.PaidFees,this.CreatedByUserID);
        }
        private bool _UpdateApplication()
        {
            return clsApplicationsDataAccess.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }
        public bool Save()
        {
            if (this.ApplicationID == -1)
            {
                this.ApplicationID = _AddNewApplication();
                return (this.ApplicationID != -1);
            }
            else
            {
                ApplicantPersonInfo = clsPerson.GetPersonInfoByID(ApplicantPersonID);
                return _UpdateApplication();
            }
        }
        public static DataTable GetAllApplications()
        {
            return clsApplicationsDataAccess.GetAllApplications();
        }
        public static clsApplication GetApplicationInfoByID(int ID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;

            bool IsFound = clsApplicationsDataAccess.GetApplicationInfoByID(ID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsApplication(ID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
    }
}
