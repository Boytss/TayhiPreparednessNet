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

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class AddResidentForm : Form
    {
        public AddResidentForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the textboxes
                string firstName = textFirstName.Text;
                string lastName = textLastName.Text;
                string purokNumber = comboBoxPurokNumber.Text;
                string mobileNumber = textMobileNumber.Text;
                string username = textUsername.Text;
                string password = textPassword.Text;

                // Add the new resident to the database
                ResidentDataAccess.AddResident(firstName, lastName, purokNumber, mobileNumber, username, password);

                MessageBox.Show("Resident added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding resident: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
