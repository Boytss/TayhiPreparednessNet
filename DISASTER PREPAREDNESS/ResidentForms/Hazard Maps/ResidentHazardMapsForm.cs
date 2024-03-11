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
                    flowLayoutPanelHazardMaps.Controls.Add(hazardMapControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading hazard maps: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
