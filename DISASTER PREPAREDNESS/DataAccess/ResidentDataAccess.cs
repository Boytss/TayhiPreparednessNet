using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public static class ResidentDataAccess
    {
        private static readonly string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";

        public static DataTable GetAllResidents()
        {
            DataTable residentsDataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT ID, FirstName, LastName, PurokNumber, MobileNumber, Username, Password FROM dbo.Resident";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(residentsDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception($"Error fetching residents data: {ex.Message}");
            }

            return residentsDataTable;
        }
        public static DataTable GetAllResidentContacts()
        {
            DataTable residentsContactDataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT FirstName, LastName, PurokNumber, MobileNumber FROM dbo.Resident";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(residentsContactDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception($"Error fetching residents data: {ex.Message}");
            }

            return residentsContactDataTable;
        }
        public static void SendSMSAlerts(DataGridViewSelectedRowCollection selectedRows, string message)
        {
            try
            {
                // Loop through selected rows and send SMS alerts
                foreach (DataGridViewRow row in selectedRows)
                {
                    string phoneNumber = row.Cells["MobileNumber"].Value.ToString();
                    // Call a method to send SMS using the phoneNumber and message
                    // Replace the following line with your SMS sending logic
                    Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
                }

                MessageBox.Show("SMS alerts sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending SMS alerts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable SearchResidents(string searchTerm)
        {
            DataTable searchResults = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Adjust the SQL query based on your database schema and search criteria
                    string searchQuery = "SELECT ID, FirstName, LastName,  MobileNumber, Username FROM dbo.Resident WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR Username LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(searchResults);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception($"Error searching residents data: {ex.Message}");
            }

            return searchResults;
        }
        public static DataTable SearchResidentsByPurok(string purok)
        {
            DataTable searchResults = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Adjust the SQL query based on your database schema and search criteria
                    string searchQuery = "SELECT ID, FirstName, LastName, PurokNumber, MobileNumber, Username, Password " +
                                         "FROM dbo.Resident " +
                                         "WHERE PurokNumber = @Purok";

                    using (SqlCommand command = new SqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Purok", purok);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(searchResults);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception($"Error searching residents by Purok: {ex.Message}");
            }

            return searchResults;
        }
        public static DataTable GetResidentById(int residentID)
        {
            DataTable residentDataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT ID, FirstName, LastName, PurokNumber, MobileNumber, Username, Password FROM dbo.Resident WHERE ID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(residentDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching resident data by ID: {ex.Message}");
            }

            return residentDataTable;
        }
        public static void UpdateResident(int residentID, string firstName, string lastName, string purokNumber, string mobileNumber, string username, string password)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE dbo.Resident SET FirstName = @FirstName, LastName = @LastName, PurokNumber = @PurokNumber, MobileNumber = @MobileNumber, Username = @Username, Password = @Password WHERE Id = @ResidentID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@PurokNumber", purokNumber);
                        command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception($"Error updating resident data: {ex.Message}");
            }
        }
        public static void AddResident(string firstName, string lastName, string purokNumber, string mobileNumber, string username, string password)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO dbo.Resident (FirstName, LastName, PurokNumber, MobileNumber, Username, Password) " +
                                        "VALUES (@FirstName, @LastName, @PurokNumber, @MobileNumber, @Username, @Password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@PurokNumber", purokNumber);
                        command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);


                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Resident added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No rows were affected. Check your input and try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding resident: {ex.Message}");
            }
        }
        public static void DeleteResident(int residentID)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM dbo.Resident WHERE ID = @ResidentID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception($"Error deleting resident: {ex.Message}");
            }
        }



    }
}
