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
        }

        private void buttoChoose_Click(object sender, EventArgs e)
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

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the map name and description from your form controls
                string mapName = buttonMapName.Text; // Assuming you have a TextBox control for map name

                // Get the image path from the Button's Tag property (assuming you stored the path there)
                string imagePath = buttoChoose.Tag.ToString();

                // Insert the image path into the database
                HazardMapDataAccess.UploadHazardMap(mapName, imagePath);

                // Optionally, display a success message
                MessageBox.Show("Image uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

