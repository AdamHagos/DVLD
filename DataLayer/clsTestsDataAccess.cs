using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace DVLD_DataAccess
{
    public class clsTestsDataAccess
    {
        public static int AddNewTest(int TestAppointmentID, bool TestResult , string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO Tests(TestAppointmentID,TestResult,Notes,CreatedByUserID)
                              VALUES(@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);
                                                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes != "")
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
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
            return TestID;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE Tests
                             SET TestAppointmentID = @TestAppointmentID, TestResult = @TestResult, Notes = @Notes, CreatedByUserID = @CreatedByUserID
                             WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes != "")
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select * From Tests;";

            SqlCommand command = new SqlCommand(Query, connection);

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

        public static bool DeleteTest(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM Tests
                             WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestID", ID);

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

        public static bool GetTestByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsRecordFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM Tests
                             WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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
        public static int PassedTests(int LocalDrivingLicenseApplicationID)
        {
            int PassedTests = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT  Count(*)
                             FROM       Tests INNER JOIN
                             TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN
                             LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN
                             Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                             WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID  AND Tests.TestResult = 1;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    PassedTests = (int)Result;
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
            return PassedTests;
        }
        public static bool PassedTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool PassedTest = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT        Tests.TestResult
                             FROM            LocalDrivingLicenseApplications INNER JOIN
                             TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                             Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID INNER JOIN
                             TestTypes ON TestAppointments.TestTypeID = TestTypes.TestTypeID
                             WHERE         TestTypes.TestTypeID = @TestTypeID AND LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND Tests.TestResult = 1;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    PassedTest = Convert.ToBoolean(Result);
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
            return PassedTest;
        }
        public static int Trails(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int Trials = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string Query = @"SELECT   Count(*)
                             FROM            TestAppointments LEFT OUTER JOIN
                             Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE         Tests.TestAppointmentID IS NOT NULL AND TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    Trials = (int)Result;
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
            return Trials;
        }
    }
}
