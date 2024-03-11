using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class AdminHazardMapControl : UserControl
    {
        private Image hazardMapImage;
        public AdminHazardMapControl(string mapName, string description, string imagePath)
        {
            InitializeComponent();

            // Set the information for the hazard map
            labelHazardMaps.Text = mapName;


            // Set the image for the hazard map (assuming you have a PictureBox named pictureBoxMap)
            buttonHazardMaps.Image = Image.FromFile(imagePath);
            buttonHazardMaps.BackgroundImageLayout = ImageLayout.Center;
        }



        private void HazardMapControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonHazardMaps_Click(object sender, EventArgs e)
        {

        }

        private void buttonHazardMaps_Click_1(object sender, EventArgs e)
        {
        }

        private void buttonHazardMaps_Click_2(object sender, EventArgs e)
        {

            // Check if the button's Image property is not null
            if (buttonHazardMaps.Image != null)
            {
                // Create a new instance of ZoomedImageForm with the button's Image
                ZoomedImageForm zoomForm = new ZoomedImageForm(buttonHazardMaps.Image);
                zoomForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No image available to zoom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
