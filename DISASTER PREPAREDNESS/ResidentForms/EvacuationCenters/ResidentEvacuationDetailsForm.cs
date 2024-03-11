using DISASTER_PREPAREDNESS.DataAccess;
using DISASTER_PREPAREDNESS.ResidentForms.HelpfulTips;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.ResidentForms.EvacuationCenters
{
    public partial class ResidentEvacuationDetailsForm : Form
    {
        private static string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";

        public ResidentEvacuationDetailsForm(int evacuationCenterId, string evacuationCenterName)
        {
            InitializeComponent();
            LoadEvacuationRooms(evacuationCenterId);
        }

        private int GetCenterId(string evacuationCenterName)
        {

            try
            {
                // Query to retrieve centerId based on evacuation center name
                string query = "SELECT CenterID FROM EvacuationCenters WHERE CenterName = @EvacuationCenterName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EvacuationCenterName", evacuationCenterName);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving centerId: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0; // Default value if centerId retrieval fails
        }
        private void LoadEvacuationRooms(int centerId)
        {
            try
            {
                // Fetch rooms for the selected evacuation center from the database
                DataTable roomsTable = Evacuation.GetRoomsForEvacuationCenter(centerId);

                // Display rooms in the form
                foreach (DataRow row in roomsTable.Rows)
                {
                    string roomName = row["RoomNumber"].ToString();
                    int capacity = Convert.ToInt32(row["Capacity"]);

                    // Create a UserControl to display each room
                    ResidentEvacuationRoomControl roomControl = new ResidentEvacuationRoomControl(roomName, capacity);

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelEvacuation.Controls.Add(roomControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Evacuation Rooms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
