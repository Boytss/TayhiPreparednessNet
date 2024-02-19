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
    public partial class AdminHelpfulTipsForm : Form
    {
        public AdminHelpfulTipsForm()
        {
            InitializeComponent();
            LoadDisaster();
        }
        private void LoadDisaster()
        {
            try
            {
                
                // Fetch hazard maps from the database
                DataTable disasterTable = DisasterDataAccess.GetDisasters();

                // Display hazard maps in the form
                foreach (DataRow row in disasterTable.Rows)
                {
                    string disasterName = row["DisasterName"].ToString();
                    string pictureLogo = row["PictureLogoPath"].ToString();

                    // Create a UserControl to display each hazard map
                    AdminForms.AdminHelpfulTipsControl HelpfulTips = new AdminForms.AdminHelpfulTipsControl(disasterName, pictureLogo);

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelDisasters.Controls.Add(HelpfulTips);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Disasters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
