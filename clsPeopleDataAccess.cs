using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace DVLD_DataAccess
{
    public class clsPeopleDataAccess
    {
        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO People(NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)
                              VALUES(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);
                                                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE People
                             SET NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }

            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllPeople(string Option, string UserInput = "")
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "";
            SqlCommand command = new SqlCommand(Query, connection);

            if (Option == "None")
            {
                Query = @"Select * From People_View";

            }
            else if (Option == "Person ID")
            {
                if (int.TryParse(UserInput, out int PersonID))
                {
                    Query = @"Select * From People_View
                               WHERE PersonID = @PersonID";
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                }
            }
            else if (Option == "National No")
            {
                Query = @"Select * From People_View
                               WHERE NationalNo = @NationalNo";
                command.Parameters.AddWithValue("@NationalNo", UserInput);
            }
            else if (Option == "FirstName")
            {
                Query = @"Select * From People_View
                               WHERE FirstName = @FirstName";
                command.Parameters.AddWithValue("@FirstName", UserInput);
            }
            else if (Option == "SecondName")
            {
                Query = @"Select * From People_View
                               WHERE SecondName = @SecondName";
                command.Parameters.AddWithValue("@SecondName", UserInput);
            }
            else if (Option == "ThirdName")
            {
                Query = @"Select * From People_View
                               WHERE ThirdName = @ThirdName";
                command.Parameters.AddWithValue("@ThirdName", UserInput);
            }
            else if (Option == "LastName")
            {
                Query = @"Select * From People_View
                               WHERE LastName = @LastName";
                command.Parameters.AddWithValue("@LastName", UserInput);
            }
            else if (Option == "Nationality")
            {
                Query = @"Select * From People_View
                               WHERE CountryName = @CountryName";
                command.Parameters.AddWithValue("@CountryName", UserInput);
            }
            else if (Option == "Gendor")
            {
                Query = @"Select * From People_View
                               WHERE Gendor = @Gendor";
                command.Parameters.AddWithValue("@Gendor", UserInput);
            }
            else if (Option == "Phone")
            {
                Query = @"Select * From People_View
                               WHERE Phone = @Phone";
                command.Parameters.AddWithValue("@Phone", UserInput);
            }
            else
            {
                Query = @"Select * From People_View
                               WHERE Email = @Email";
                command.Parameters.AddWithValue("@Email", UserInput);
            }

            command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool DoesNationalNoExists(int NationalNo)
        {
            bool DoesNationalNoExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select * From People_View
                               WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    DoesNationalNoExists = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return DoesNationalNoExists;
        }
        public static bool DeletePerson(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM People
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool GetPersonByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsRecordFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM People
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    LastName = (string)reader["LastName"];
                    Gendor = (int)reader["Gendor"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                    IsRecordFound = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsRecordFound;
        }
        public static bool IsDriver(int PersonID, ref int DriverID)
        {
            bool IsDriver = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT DriverID
                             FROM   Drivers
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    DriverID = (int)Result;
                    IsDriver = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsDriver;
        }
        public static bool DoesPersonExists(int PersonID)
        {
            bool DoesPersonExists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Found = 1
                             FROM   People
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    DoesPersonExists = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return DoesPersonExists;
        }
        public static int LocalDrivingLicenseApplicationStatus(int PersonID, int LicenseClassID)
        {
            int LocalApplicationStatus = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Applications.ApplicationStatus
            FROM            LocalDrivingLicenseApplications INNER JOIN
                                     Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
            WHERE LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID AND Applications.ApplicantPersonID = @ApplicantPersonID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    LocalApplicationStatus = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return LocalApplicationStatus;

        }
        public static int ApplicationID(int PersonID, int LicenseClassID)
        {
            int ApplicationID = 1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Applications.ApplicationID
                             FROM            Applications INNER JOIN
                                     LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE Applications.ApplicantPersonID = @ApplicantPersonID AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    ApplicationID = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return ApplicationID;
        }
        public static int GetPersonID(string NationalNo)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT PersonID
                             FROM          People
                             WHERE         NationalNo = '@NationalNo';";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    PersonID = Convert.ToInt32(Result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }
    }
}