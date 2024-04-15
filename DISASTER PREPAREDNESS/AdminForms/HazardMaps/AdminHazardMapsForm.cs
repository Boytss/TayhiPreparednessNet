using DISASTER_PREPAREDNESS.AdminForms;
using DISASTER_PREPAREDNESS.DataAccess;
using DISASTER_PREPAREDNESS.ResidentForms;
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
    public partial class AdminHazardMapsForm : Form
    {
        public AdminHazardMapsForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }
        private void LoadHazardMaps()
        {
            dataGridViewResidents.ClearSelection();

            try
            {
                // Fetch resident data from the database
                DataTable hazardMapsDataTable = HazardMapDataAccess.GetHazardMaps();

                // Display the data in the DataGridView
                dataGridViewResidents.DataSource = hazardMapsDataTable;
                // Set column header text
                dataGridViewResidents.Columns["MapId"].HeaderText = "Map Id";
                dataGridViewResidents.Columns["MapName"].HeaderText = "Map Name";
                dataGridViewResidents.Columns["ImagePath"].HeaderText = "Image Path";
                dataGridViewResidents.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading residents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AdminHazardMapsForm_Load(object sender, EventArgs e)
        {
            LoadHazardMaps();
        }


        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values from your form controls
                string mapName = mapNameTextBox.Text;
                string mapImage = buttoChoose.Tag?.ToString(); // Retrieving image path from Button's Tag property

                if (string.IsNullOrEmpty(mapName) || string.IsNullOrEmpty(mapImage))
                {
                    MessageBox.Show("Please provide a map name and choose an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if a resident is selected in the DataGridView
                if (dataGridViewResidents.SelectedRows.Count > 0)
                {
                    // An existing resident is selected, so update their information
                    int mapID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["MapID"].Value);
                    HazardMapDataAccess.UpdateHazardMaps(mapID, mapName, mapImage);

                    // Optionally, provide feedback to the user about the success of the update operation
                    MessageBox.Show("Resident information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHazardMaps();
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    // Insert the image path into the database
                    HazardMapDataAccess.UploadHazardMap(mapName, mapImage);

                    // Optionally, display a success message
                    MessageBox.Show("Image uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHazardMaps();
                }

                // Optionally, clear the input fields after successful operation
                ClearInputFields();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the operation
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            // Clear input fields after successful operation
            mapNameTextBox.Text = "";
           
        }

        private void buttoChoose_Click_1(object sender, EventArgs e)
        {
            // Show the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"; // Filter for image files
            openFileDialog.Title = "Select Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string imagePath = openFileDialog.FileName;

                // Display the image in the PictureBox
                buttoChoose.BackgroundImage = Image.FromFile(imagePath);
                buttoChoose.BackgroundImageLayout = ImageLayout.Stretch;
                buttoChoose.Text = "";
                // Display the file path in the TextBox (optional)
                buttoChoose.Tag = imagePath;
            }
        }

        private void AdminHazardMapsForm_Resize(object sender, EventArgs e)
        {
            AdjustColumnSizes();

        }
        private void ConfigureDataGridView()
        {


            // Set AutoSizeMode for columns
            foreach (DataGridViewColumn column in dataGridViewResidents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridViewResidents.RowTemplate.Height = 40; // Adjust the value as needed


            // If binding to a data source, reload it
            // Example: dataGridViewResidents.DataSource = yourDataSource;

            // Adjust column sizes initially
            AdjustColumnSizes();
        }
        private void AdjustColumnSizes()
        {
            // Manually adjust column sizes based on form size
            foreach (DataGridViewColumn column in dataGridViewResidents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Edit Map Details";
            tabControl1.SelectedIndex = 1;

            // Check if the "Resident Details" tab is selected

            // Check if there is a selected row in the DataGridView
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = dataGridViewResidents.SelectedRows[0];
                string mapImage = Convert.ToString(selectedRow.Cells["ImagePath"].Value);
                string mapName = Convert.ToString(selectedRow.Cells["MapName"].Value);


                // Populate text boxes in the "Resident Details" tab with the retrieved data

                mapNameTextBox.Text = mapName;
                // Display the image in the PictureBox
                buttoChoose.BackgroundImage = Image.FromFile(mapImage);
                buttoChoose.BackgroundImageLayout = ImageLayout.Stretch;
                buttoChoose.Text = "";
                // Display the file path in the TextBox (optional)
                buttoChoose.Tag = mapImage;


            }
            else
            {
                // Clear text boxes if no row is selected
                buttoChoose.Text = "";
                mapNameTextBox.Text = "";

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }

        private void buttonAddnew_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Add new Map";

            dataGridViewResidents.ClearSelection();

            // Switch to the second tab
            tabControl1.SelectedIndex = 1;
            mapNameTextBox.Text = "";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Get the ID of the selected resident
                int mapID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["MapID"].Value);

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Map?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Perform deletion
                        HazardMapDataAccess.DeleteMap(mapID);

                        // Refresh the DataGridView after deletion
                        LoadHazardMaps(); // Assuming you have a method to reload data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting Map: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Map to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

