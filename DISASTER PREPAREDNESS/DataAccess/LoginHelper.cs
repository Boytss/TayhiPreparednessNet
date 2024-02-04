    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DISASTER_PREPAREDNESS.DataAccess
    {
        class LoginHelper
        {
            public static bool AuthenticateUser(string username, string password)
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT COUNT(*) FROM dbo.Resident WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
        }
    }
