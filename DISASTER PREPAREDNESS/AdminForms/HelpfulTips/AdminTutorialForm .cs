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

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class TutorialForm : Form
    {
        private static readonly string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";

        public TutorialForm(string disasterName)
        {
            InitializeComponent();
            labelTips.Text = disasterName;

            // Query database to retrieve tutorial information based on disaster name

            LoadTutorialText(disasterName);

        }
        private void LoadTutorialText(string disasterName)
        {
            try
            {
                // Retrieve tutorial text based on the selected disaster name
                string tutorialText = RetrieveTutorialText(disasterName);
                AdminTutorialControl tutorial = new AdminTutorialControl(tutorialText, disasterName);

                // Set the tutorial text in the tutorialControl
                tutorial.SetTutorialText(tutorialText);

                // Add the control to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(tutorial);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tutorial text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string RetrieveTutorialText(string disasterName)
        {
            try
            {
                string tutorialText = string.Empty;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT TutorialText FROM dbo.TutorialTexts WHERE DisasterID = (SELECT DisasterID FROM dbo.Disasters WHERE DisasterName = @DisasterName)";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DisasterName", disasterName);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            tutorialText = result.ToString();
                        }
                    }
                }

                return tutorialText;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving tutorial text: {ex.Message}");
            }
        }

    }
}
