using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public class Evacuation
    {
        // Connection string to your database
        private static string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;"; // Replace with your actual connection string

        // Method to insert evacuation center into the database
        public static void InsertEvacuationCenter(string centerName, string location)
        {
            string query = "INSERT INTO EvacuationCenters (CenterName, Location) VALUES (@CenterName, @Location)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CenterName", centerName);
                command.Parameters.AddWithValue("@Location", location);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to insert room into the database
        public static void InsertRoom(int centerId, string roomName, int capacity)
        {
            string query = "INSERT INTO Rooms (CenterID, RoomNumber, Capacity) VALUES (@CenterID, @RoomNumber, @Capacity)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CenterID", centerId);
                command.Parameters.AddWithValue("@RoomNumber", roomName);
                command.Parameters.AddWithValue("@Capacity", capacity);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Method to fetch existing evacuation centers from the database
        public static DataTable GetEvacuationCenters()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CenterID, CenterName, Location FROM EvacuationCenters";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public static DataTable GetRoomsForEvacuationCenter(int centerId)
        {
            DataTable rooms = new DataTable();

            // Assuming you have a method to fetch rooms from the database
            // You would replace this with your actual database query
            // Example: "SELECT * FROM Rooms WHERE CenterID = @CenterID"
            string query = "SELECT * FROM Rooms WHERE CenterID = @CenterID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CenterID", centerId);

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(rooms);
            }

            return rooms;
        }
    }
}
