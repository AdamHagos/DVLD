using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTest
    {
        public int TestID { get; private set; }
        public int TestAppointmentID { get; set;}
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        private clsTest(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
        }
        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;
        }
        public static bool DeleteTestByID(int ID)
        {
            return clsTestsDataAccess.DeleteTest(ID);
        }
        private int _AddNewTest()
        {
            return clsTestsDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }
        private bool _UpdateTest()
        {
            return clsTestsDataAccess.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }
        public bool Save()
        {
            if (this.TestID == -1)
            {
                this.TestID = _AddNewTest();

                return (this.TestID != -1);
            }
            else
            {
                return _UpdateTest();
            }
        }
        public static DataTable GetAllTests()
        {
            return clsTestsDataAccess.GetAllTests();
        }
        public static clsTest GetTestInfoByID(int ID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            bool IsFound = clsTestsDataAccess.GetTestByID(ID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsTest(ID,TestAppointmentID,TestResult,Notes,CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static int PassedTests(int LocalDrivingLicenseApplicationID)
        {
            return clsTestsDataAccess.PassedTests(LocalDrivingLicenseApplicationID);
        }
        public static bool PassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestsDataAccess.PassedTest(LocalDrivingLicenseApplicationID,TestTypeID);
        }
        public static int Trials(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestsDataAccess.Trails(LocalDrivingLicenseApplicationID, TestTypeID);
        }
    }
}
