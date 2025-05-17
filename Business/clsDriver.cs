using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {
        public int DriverID { get; private set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; private set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        private clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            PersonInfo = clsPerson.GetPersonInfoByID(personID);
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }
        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
        }
        public static string[] GetFilterDriversByOptions()
        {
            string[] FilterDriversByOptions = new string[] { "None", "Person ID", "Driver ID", "National No", "Full Name"};
            return FilterDriversByOptions;
        }
        public static bool DeleteDriverByID(int ID)
        {
            return clsDriversDataAccess.DeleteDriver(ID);
        }
        private int _AddNewDriver()
        {
            return clsDriversDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }
        private bool _UpdateDriver()
        {
            return clsDriversDataAccess.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }
        public bool Save()
        {
            if (this.DriverID == -1)
            {
                this.DriverID = _AddNewDriver();
                return (this.DriverID != -1);
            }
            else
            {
                if (_UpdateDriver())
                {
                    PersonInfo = clsPerson.GetPersonInfoByID(this.PersonID);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static DataTable GetAllDrivers()
        {
            return clsDriversDataAccess.GetAllDrivers();
        }
        public static clsDriver GetDriverInfoByID(int ID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            bool IsFound = clsDriversDataAccess.GetDriverByID(ID, ref PersonID, ref CreatedByUserID, ref CreatedDate);
            if (IsFound)
            {
                return new clsDriver(ID,PersonID,CreatedByUserID,CreatedDate);
            }
            else
            {
                return null;
            }

        }
    }
}
