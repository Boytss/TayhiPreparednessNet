using DISASTER_PREPAREDNESS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.Forms
{
    public partial class AdminEvacuationCenterForm : Form
    {
        public AdminEvacuationCenterForm()
        {
            InitializeComponent();
            PopulateDataGridView();
            PopulateCenterComboBox();
        }

        private void dataGridViewResidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void addRoomButton_Click(object sender, EventArgs e)
        {
            string roomName = roomNameTextBox.Text;
            int capacity = int.Parse(roomCapacityTextBox.Text); // Assuming roomCapacityTextBox contains the room capacity

            // Check if an item is selected in MyComboBox
            if (myComboBox1.SelectedItem != null)
            {
                DataRowView selectedCenter = (DataRowView)myComboBox1.SelectedItem;
                int centerId = Convert.ToInt32(selectedCenter["CenterID"]);

                // Insert room into the database
                Evacuation.InsertRoom(centerId, roomName, capacity);

                MessageBox.Show("Room added successfully!");
                PopulateDataGridView(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Please select an evacuation center.");
            }
        }
        private void PopulateDataGridView()
        {
        }
        private void PopulateCenterComboBox()
        {
            myComboBox1.DataSource = Evacuation.GetEvacuationCenters();
            myComboBox1.DisplayMember = "CenterName";
            myComboBox1.ValueMember = "CenterID";
        }

        private void uploadCenterButton_Click(object sender, EventArgs e)
        {
            string centerName = centerNameTextBox.Text;
            string location = centerLocationTextBox.Text;

            // Insert evacuation center into the database
            Evacuation.InsertEvacuationCenter(centerName, location);

            MessageBox.Show("Evacuation center uploaded successfully!");
            PopulateDataGridView(); // Refresh DataGridView
            PopulateCenterComboBox(); // Refresh center combobox
        }
    }
}
