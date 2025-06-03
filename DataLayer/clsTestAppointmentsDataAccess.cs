using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentsDataAccess
    {
        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID)
                              VALUES(@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID);
                                                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID != -1)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
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
            return TestAppointmentID;
        }

        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE TestAppointments
                             SET TestTypeID = @TestTypeID, LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, AppointmentDate = @AppointmentDate, PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID, IsLocked = @IsLocked, RetakeTestApplicationID = @RetakeTestApplicationID
                             WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID != -1)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
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

        public static DataTable GetTestAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT  TestAppointmentID, AppointmentDate, PaidFees, IsLocked
                             FROM  TestAppointments 
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static bool DeleteTestAppointment(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM TestAppointments
                             WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", ID);

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

        public static bool GetTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool IsRecordFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM TestAppointments
                             WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (float)(decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
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
        public static bool IsTestScheduledNotTakenYet(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsTestScheduledNotTakenYet = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT        ISTestScheduledNotTakenYet = 1
                             FROM            TestAppointments LEFT OUTER JOIN
                             Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE         TestAppointments.TestTypeID = @TestTypeID AND TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND Tests.TestResult IS NULL;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    IsTestScheduledNotTakenYet = true;
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
            return IsTestScheduledNotTakenYet;
        }
        public static bool CheckIfTestAppointmentTaken(int TestAppointmentID)
        {
            bool IsTestAppointmentTaken = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT     Tests.TestResult   
                             FROM            TestAppointments LEFT OUTER JOIN
                             Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE         TestAppointments.TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result == DBNull.Value)
                {
                    IsTestAppointmentTaken = Convert.ToBoolean(Result);
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
            return IsTestAppointmentTaken;
        }
        public static bool IsTestAppointmentPassed(int TestAppointmentID)
        {
            bool IsTestAppointmentPassed = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT Tests.TestResult
                             FROM            Tests INNER JOIN
                             TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             WHERE         TestAppointments.TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && Result == DBNull.Value)
                {
                    IsTestAppointmentPassed = Convert.ToBoolean(Result);
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
            return IsTestAppointmentPassed;
        }
    }
}

