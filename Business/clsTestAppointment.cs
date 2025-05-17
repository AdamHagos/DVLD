using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        public int TestAppointmentID { get; private set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplicationInfo { get; private set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestApplicationID = -1;
        }
        private clsTestAppointment(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, float paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            LocalDrivingLicenseApplicationInfo = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(localDrivingLicenseApplicationID);
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeTestApplicationID = retakeTestApplicationID;
        }
        public static bool DeleteTestAppointmentByID(int ID)
        {
            return clsTestAppointmentsDataAccess.DeleteTestAppointment(ID);
        }
        private int _AddNewTestAppointment()
        {
            return clsTestAppointmentsDataAccess.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }
        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsDataAccess.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }
        public bool Save()
        {
            if (this.TestAppointmentID == -1)
            {
                this.TestAppointmentID = _AddNewTestAppointment();
                return (this.TestAppointmentID != -1);

            }
            else
            {
                if (_UpdateTestAppointment())
                {
                    this.LocalDrivingLicenseApplicationInfo = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(this.LocalDrivingLicenseApplicationID);
                    return true;
                }
                else
                {
                    this.LocalDrivingLicenseApplicationInfo = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID(this.LocalDrivingLicenseApplicationID);
                    return false;
                }
            }
        }
        public static DataTable GetTestAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetTestAppointments(LocalDrivingLicenseApplicationID,TestTypeID);
        }
        public static clsTestAppointment GetTestAppointmentInfoByID(int ID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            float PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            bool IsFound = clsTestAppointmentsDataAccess.GetTestAppointmentByID(ID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked,ref RetakeTestApplicationID);
            if (IsFound)
            {
                return new clsTestAppointment(ID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }
        }
        public static bool IsTestScheduledNotTakenYet(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.IsTestScheduledNotTakenYet(LocalDrivingLicenseApplicationID, TestTypeID);
        }
        public static bool IsTestAppointmentTaken(int TestAppointmentID)
        {
            return clsTestAppointment.IsTestAppointmentTaken(TestAppointmentID);
        }
    }
}
