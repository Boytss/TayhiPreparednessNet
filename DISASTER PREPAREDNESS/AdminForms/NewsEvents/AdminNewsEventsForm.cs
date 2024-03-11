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
using DISASTER_PREPAREDNESS.AdminForms;
using DISASTER_PREPAREDNESS.DataAccess;

namespace DISASTER_PREPAREDNESS.Forms
{
    public partial class AdminNewsEventsForm : Form
    {
        public AdminNewsEventsForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonImage_Click(object sender, EventArgs e)
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
                buttonImage.BackgroundImage = Image.FromFile(imagePath);
                buttonImage.BackgroundImageLayout = ImageLayout.Stretch;
                buttonImage.Text = "";
                // Display the file path in the TextBox (optional)
                buttonImage.Tag = imagePath;
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleName.Text;
                string description = descriptionName.Text;
                string imagePath = buttonImage.Tag.ToString();
                string author = authorName.Text;

                // Insert the image path into the database
                NewsEventsHelper.UploadNewsEvent(title, description, imagePath, author);

                // Optionally, display a success message
                MessageBox.Show("Upload successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void descriptionName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
