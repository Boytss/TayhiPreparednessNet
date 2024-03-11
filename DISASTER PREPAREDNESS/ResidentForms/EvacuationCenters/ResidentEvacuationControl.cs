using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.ResidentForms.EvacuationCenters
{
    public partial class ResidentEvacuationControl : UserControl
    {
        public Button ButtonEvacuation
        {
            get { return buttonEvacuation; }
        }
        private int evacuationCenterId;
        public ResidentEvacuationControl(int centerId, string evacuationCenterName, string location)
        {
            InitializeComponent();
            labelAddress.Text = location;
            buttonEvacuation.Text = evacuationCenterName;
            this.evacuationCenterId = centerId;
        }

        private void buttonEvacuation_Click(object sender, EventArgs e)
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

        private void buttonEvacuation_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonEvacuation_Click_2(object sender, EventArgs e)
        {
            ResidentDashboard parentForm = FindResidentDashboardParentForm();

            if (parentForm != null)
            {
                // Access the panelDesktopPanel directly
                Panel panelDesktopPanel = parentForm.PanelDesktopPanels;

                if (panelDesktopPanel != null)
                {
                    // Retrieve the evacuation center ID from the button's Tag property
                    int evacuationCenterId = (int)buttonEvacuation.Tag;
                    string evacuationCenterName = buttonEvacuation.Text;

                    ResidentEvacuationDetailsForm evacuationDetailsForm = new ResidentEvacuationDetailsForm(evacuationCenterId, evacuationCenterName); // Replace Form1 with the actual form you want to open
                    evacuationDetailsForm.TopLevel = false;
                    evacuationDetailsForm.FormBorderStyle = FormBorderStyle.None;
                    evacuationDetailsForm.Dock = DockStyle.Fill;
                    panelDesktopPanel.Controls.Clear(); // Clear previous controls in the panelDesktopPanel
                    panelDesktopPanel.Controls.Add(evacuationDetailsForm);
                    evacuationDetailsForm.BringToFront();
                    evacuationDetailsForm.Show();
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
