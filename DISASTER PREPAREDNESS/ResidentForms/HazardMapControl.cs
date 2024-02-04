using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class AdminHazardMapControl : UserControl
    {
        
        public AdminHazardMapControl(string mapName, string description, string imagePath)
        {
            InitializeComponent();
            
            // Set the information for the hazard map
            labelDescription.Text = description;
            labelMapName.Text = mapName;


            // Set the image for the hazard map (assuming you have a PictureBox named pictureBoxMap)
            pictureBoxMap.Image = Image.FromFile(imagePath);
            SetRoundedCornersAndShadow(panel1, 15);
        }

       
        private void SetRoundedCornersAndShadow(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            panel.Region = new Region(path);

            // Add shadow
            Panel shadow = new Panel
            {
                Location = new Point(panel.Location.X + 5, panel.Location.Y + 5),
                Size = panel.Size,
                BackColor = Color.Gray,
                Parent = panel.Parent
            };

            shadow.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, shadow.ClientRectangle,
                    Color.Gray, 5, ButtonBorderStyle.Solid,
                    Color.Gray, 5, ButtonBorderStyle.Solid,
                    Color.Gray, 5, ButtonBorderStyle.Solid,
                    Color.Gray, 5, ButtonBorderStyle.Solid);
            };

            
        }
        private void labelMapName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            ShowEnlargedImage(pictureBoxMap.Image);
        }
        private void ShowEnlargedImage(Image image)
        {
            // Create a PictureBox to display the enlarged image
            PictureBox enlargedPictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };

            // Create and show the ZoomedImageForm
            ZoomedImageForm zoomedImageForm = new ZoomedImageForm(enlargedPictureBox.Image);
            zoomedImageForm.ShowDialog();
        }
        

     

        private void HazardMapControl_Load(object sender, EventArgs e)
        {

        }
    }

}
