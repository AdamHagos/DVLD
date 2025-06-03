using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsUser
    {
        public int UserID { get; private set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            PersonInfo = clsPerson.GetPersonInfoByID(personID);
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }
        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;
        }
        public static string[] GetFilterUsersByOptions()
        {
            string[] FilterUsersByOptions = new string[] { "None", "Person ID", "Is Active", "UserName", "Full Name" };
            return FilterUsersByOptions;
        }
        public static bool DeleteUserByID(int ID)
        {
            return clsUsersDataAccess.DeleteUser(ID);
        }
        private int _AddNewUser()
        {
            return clsUsersDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
        }
        private bool _UpdateUser()
        {
            return clsUsersDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }
        public bool Save()
        {
            if (this.UserID == -1)
            {
                this.UserID = _AddNewUser();
                PersonInfo = clsPerson.GetPersonInfoByID(PersonID);
                return (this.UserID != -1);
            }
            else
            {
                PersonInfo = clsPerson.GetPersonInfoByID(PersonID);
                return _UpdateUser();
            }
        }
        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
        public static clsUser GetUserInfoByID(int ID)
        {
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            bool IsFound = clsUsersDataAccess.GetUserByID(ID,ref PersonID, ref UserName, ref Password, ref IsActive);
            if (IsFound)
            {
                return new clsUser(ID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }
        public static clsUser GetUserInfoByUserNameANDPassword(string UserName, string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = true;

            bool IsFound = clsUsersDataAccess.GetUserByUsernameANDPassword(ref UserID, ref PersonID, UserName, Password, ref IsActive);
            if (IsFound)
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }
        public static int GetUserID(string UserName)
        {
            return clsUsersDataAccess.GetUserID(UserName);
        }
        public static int GetPersonID(int UserID)
        {
            return clsUsersDataAccess.GetPersonID(UserID);
        }
    }
}
