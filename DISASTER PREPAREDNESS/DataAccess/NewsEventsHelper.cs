using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public class NewsEventsHelper
    {
        private static string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;"; // Replace with your actual connection string

        public static DataTable GetNewsEvents()
        {
            DataTable NewsEvents = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT Date, Title, ImagePath FROM dbo.NewsEvents";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(NewsEvents);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching NewsEvents: {ex.Message}");
            }

            return NewsEvents;
        }
    }
}
