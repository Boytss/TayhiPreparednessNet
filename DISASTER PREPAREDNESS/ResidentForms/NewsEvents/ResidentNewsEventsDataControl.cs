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

namespace DISASTER_PREPAREDNESS.ResidentForms.NewsEvents
{
    public partial class ResidentNewsEventsDataControl : UserControl
    {
        private string titleName; // Store the titleName
        private const int someExtraSpace = 10; // Adjust this value as needed
        public ResidentNewsEventsDataControl(String titleName, String date, String imagePath)
        {
            InitializeComponent();
            this.titleName = titleName; // Store the titleName
            linkTitle.Text = titleName;
            labelDate.Text = date;

            buttonImage.BackgroundImage = Image.FromFile(imagePath);
            buttonImage.BackgroundImageLayout = ImageLayout.Stretch;
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



        private void linkTitle_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {

        }

        private void linkTitle_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkTitle_LinkClicked_3(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResidentDashboard parentForm = FindResidentDashboardParentForm();

            if (parentForm != null)
            {
                // Access the panelDesktopPanel directly
                Panel panelDesktopPanel = parentForm.PanelDesktopPanels;

                if (panelDesktopPanel != null)
                {
                    ResidentNewsEventsDiscriptionForm discriptionForm = new ResidentNewsEventsDiscriptionForm(titleName); // Replace Form1 with the actual form you want to open
                    discriptionForm.TopLevel = false;
                    discriptionForm.FormBorderStyle = FormBorderStyle.None;
                    discriptionForm.Dock = DockStyle.Fill;
                    panelDesktopPanel.Controls.Clear(); // Clear previous controls in the panelDesktopPanel
                    panelDesktopPanel.Controls.Add(discriptionForm);
                    discriptionForm.BringToFront();
                    discriptionForm.Show();
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

        private void ResidentNewsEventsDataControl_Load(object sender, EventArgs e)
        {

        }
    }
}
