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
        public partial class ResidentNewsEventsForm : Form
        {
            public ResidentNewsEventsForm() 
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
                        ResidentForms.NewsEvents.ResidentNewsEventsDataControl NewsEvents = new ResidentForms.NewsEvents.ResidentNewsEventsDataControl(titleName, date, imagePath);
                        // Add the control to the FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(NewsEvents);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading NewsEvents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
