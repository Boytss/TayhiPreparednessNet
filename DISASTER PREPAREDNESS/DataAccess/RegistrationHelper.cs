using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    class RegistrationHelper
    {
        public static bool RegisterUser(string firstName, string lastName, string purokNumber, string mobileNumber, string username, string password)
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

                        command.ExecuteNonQuery();
                    }
                }

                // Return true if registration is successful
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                MessageBox.Show($"Registration failed. Error: {ex.Message}");
                return false; // Return false if registration fails
            }

        }


    }
}
