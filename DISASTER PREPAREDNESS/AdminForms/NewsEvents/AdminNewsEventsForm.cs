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
            LoadNewsEvents();
        }
        private void LoadNewsEvents()
        {
            try
            {

                // Fetch hazard maps from the database
                DataTable dataTable = NewsEventsHelper.GetNewsEvents();

                // Display hazard maps in the form
                foreach (DataRow row in dataTable.Rows)
                {
                    string titleName = row["Title"].ToString();
                    string date = row["Date"].ToString();
                    string imagePath = row["ImagePath"].ToString();

                    // Create a UserControl to display each hazard map
                    AdminForms.NewsEvents.NewsEventsDataControl NewsEvents = new AdminForms.NewsEvents.NewsEventsDataControl(titleName, date, imagePath);
                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelDisasters.Controls.Add(NewsEvents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading NewsEvents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
