using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestType
    {
        public int TestTypeID { get; private set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }
        public enum enTestTypes { VisionTest = 1, Written, Practical }
        private clsTestType(int testTypeID, string testTypeTitle, string testTypeDescription, float testTypeFees)
        {
            TestTypeID = testTypeID;
            TestTypeTitle = testTypeTitle;
            TestTypeDescription = testTypeDescription;
            TestTypeFees = testTypeFees;
        }
        public clsTestType()
        {
            TestTypeID = -1;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = 0;
        }
        public static bool DeleteTestTypeByID(int ID)
        {
            return clsTestTypesDataAccess.DeleteTestType(ID);
        }
        private int _AddNewTestType()
        {
            return clsTestTypesDataAccess.AddNewTestType(this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        private bool _UpdateTestType()
        {
            return clsTestTypesDataAccess.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        public bool Save()
        {
            if (this.TestTypeID == -1)
            {
                this.TestTypeID = _AddNewTestType();
                return (this.TestTypeID != -1);

            }
            else
            {
                return _UpdateTestType();
            }
        }
        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }
        public static clsTestType GetTestTypeInfoByID(int ID)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            float TestTypeFees = 0;

            bool IsFound = clsTestTypesDataAccess.GetTestTypeByID(ID,ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);
            if (IsFound)
            {
                return new clsTestType(ID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else
            {
                return null;
            }
        }
    }
}
