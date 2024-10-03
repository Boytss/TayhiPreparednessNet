using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public class AffectedDataAccess
    {
        private static readonly string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";

        public static bool SaveAffectedData(string lastName, string firstName, string middleName, int age, string gender, string headOfFamily, string condition, string purokNumber, string houseNumber, string severityLevel)
        {
            try
            {
                // Retrieve the latest or currently active disaster name from the database
                string disasterName = EvacueeDataAccess.GetLatestDisasterName(); // Implement this method to retrieve the disaster name

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO dbo.Affected (LastName, FirstName, MiddleName, Age, Gender, HeadOfFamily, Condition, PurokNumber, HouseNumber, SeverityLevel, DisasterName) " +
                                   "VALUES (@LastName, @FirstName, @MiddleName, @Age, @Gender, @HeadOfFamily, @Condition, @PurokNumber, @HouseNumber, @SeverityLevel, @DisasterName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@HeadOfFamily", headOfFamily);
                        command.Parameters.AddWithValue("@Condition", condition);
                        command.Parameters.AddWithValue("@PurokNumber", purokNumber);
                        command.Parameters.AddWithValue("@HouseNumber", houseNumber);
                        command.Parameters.AddWithValue("@SeverityLevel", severityLevel);
                        command.Parameters.AddWithValue("@DisasterName", disasterName);

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
        public static Dictionary<string, int> RetrieveAffectedByPersonFromDatabase()
        {
            Dictionary<string, int> evacueesPerPurok = new Dictionary<string, int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Condition, COUNT(*) AS PersonCount FROM dbo.Affected GROUP BY Condition";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string purokNumber = reader["Condition"].ToString();
                                int personCount = Convert.ToInt32(reader["PersonCount"]);

                                evacueesPerPurok.Add(purokNumber, personCount);
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
        public static Dictionary<string, int> RetrieveAffectedPersonByDisasterFromDatabase(string selectedDisaster)
        {
            Dictionary<string, int> affectedByPerson = new Dictionary<string, int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Condition, COUNT(*) AS PersonCount FROM dbo.Affected WHERE DisasterName = @DisasterName GROUP BY Condition";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DisasterName", selectedDisaster);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string condition = reader["Condition"].ToString();
                                int personCount = reader.GetInt32(reader.GetOrdinal("PersonCount"));
                                affectedByPerson.Add(condition, personCount);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL-related exceptions
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error: " + ex.Message);
            }

            return affectedByPerson;
        }
        public static Dictionary<string, int> RetrieveAffectedHouseByDisasterFromDatabase(string selectedDisaster)
        {
            Dictionary<string, int> affectedByHouse = new Dictionary<string, int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SeverityLevel, COUNT(*) AS SeverityCount FROM dbo.Affected WHERE DisasterName = @DisasterName GROUP BY SeverityLevel";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DisasterName", selectedDisaster);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string condition = reader["SeverityLevel"].ToString();
                                int personCount = reader.GetInt32(reader.GetOrdinal("SeverityCount"));
                                affectedByHouse.Add(condition, personCount);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL-related exceptions
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("Error: " + ex.Message);
            }

            return affectedByHouse;
        }
        public static List<PersonByCondition> RetrievePersonByCondition(string disasterName)
        {
            List<PersonByCondition> personByConditions = new List<PersonByCondition>();

            try
            {
                string query = "SELECT * FROM dbo.Affected WHERE DisasterName = @DisasterName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DisasterName", disasterName);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        PersonByCondition personByCondition = new PersonByCondition();
                        personByCondition.FirstName = reader["FirstName"].ToString();
                        personByCondition.MiddleName = reader["MiddleName"].ToString();
                        personByCondition.LastName = reader["LastName"].ToString();
                        personByCondition.Age = Convert.ToInt32(reader["Age"]);
                        personByCondition.Gender = reader["Gender"].ToString();
                        personByCondition.HeadOfFamily = reader["HeadOfFamily"].ToString();
                        personByCondition.Condition = reader["Condition"].ToString();
                        personByCondition.PurokNumber = reader["PurokNumber"].ToString();
                        personByCondition.DisasterName = reader["DisasterName"].ToString();

                        personByConditions.Add(personByCondition);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return personByConditions;
        }
        public static List<ConditionByHouse> RetrieveAffectedByHouse(string disasterName)
        {
            List<ConditionByHouse> affectedByHouses = new List<ConditionByHouse>();

            try
            {
                string query = "SELECT * FROM dbo.Affected WHERE DisasterName = @DisasterName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DisasterName", disasterName);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ConditionByHouse affectedByHouse = new ConditionByHouse();
                        affectedByHouse.FirstName = reader["FirstName"].ToString();
                        affectedByHouse.MiddleName = reader["MiddleName"].ToString();
                        affectedByHouse.LastName = reader["LastName"].ToString();
                        affectedByHouse.Age = Convert.ToInt32(reader["Age"]);
                        affectedByHouse.Gender = reader["Gender"].ToString();
                        affectedByHouse.HeadOfFamily = reader["HeadOfFamily"].ToString();
                        affectedByHouse.PurokNumber = reader["PurokNumber"].ToString();
                        affectedByHouse.HouseNumber = reader["HouseNumber"].ToString();
                        affectedByHouse.SeverityLevel = reader["SeverityLevel"].ToString();
                        affectedByHouse.DisasterName = reader["DisasterName"].ToString();

                        affectedByHouses.Add(affectedByHouse);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return affectedByHouses;
        }
    }
}
