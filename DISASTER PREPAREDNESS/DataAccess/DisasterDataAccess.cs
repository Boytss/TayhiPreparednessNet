using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public class DisasterDataAccess
    {
        private static string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;"; // Replace with your actual connection string

        public static DataTable GetDisasters()
        {
            DataTable Disaster = new DataTable();

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT DisasterName, PictureLogoPath FROM dbo.Disasters";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(Disaster);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching Disasters: {ex.Message}");
            }

            return Disaster;
        }
      
    }
}
