using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using DISASTER_PREPAREDNESS.DataAccess;

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class EmergencyAlertForm : Form
    {


        public EmergencyAlertForm()
        {
            InitializeComponent();
            ConfigureDataGridView();

            // Attach the Resize event handler
            this.Resize += EmergencyAlertForm_Resize;



            // Scroll Bars
            dataGridViewResidents.ScrollBars = ScrollBars.Both;
        }

        private void LoadResidentsData()
        {
            try
            {
                // Fetch resident data from the database
                DataTable residentsContactDataTable = ResidentDataAccess.GetAllResidentContacts();

                // Display the data in the DataGridView
                dataGridViewResidents.DataSource = residentsContactDataTable;
                // Set column header text
                dataGridViewResidents.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewResidents.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewResidents.Columns["PurokNumber"].HeaderText = "Purok Number";
                dataGridViewResidents.Columns["MobileNumber"].HeaderText = "Mobile Number";
                dataGridViewResidents.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading residents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SendSMS(string phoneNumber, string message)
        {
            SerialPort sp = new SerialPort();
            try
            {
                // Configure serial port
                sp.PortName = txtPort.Texts;
                sp.Open();

                // Set write timeout to 1000 milliseconds (1 second)
                sp.WriteTimeout = 1000;

                // Set SMS text mode
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);

                // Set recipient phone number
                sp.WriteLine("AT+CMGS=\"" + phoneNumber + "\"" + Environment.NewLine);

                // Set message content
                sp.Write(message + '\x1A'); // '\x1A' is the ASCII code for Ctrl+Z (End of message)

                // Read response
                var response = sp.ReadExisting();

                if (response.Contains("ERROR"))
                {
                    MessageBox.Show("Send Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the serial port when done
                if (sp.IsOpen)
                    sp.Close();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void EmergencyAlertForm_Load(object sender, EventArgs e)
        {
            LoadResidentsData();

        }

        private void EmergencyAlertForm_Resize(object sender, EventArgs e)
        {
            AdjustColumnSizes();
        }
        private void ConfigureDataGridView()
        {


            // Set AutoSizeMode for columns
            foreach (DataGridViewColumn column in dataGridViewResidents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // If binding to a data source, reload it
            // Example: dataGridViewResidents.DataSource = yourDataSource;

            // Adjust column sizes initially
            AdjustColumnSizes();
        }
        private void AdjustColumnSizes()
        {
            // Manually adjust column sizes based on form size
            foreach (DataGridViewColumn column in dataGridViewResidents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void SendSMSMessagesToPurok(string purok, string messageContent)
        {
            DataTable dataTable = (DataTable)dataGridViewResidents.DataSource;
            if (dataTable == null) return;

            var rowsToSendSMS = dataTable.AsEnumerable()
                                          .Where(row => row.Field<string>("PurokNumber") == purok)
                                          .ToList();

            foreach (DataRow row in rowsToSendSMS)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, messageContent);
            }

            if (rowsToSendSMS.Count > 0)
            {
                MessageBox.Show($"SMS messages have been sent to all residents in Purok {purok}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No residents found in Purok {purok} to send SMS.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void searchNameTextbox_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = searchNameTextbox.Text.Trim();

            // If search term is empty, show all rows
            if (string.IsNullOrEmpty(searchTerm))
            {
                dataGridViewResidents.DataSource = ResidentDataAccess.GetAllResidentContacts();
                return;
            }

            // Split the search term into individual words
            string[] keywords = searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Construct the filter expression dynamically
            StringBuilder filterExpression = new StringBuilder();
            filterExpression.Append("(");
            foreach (string keyword in keywords)
            {
                if (filterExpression.Length > 1)
                    filterExpression.Append(" AND ");

                filterExpression.Append("(");
                filterExpression.AppendFormat("FirstName LIKE '%{0}%'", keyword);
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("LastName LIKE '%{0}%'", keyword);
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("PurokNumber LIKE '%{0}%'", keyword);
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("MobileNumber LIKE '%{0}%'", keyword);

                filterExpression.Append(")");
            }
            filterExpression.Append(")");

            // Apply the filter to the DataGridView's DataSource
            ((DataTable)dataGridViewResidents.DataSource).DefaultView.RowFilter = filterExpression.ToString();

        }

        private void searchByPurokDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Purok from the dropdown
            string selectedPurok = searchByPurokDropdown.SelectedItem.ToString();

            // Perform the search operation based on the selected Purok
            SearchResidentsByPurok(selectedPurok);
        }
        private void SearchResidentsByPurok(string purok)
        {
            try
            {
                DataTable searchResults;

                if (purok == "All Residents")
                {
                    // Fetch all residents
                    searchResults = ResidentDataAccess.GetAllResidentContacts();
                }
                else
                {
                    // Fetch residents by the selected purok
                    searchResults = ResidentDataAccess.SearchResidentsByPurok(purok);
                }

                // Update the DataGridView with search results
                dataGridViewResidents.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching residents by Purok: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            if (searchByPurokDropdown.SelectedItem != null && searchByPurokDropdown.SelectedItem.ToString() == "All Residents")
            {
                // Retrieve all residents' mobile numbers
                DataTable allResidentsDataTable = ResidentDataAccess.GetAllResidentContacts();

                // Check if any residents are found
                if (allResidentsDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No residents found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Confirmation before sending SMS to all residents
                DialogResult result = MessageBox.Show("Are you sure you want to send SMS alerts to all residents?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Iterate through each resident and send SMS
                    foreach (DataRow row in allResidentsDataTable.Rows)
                    {
                        string phoneNumber = row["MobileNumber"].ToString();
                        SendSMS(phoneNumber, message.Text);
                    }

                    MessageBox.Show("SMS alerts have been sent to all residents!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Iterate through each resident and send SMS
                foreach (DataRow row in allResidentsDataTable.Rows)
                {
                    string phoneNumber = row["MobileNumber"].ToString();
                    SendSMS(phoneNumber, message.Text);
                }

                MessageBox.Show("SMS alerts have been sent to all residents!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridViewResidents.SelectedRows.Count == 0)
            {
                string selectedPurok = searchByPurokDropdown.SelectedItem.ToString();
                SendSMSMessagesToPurok(selectedPurok, message.Text);
            }
            else
            {
                // Existing code to send SMS to selected rows
                List<string> selectedPhoneNumbers = new List<string>();
                foreach (DataGridViewRow row in dataGridViewResidents.SelectedRows)
                {
                    string phoneNumber = row.Cells["MobileNumber"].Value.ToString();
                    selectedPhoneNumbers.Add(phoneNumber);
                }

                foreach (string phoneNumber in selectedPhoneNumbers)
                {
                    SendSMS(phoneNumber, message.Text);
                }

                MessageBox.Show("SMS alerts have been sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPort_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the selection in the DataGridView
            dataGridViewResidents.ClearSelection();
        }
    }
}