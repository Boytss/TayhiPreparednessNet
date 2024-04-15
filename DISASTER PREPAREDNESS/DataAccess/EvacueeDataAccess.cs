using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public class EvacueeDataAccess
    {
        private static readonly string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";
        public static Dictionary<string, int> RetrieveEvacueesPerPurokFromDatabase()
        {
            Dictionary<string, int> evacueesPerPurok = new Dictionary<string, int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PurokNumber, COUNT(*) AS EvacueeCount FROM dbo.Evacuees GROUP BY PurokNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string purokNumber = reader["PurokNumber"].ToString();
                                int evacueeCount = Convert.ToInt32(reader["EvacueeCount"]);

                                evacueesPerPurok.Add(purokNumber, evacueeCount);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log error, display message)
                Console.WriteLine("Error retrieving evacuees per purok: " + ex.Message);
            }

            return evacueesPerPurok;
        }
        public static bool SaveEvacueeData(string lastName, string firstName, string middleName, int age, string gender, string purokNumber, int numOfFamily, string roomName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Evacuees (LastName, FirstName, MiddleName, Age, Gender, PurokNumber, NumberOfFamilyMembers, RoomName) " +
                                   "VALUES (@LastName, @FirstName, @MiddleName, @Age, @Gender, @PurokNumber, @NumberOfFamilyMembers, @RoomName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@PurokNumber", purokNumber);
                        command.Parameters.AddWithValue("@NumberOfFamilyMembers", numOfFamily);
                        command.Parameters.AddWithValue("@RoomName", roomName);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }
    }
}
