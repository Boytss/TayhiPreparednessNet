using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.AdminForms.NewsEvents
{
    public partial class NewsEventsDataControl : UserControl
    {
        public NewsEventsDataControl(String titleName, String date, String imagePath)
        {
            InitializeComponent();
            labelTitle.Text = titleName;
            labelDate.Text = date;

            buttonImage.BackgroundImage = Image.FromFile(imagePath);
            buttonImage.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void buttonImage_Click(object sender, EventArgs e)
        {
           
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashboard parentForm = FindAdminDashboardParentForm();

            if (parentForm != null)
            {
                // Access the panelDesktopPanel directly
                Panel panelDesktopPanel = parentForm.PanelDesktopPanel;

                if (panelDesktopPanel != null)
                {

                    NewsEventsDiscriptionForm discriptionForm = new NewsEventsDiscriptionForm(); // Replace Form1 with the actual form you want to open
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
    }
}
