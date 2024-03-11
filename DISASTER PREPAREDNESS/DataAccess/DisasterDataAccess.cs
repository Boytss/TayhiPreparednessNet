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
        public static void UpdateTutorialText(string disasterName, string newText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE dbo.TutorialTexts SET TutorialText = @NewText WHERE DisasterID = (SELECT DisasterID FROM dbo.Disasters WHERE DisasterName = @DisasterName)";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewText", newText);
                        command.Parameters.AddWithValue("@DisasterName", disasterName);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No rows were affected. Disaster name might be invalid.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating tutorial text: {ex.Message}");
            }
        }
        public static DataTable GetEvacuationCenters()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CenterName FROM EvacuationCenters";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public static DataTable GetRoomsForEvacuationCenter(string evacuationCenterName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomName, Capacity FROM Rooms WHERE EvacuationCenterName = @EvacuationCenterName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EvacuationCenterName", evacuationCenterName);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

    }
}
