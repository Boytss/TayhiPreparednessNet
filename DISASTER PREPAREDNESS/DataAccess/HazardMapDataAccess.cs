using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public static class HazardMapDataAccess
    {
        private static readonly string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";

        public static void UploadHazardMap(string mapName,  string imagePath)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO dbo.HazardMaps (MapName, ImagePath) VALUES (@MapName, @ImagePath)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MapName", mapName);
                        command.Parameters.AddWithValue("@ImagePath", imagePath);


                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error uploading hazard map: {ex.Message}");
            }

        }
        public static DataTable GetHazardMaps()
        {
            DataTable hazardMapsDataTable = new DataTable();

            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT MapID, MapName, Description, ImagePath FROM dbo.HazardMaps";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(hazardMapsDataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching hazard maps: {ex.Message}");
            }

            return hazardMapsDataTable;
        }
        public static void DeleteMap(int mapID)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM dbo.HazardMaps WHERE MapID = @MapID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MapID", mapID);

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
        public static void UpdateHazardMaps(int mapID, string mapName, string mapImage)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE dbo.HazardMaps SET MapName = @MapName, ImagePath = @ImagePath  WHERE MapID = @MapID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MapID", mapID);
                        command.Parameters.AddWithValue("@MapName", mapName);
                        command.Parameters.AddWithValue("@ImagePath", mapImage);
                       

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
        public static void DeleteHazardMap(string mapName)
        {
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM HazardMaps WHERE MapName = @MapName", connection))
                    {
                        command.Parameters.AddWithValue("@MapName", mapName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (logging, displaying error to the user, etc.)
                throw new Exception($"Error deleting hazard map: {ex.Message}");
            }
        }
    }
}
