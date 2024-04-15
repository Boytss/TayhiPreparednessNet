using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DISASTER_PREPAREDNESS.DataAccess;
using DISASTER_PREPAREDNESS.MyControls;

namespace DISASTER_PREPAREDNESS.Forms
{
    public partial class AdminEducationalVideosForm : Form
    {
        public AdminEducationalVideosForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string title = Title.Text;
            //    string videoLink = url.Text;

            //    VideoDataAccess.InsertVideo(title, videoLink);

            //    MessageBox.Show("Video upload successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error uploading Video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }
        private void LoadVideos()
        {
            dataGridViewResidents.ClearSelection();

            try
            {
                // Fetch resident data from the database
                DataTable videoDataTable = EducationalDataAccess.GetVideos();

                // Display the data in the DataGridView
                dataGridViewResidents.DataSource = videoDataTable;
                // Set column header text
                dataGridViewResidents.Columns["VideoID"].HeaderText = "Video Id";
                dataGridViewResidents.Columns["Title"].HeaderText = "Video Title";
                dataGridViewResidents.Columns["VideoURL"].HeaderText = "Video URL";
                dataGridViewResidents.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading residents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void AdminEducationalVideosForm_Load(object sender, EventArgs e)
        {
            LoadVideos();
        }

        private void AdminEducationalVideosForm_Resize(object sender, EventArgs e)
        {
            AdjustColumnSizes();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Edit Video Details";
            tabControl1.SelectedIndex = 1;

            // Check if the "Resident Details" tab is selected

            // Check if there is a selected row in the DataGridView
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = dataGridViewResidents.SelectedRows[0];
                string videoTitle = Convert.ToString(selectedRow.Cells["Title"].Value);
                string videoUrl = Convert.ToString(selectedRow.Cells["VIdeoURL"].Value);


                // Populate text boxes in the "Resident Details" tab with the retrieved data

                videoTitleTextBox.Text = videoTitle;
                videoUrlTextBox.Text = videoUrl;


            }
            else
            {
                // Clear text boxes if no row is selected
                videoTitleTextBox.Text = "";
                videoUrlTextBox.Text = "";

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values from your form controls
                string videoTitle = videoTitleTextBox.Text;
                string videoUrl = videoUrlTextBox.Text; // Retrieving image path from Button's Tag property

                if (string.IsNullOrEmpty(videoTitle) || string.IsNullOrEmpty(videoUrl))
                {
                    MessageBox.Show("Please provide a video title and video URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if a resident is selected in the DataGridView
                if (dataGridViewResidents.SelectedRows.Count > 0)
                {
                    // An existing resident is selected, so update their information
                    int videoID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["VideoID"].Value);
                    EducationalDataAccess.UpdateVideos(videoID, videoTitle, videoUrl);

                    // Optionally, provide feedback to the user about the success of the update operation
                    MessageBox.Show("Resident information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVideos();
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    // Insert the image path into the database
                    EducationalDataAccess.UploadVideos(videoTitle, videoUrl);

                    // Optionally, display a success message
                    MessageBox.Show("Image uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVideos();
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
            videoTitleTextBox.Text = "";
            videoUrlTextBox.Text = "";

        }

        private void buttonAddnew_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Add new video";

            dataGridViewResidents.ClearSelection();

            // Switch to the second tab
            tabControl1.SelectedIndex = 1;
            videoTitleTextBox.Text = "";
            videoUrlTextBox.Text = "";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Get the ID of the selected resident
                int videoID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["VideoID"].Value);

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Map?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Perform deletion
                        EducationalDataAccess.DeleteVideo(videoID);

                        // Refresh the DataGridView after deletion
                        LoadVideos(); // Assuming you have a method to reload data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting Video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Video to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }
    }
}
