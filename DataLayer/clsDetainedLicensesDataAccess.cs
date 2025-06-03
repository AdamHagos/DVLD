using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDetainedLicensesDataAccess
    {
        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO DetainedLicenses(LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID)
                              VALUES(@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,@IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID);
                                                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate.Year != 1900)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            if (ReleasedByUserID != -1)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            if (ReleaseApplicationID != -1)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
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
            return DetainID;
        }

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"UPDATE DetainedLicenses
                             SET LicenseID = @LicenseID, DetainDate = @DetainDate, FineFees = @FineFees, CreatedByUserID = @CreatedByUserID, IsReleased = @IsReleased, ReleaseDate =@ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate.Year != 1900)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }
            if (ReleasedByUserID != -1)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }
            if (ReleaseApplicationID != -1)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
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

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select * From DetainedLicenses;";

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

        public static bool DeleteDetainedLicense(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"DELETE FROM DetainedLicenses
                             WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", ID);

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

        public static bool GetDetainedLicenseByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsRecordFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses
                             WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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
        public static bool GetDetainedLicenseByLicenseID(ref int DetainID, int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsRecordFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT * FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID AND IsReleased = 0;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (float)(decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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
        public static bool IsDetained(int LicenseID)
        {
            bool IsDetained = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"SELECT IsReleased
                             FROM DetainedLicenses
                             WHERE IsReleased = 0 AND LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    IsDetained = !(bool)Result;
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
            return IsDetained;
        }
    }
}
