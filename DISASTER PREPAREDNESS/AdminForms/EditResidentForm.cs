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
using DISASTER_PREPAREDNESS.DataAccess;

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class EditResidentForm : Form
    {
        private readonly int residentID;
        public EditResidentForm(int residentID)
        {
            InitializeComponent();
            this.residentID = residentID; // Save the residentID received in the constructor
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the updated values from the textboxes
                string updatedFirstName = textFirstName.Text;
                string updatedLastName = textLastName.Text;
                string updatedPurokNumber = comboBoxPurokNumber.Text;
                string updatedMobileNumber = textMobileNumber.Text;

                // Get the resident ID from the form (assuming you have a property or method to retrieve it)
                ResidentDataAccess.UpdateResident(residentID, updatedFirstName, updatedLastName, updatedPurokNumber, updatedMobileNumber);

                MessageBox.Show("Resident updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating resident: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
