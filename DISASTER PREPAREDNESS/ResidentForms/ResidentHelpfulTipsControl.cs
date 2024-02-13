using DISASTER_PREPAREDNESS.AdminForms;
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
    public partial class ResidentHelpfulTipsControl : UserControl
    {
        // Property for the disaster name

        public ResidentHelpfulTipsControl(string DisasterName, String PictureLogoPath)
        {
            InitializeComponent();
            labelDisasters.Text = DisasterName;
            buttonPicture.BackgroundImage = Image.FromFile(PictureLogoPath);
            buttonPicture.BackgroundImageLayout = ImageLayout.Stretch;

        }
        

        private void buttonPicture_Click_1(object sender, EventArgs e)
        {
            ResidentDashboard parentForm = FindResidentDashboardParentForm();

            if (parentForm != null)
            {
                // Access the panelDesktopPanel directly
                Panel panelDesktopPanel = parentForm.PanelDesktopPanels;

                if (panelDesktopPanel != null)
                {
                    string disasterName = labelDisasters.Text;

                    ResidentTutorialForm tutorialForm = new ResidentTutorialForm(disasterName); // Replace Form1 with the actual form you want to open
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
