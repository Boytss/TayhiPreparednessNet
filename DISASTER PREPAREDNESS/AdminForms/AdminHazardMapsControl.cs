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


namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class AdminHazardMapsControl : UserControl
    {
        public event EventHandler DeleteClicked;
        public string MapName { get; private set; }
        public AdminHazardMapsControl(string mapName, string description, string imagePath)
        {
            InitializeComponent();
            MapName = mapName;
            // Set the information for the hazard map
            labelDescription.Text = description;
            labelMapName.Text = mapName;


            // Set the image for the hazard map (assuming you have a PictureBox named pictureBoxMap)
            pictureBoxMap.Image = Image.FromFile(imagePath);
            SetRoundedCornersAndShadow(panel1, 15);
            // Attach a click event to handle deletion when the picture is clicked
            pictureBoxMap.Click += pictureBoxMap_Click_1;
        }

        private void SetRoundedPanel(Panel panel, int radius)
        {
            GraphicsPath panelPath = new GraphicsPath();
            panelPath.AddArc(0, 0, radius, radius, 180, 90);
            panelPath.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            panelPath.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            panelPath.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            panel.Region = new Region(panelPath);
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

        

       

        private void HazardMapControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMap_Click_1(object sender, EventArgs e)
        {

   
        }

        private void AdminHazardMapsControl_Load(object sender, EventArgs e)
        {
                
        }
    }
}

