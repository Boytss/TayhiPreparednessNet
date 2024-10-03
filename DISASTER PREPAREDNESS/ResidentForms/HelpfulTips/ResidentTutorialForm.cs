﻿using DISASTER_PREPAREDNESS.AdminForms;
using DISASTER_PREPAREDNESS.ResidentForms.NewsEvents;
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

namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class ResidentTutorialForm : Form
    {
        private static readonly string connectionString = "Server=DESKTOP-7INE4EE\\SQLEXPRESS02;Database=DisasterPreparedness;Trusted_Connection=True;";

        public ResidentTutorialForm(string disasterName)
        {
            InitializeComponent();
            labelTips.Text = disasterName;
            LoadTutorialText(disasterName);
        }
        private void LoadTutorialText(string disasterName)
        {
            try
            {
                // Retrieve tutorial text based on the selected disaster name
                string tutorialText = RetrieveTutorialText(disasterName);
                ResidentTutorialControl tutorial = new ResidentTutorialControl();

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

        private void labelTips_Click(object sender, EventArgs e)
        {

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

        private void backButton_Click(object sender, EventArgs e)
        {
            ResidentDashboard parentForm = FindResidentDashboardParentForm();

            if (parentForm != null)
            {
                // Access the panelDesktopPanel directly
                Panel panelDesktopPanel = parentForm.PanelDesktopPanels;

                if (panelDesktopPanel != null)
                {
                    ResidentHelpfulTipsForm helpfulTipsForm = new ResidentHelpfulTipsForm(); // Replace Form1 with the actual form you want to open
                    helpfulTipsForm.TopLevel = false;
                    helpfulTipsForm.FormBorderStyle = FormBorderStyle.None;
                    helpfulTipsForm.Dock = DockStyle.Fill;
                    panelDesktopPanel.Controls.Clear(); // Clear previous controls in the panelDesktopPanel
                    panelDesktopPanel.Controls.Add(helpfulTipsForm);
                    helpfulTipsForm.BringToFront();
                    helpfulTipsForm.Show();
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
    }
}