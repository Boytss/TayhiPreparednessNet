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





        private void PopulateDataGridView()
        {
        }
        private void PopulateCenterComboBox()
        {
            myComboBox1.DataSource = Evacuation.GetEvacuationCenters();
            myComboBox1.DisplayMember = "CenterName";
            myComboBox1.ValueMember = "CenterID";
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void myTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            // Retrieve data from input fields
            string lastName = lastNameText.Text;
            string firstName = firstNameText.Text;
            string middleName = middleNameText.Text;
            int age = int.Parse(ageText.Text);
            string gender = genderDrop.Texts;
            string purokNumber = purokDrop.Texts;
            int numOfFamily = int.Parse(numberFamilyText.Text);
            string roomName = roomNameTextBox.Text;

            // Save evacuee data
            bool success = EvacueeDataAccess.SaveEvacueeData(lastName, firstName, middleName, age, gender, purokNumber, numOfFamily, roomName);

            if (success)
            {
                MessageBox.Show("Data saved successfully!");
            }
            else
            {
                MessageBox.Show("Failed to save data.");
            }
        }
    }
}
