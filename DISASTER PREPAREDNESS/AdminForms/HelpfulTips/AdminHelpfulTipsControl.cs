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
    public partial class AdminHelpfulTipsControl : UserControl
    {

        public AdminHelpfulTipsControl(string DisasterName, String PictureLogoPath)
        {
            InitializeComponent();
            // Set the information for the hazard map
            labelDisasters.Text = DisasterName;

            buttonPicture.BackgroundImage = Image.FromFile(PictureLogoPath);
            buttonPicture.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void AdminHelpfulTipsControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {

            
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

        private void buttonPicture_Click_1(object sender, EventArgs e)
        {
            AdminDashboard parentForm = FindAdminDashboardParentForm();

            if (parentForm != null)
            {
                // Access the panelDesktopPanel directly
                Panel panelDesktopPanel = parentForm.PanelDesktopPanel;

                if (panelDesktopPanel != null)
                {
                    string disasterName = labelDisasters.Text;

                    TutorialForm tutorialForm = new TutorialForm(disasterName); // Replace Form1 with the actual form you want to open
                    tutorialForm.TopLevel = false;
                    tutorialForm.FormBorderStyle = FormBorderStyle.None;
                    tutorialForm.Dock = DockStyle.Fill;
                    panelDesktopPanel.Controls.Clear(); // Clear previous controls in the panelDesktopPanel
                    panelDesktopPanel.Controls.Add(tutorialForm);
                    tutorialForm.BringToFront();
                    tutorialForm.Show();
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
