using DISASTER_PREPAREDNESS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.ResidentForms.NewsEvents
{

    public partial class ResidentNewsEventsDiscriptionForm : Form
    {
        private string titleName; // Store the titleName

        public ResidentNewsEventsDiscriptionForm(string titleName)
        {

            InitializeComponent();
            this.titleName = titleName;
            LoadEventData();
        }
        private void LoadEventData()
        {
            try
            {
                // Fetch event data from the database based on titleName
                DataTable eventData = NewsEventsHelper.GetNewsEventByTitle(titleName);

                // Populate your form controls with the fetched data
                if (eventData != null && eventData.Rows.Count > 0)
                {
                    DataRow row = eventData.Rows[0]; // Assuming only one row is returned

                    // Populate your form controls with the data
                    labelTitle.Text = row["Title"].ToString();
                    labelDate.Text = row["Date"].ToString();
                    labelDescription.Text = row["Description"].ToString();
                    labelBy.Text = row["by"].ToString();

                    // Load image if necessary
                    string imagePath = row["ImagePath"].ToString();
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        buttonImage.Image = Image.FromFile(imagePath);
                        buttonImage.BackgroundImageLayout = ImageLayout.Stretch;

                    }
                }
                else
                {
                    MessageBox.Show("Event data not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading event data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
