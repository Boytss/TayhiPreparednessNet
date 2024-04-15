using DISASTER_PREPAREDNESS.DataAccess;
using DISASTER_PREPAREDNESS.MyControls;
using DISASTER_PREPAREDNESS.ResidentForms.Hazard_Maps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class ResidentHazardMapsForm : Form
    {
        public ResidentHazardMapsForm()
        {
            InitializeComponent();
            LoadHazardMaps();
        }
        private void LoadHazardMaps()
        {
            try
            {
                VideoDataAccess videoDataAccess = new VideoDataAccess();
                // Fetch hazard maps from the database
                DataTable hazardMapsDataTable = HazardMapDataAccess.GetHazardMaps();

                // Display hazard maps in the form
                foreach (DataRow row in hazardMapsDataTable.Rows)
                {
                    string mapName = row["MapName"].ToString();
                    string description = row["Description"].ToString();
                    string imagePath = row["ImagePath"].ToString();

                    // Create a UserControl to display each hazard map
                    AdminHazardMapControl hazardMapControl = new AdminHazardMapControl(mapName, description, imagePath);

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(hazardMapControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading hazard maps: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            ResidentDashboard parentForm = FindResidentDashboardParentForm();

            if (parentForm != null)
            {
                // Access the panelDesktopPanel directly
                Panel panelDesktopPanel = parentForm.PanelDesktopPanels;

                if (panelDesktopPanel != null)
                {

                    WindyForm windy = new WindyForm(); // Replace Form1 with the actual form you want to open
                    windy.TopLevel = false;
                    windy.FormBorderStyle = FormBorderStyle.None;
                    windy.Dock = DockStyle.Fill;
                    panelDesktopPanel.Controls.Clear(); // Clear previous controls in the panelDesktopPanel
                    panelDesktopPanel.Controls.Add(windy);
                    windy.BringToFront();
                    windy.Show();
                }
                else
                {
                    MessageBox.Show("panelDesktopPanel not found.");
                }
            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }
        }
        private ResidentDashboard FindResidentDashboardParentForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ResidentDashboard)
                {
                    return (ResidentDashboard)form;
                }
            }

            return null;
        }
    }
}
