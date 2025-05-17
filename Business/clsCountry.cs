using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int CountryID { get; private set; }
        public string CountryName { get; private set; }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }
        public static clsCountry GetCountryByID(int ID)
        {
            string CountryName = "";

            bool IsFound = clsCountriesDataAccess.GetCountryByID(ID,ref CountryName);
            if (IsFound)
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static int GetCountryID(string CountryName)
        {
            return clsCountriesDataAccess.GetCountryID(CountryName);
        }
        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }
    }
}
