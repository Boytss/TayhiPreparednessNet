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
            LoadHazardMaps();
        }

        private void LoadHazardMaps()
        {
            try
            {
                // Fetch hazard maps from the database
                DataTable hazardMapsDataTable = HazardMapDataAccess.GetHazardMaps();

                // Display hazard maps in the form
                foreach (DataRow row in hazardMapsDataTable.Rows)
                {
                    string mapName = row["MapName"].ToString();
                    string description = row["Description"].ToString();
                    string imagePath = row["ImagePath"].ToString();

                    // Create a UserControl to display each hazard map
                    AdminHazardMapsControl hazardMapControl = new AdminHazardMapsControl(mapName, description, imagePath);

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelHazardMaps.Controls.Add(hazardMapControl);

                    // Attach a delete event to the hazard map control
                    hazardMapControl.DeleteClicked += HazardMapControl_DeleteClicked;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading hazard maps: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HazardMapControl_DeleteClicked(object sender, EventArgs e)
        {
            // Get the control that triggered the delete event
            AdminHazardMapsControl deletedControl = sender as AdminHazardMapsControl;

            // Delete the hazard map from the database
            HazardMapDataAccess.DeleteHazardMap(deletedControl.MapName);

            // Remove the control from the FlowLayoutPanel
            flowLayoutPanelHazardMaps.Controls.Remove(deletedControl);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Open file dialog to select hazard map file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp",
                Title = "Select Hazard Map"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected file path
                textBoxFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from the form
                string mapName = textMapName.Text;
                string description = textDescription.Text;

                // Validate if a file is selected
                if (string.IsNullOrEmpty(textBoxFilePath.Text))
                {
                    MessageBox.Show("Please select a hazard map file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the file path
                string imagePath = textBoxFilePath.Text;

                // Save the hazard map information to the database
                HazardMapDataAccess.UploadHazardMap(mapName, description, imagePath);

                MessageBox.Show("Hazard map uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flowLayoutPanelHazardMaps.Controls.Clear();
                LoadHazardMaps();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading hazard map: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Trigger the delete event when the delete button is clicked
            if (flowLayoutPanelHazardMaps.Controls.Count > 0)
            {
                AdminHazardMapsControl selectedControl = flowLayoutPanelHazardMaps.Controls[flowLayoutPanelHazardMaps.Controls.Count - 1] as AdminHazardMapsControl;
                HazardMapControl_DeleteClicked(selectedControl, EventArgs.Empty);
            }
        }
    }
}

