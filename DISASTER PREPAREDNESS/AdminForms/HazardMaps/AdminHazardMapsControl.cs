using DISASTER_PREPAREDNESS.ResidentForms;
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
            // Set the information for the hazard map
            labelHazardMaps.Text = mapName;


            // Set the image for the hazard map (assuming you have a PictureBox named pictureBoxMap)
            buttonHazardMaps.Image = Image.FromFile(imagePath);
        }



        private void SetRoundedCornersAndShadow(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 30; // You can adjust this value to control the roundness of the corners

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

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
                    Color.Gray, 3, ButtonBorderStyle.Solid,
                    Color.Gray, 3, ButtonBorderStyle.Solid,
                    Color.Gray, 3, ButtonBorderStyle.Solid,
                    Color.Gray, 3, ButtonBorderStyle.Solid);
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

            //AdminDashboard parentForm = FindAdminDashboardParentForm();

            //if (parentForm != null)
            //{
            //    // Access the panelDesktopPanel directly
            //    Panel panelDesktopPanel = parentForm.PanelDesktopPanel;

            //    if (panelDesktopPanel != null)
            //    {
            //        // Open the new form inside the panelDesktopPanel
            //        Form1 formToOpen = new Form1(); // Replace Form1 with the actual form you want to open
            //        formToOpen.TopLevel = false;
            //        formToOpen.FormBorderStyle = FormBorderStyle.None;
            //        formToOpen.Dock = DockStyle.Fill;
            //        panelDesktopPanel.Controls.Clear(); // Clear previous controls in the panelDesktopPanel
            //        panelDesktopPanel.Controls.Add(formToOpen);
            //        formToOpen.BringToFront();
            //        formToOpen.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("panelDesktopPanel not found.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Parent form not found.");
            //}
        }
        private AdminDashboard FindAdminDashboardParentForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AdminDashboard)
                {
                    return (AdminDashboard)form;
                }
            }

            return null;
        }
        private void AdminHazardMapsControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonHazardMaps_Click(object sender, EventArgs e)
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

