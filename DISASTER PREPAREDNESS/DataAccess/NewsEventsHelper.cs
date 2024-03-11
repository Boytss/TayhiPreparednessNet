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
        public static DataTable GetNewsEventByTitle(string title)
        {
            DataTable eventData = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM dbo.NewsEvents WHERE Title = @Title";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(eventData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching news event by title: {ex.Message}");
            }

            return eventData;
        }
        public static void UploadNewsEvent(string title, string description, string imagePath, string author)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO dbo.NewsEvents (Title, Description, ImagePath, Date, [by]) VALUES (@Title, @Description, @ImagePath, GETDATE(), @Author)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@ImagePath", imagePath);
                        command.Parameters.AddWithValue("@Author", author);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No rows affected. Upload failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error uploading news event: {ex.Message}");
            }
        }

    }
}
