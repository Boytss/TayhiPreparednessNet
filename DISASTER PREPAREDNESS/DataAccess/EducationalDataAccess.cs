using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public static class EducationalDataAccess
    {
        private static readonly string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";

        public static DataTable GetVideos()
        {
            DataTable videosDataTable = new DataTable();

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT VideoID, Title, VideoURL FROM dbo.EducationalVideos";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(videosDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching hazard maps: {ex.Message}");
            }

            return videosDataTable;
        }
        public static void UploadVideos(string videoTitle, string videoUrl)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO dbo.EducationalVideos (Title, VideoURL) VALUES (@Title, @VideoURL)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Title", videoTitle);
                        command.Parameters.AddWithValue("@VideoURL", videoTitle);


                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error uploading Video: {ex.Message}");
            }

        }
        public static void UpdateVideos(int videoID, string videoTitle, string videoUrl)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE dbo.EducationalVideos SET Title = @Title, VideoURL= @VideoURL  WHERE VideoID= @VideoID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@VideoID", videoID);
                        command.Parameters.AddWithValue("@Title", videoTitle);
                        command.Parameters.AddWithValue("@VideoURL", videoUrl);


                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception($"Error updating video data: {ex.Message}");
            }
        }
        public static void DeleteVideo(int videoID)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM dbo.EducationalVideos WHERE VideoID = @VideoID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@VideoID", videoID);

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
