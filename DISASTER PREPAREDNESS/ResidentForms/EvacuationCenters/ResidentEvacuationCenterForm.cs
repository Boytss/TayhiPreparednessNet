using DISASTER_PREPAREDNESS.DataAccess;
using DISASTER_PREPAREDNESS.ResidentForms.EvacuationCenters;
using DISASTER_PREPAREDNESS.ResidentForms.HelpfulTips;
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
    public partial class ResidentEvacuationCenterForm : Form
    {
        public ResidentEvacuationCenterForm()
        {
            InitializeComponent();
            LoadEvacuationCenters();
        }



        private void LoadEvacuationCenters()
        {
            try
            {
                // Fetch evacuation centers from the database
                DataTable evacuationCentersTable = Evacuation.GetEvacuationCenters();

                // Display evacuation centers in the form
                foreach (DataRow row in evacuationCentersTable.Rows)
                {
                    int evacuationCenterId = Convert.ToInt32(row["CenterID"]);
                    string evacuationCenterName = row["CenterName"].ToString();
                    string location = row["Location"].ToString();


                    // Create a UserControl to display each evacuation center
                    ResidentEvacuationControl evacuationControl = new ResidentEvacuationControl(evacuationCenterId, evacuationCenterName, location);

                    // Set the Tag property of the button to store the evacuation center ID
                    evacuationControl.ButtonEvacuation.Tag = evacuationCenterId;

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelEvacuation.Controls.Add(evacuationControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Evacuation Centers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



