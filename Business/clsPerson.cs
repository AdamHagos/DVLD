using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsPerson
    {
        public int PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public clsCountry CountryInfo { get; private set; }
        public string ImagePath { get; set; }
        public static string[] GetFilterPeopleByOptions()
        {
            string[] FilterPeopleByOptions = new string[] { "Person ID", "National No" };
            return FilterPeopleByOptions;
        }
        public static string[] GetFilterPersonByOptions()
        {
            string[] FilterPersonByOptions = new string[] { "None", "Person ID", "National No", "FirstName", "SecondName", "ThirdName", "LastName", "Nationality", "Gendor", "Phone", "Email" };
            return FilterPersonByOptions;
        }
        public string FullName()
        {
            return this.FirstName + " " + this.SecondName + " " + this.ThirdName + " " + this.LastName;
        }
        public clsPerson()
        {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gendor = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";
        }
        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, int gendor, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gendor = gendor;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            CountryInfo = clsCountry.GetCountryByID(nationalityCountryID);
            ImagePath = imagePath;
        }
        public static bool DeletePersonByID(int ID)
        {
            return clsPeopleDataAccess.DeletePerson(ID);
        }
        private int _AddNewPerson()
        {
            return clsPeopleDataAccess.AddNewPerson(this.NationalNo,this.FirstName,this.SecondName,this.ThirdName,this.LastName,this.DateOfBirth,this.Gendor,this.Address,this.Phone,this.Email,this.NationalityCountryID,this.ImagePath);
        }
        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }
        public bool Save()
        {
            if (this.PersonID == -1)
            {
                this.PersonID = _AddNewPerson();
                if (this.PersonID != -1)
                {
                    this.CountryInfo = clsCountry.GetCountryByID(this.NationalityCountryID);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (_UpdatePerson())
                {
                    this.CountryInfo = clsCountry.GetCountryByID(this.NationalityCountryID);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static DataTable GetAllPeople(string Option, string UserInput = "")
        {
            return clsPeopleDataAccess.GetAllPeople(Option,UserInput);
        }
        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }
        public static clsPerson GetPersonInfoByID(int ID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            bool IsFound = clsPeopleDataAccess.GetPersonByID(ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            if (IsFound)
            {
                return new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllPeopleByFilter(string Option, string UserInput)
        {
            return clsPeopleDataAccess.GetAllPeople(Option,UserInput);
        }
        public static bool DoesNationalNoExists(string NationalNo)
        {
            return clsPeopleDataAccess.DoesNationalNoExists(NationalNo);
        }
        public static bool IsDriver(int PersonID, ref int DriverID)
        {
            return clsPeopleDataAccess.IsDriver(PersonID,ref DriverID);
        }
        public static bool DoesPersonExists(int PersonID)
        {
            return clsPeopleDataAccess.DoesPersonExists(PersonID);
        }
        public static int LocalDrivingLicenseApplicationStatus(int PersonID, int LicenseClassID)
        {
            return clsPeopleDataAccess.LocalDrivingLicenseApplicationStatus(PersonID, LicenseClassID);
        }
        public static int ApplicationID(int PersonID, int LicenseClassID)
        {
            return clsPeopleDataAccess.ApplicationID(PersonID, LicenseClassID);
        }
        public static int GetPersonID(string NationalNo)
        {
            return clsPeopleDataAccess.GetPersonID(NationalNo);
        }
        public static bool IsUser(int PersonID)
        {
            return clsPeopleDataAccess.IsUser(PersonID);
        }
    }
}
