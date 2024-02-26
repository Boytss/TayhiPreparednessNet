using DISASTER_PREPAREDNESS.DataAccess;
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
using DISASTER_PREPAREDNESS.MyControls;
using DISASTER_PREPAREDNESS.DataAccess;
namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class AdminManageResidenceForm : Form
    {
        public AdminManageResidenceForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
            dataGridViewResidents.ClearSelection();
            // Attach the Resize event handler
            this.Resize += ManageResidenceForm_Resize;

            // Customize the searchName TextBox
        }
        // Function to customize TextBox appearance
        // Function to apply rounded border to TextBox



        private void LoadResidentsData()
        {
            dataGridViewResidents.ClearSelection();

            try
            {
                // Fetch resident data from the database
                DataTable residentsDataTable = ResidentDataAccess.GetAllResidents();

                // Display the data in the DataGridView
                dataGridViewResidents.DataSource = residentsDataTable;
                // Set column header text
                dataGridViewResidents.Columns["ID"].HeaderText = "ID";
                dataGridViewResidents.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewResidents.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewResidents.Columns["PurokNumber"].HeaderText = "Purok Number";
                dataGridViewResidents.Columns["MobileNumber"].HeaderText = "Mobile Number";
                dataGridViewResidents.Columns["Username"].HeaderText = "Username";
                dataGridViewResidents.Columns["Password"].HeaderText = "Password";
                dataGridViewResidents.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading residents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageResidenceForm_Load_1(object sender, EventArgs e)
        {

            LoadResidentsData();
            dataGridViewResidents.ClearSelection();


        }



        private void ManageResidenceForm_Resize(object sender, EventArgs e)
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
            dataGridViewResidents.RowTemplate.Height = 40; // Adjust the value as needed


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

        //private void buttonSearch_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string searchTerm = textSearch.Text;

        //        // Perform a search operation based on the searchTerm
        //        DataTable searchResults = ResidentDataAccess.SearchResidents(searchTerm);

        //        // Update the DataGridView with search results
        //        dataGridViewResidents.DataSource = searchResults;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error searching residents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}




       


        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new row for the DataGridView's DataTable
                DataRow newRow = ((DataTable)dataGridViewResidents.DataSource).NewRow();

                // Add default values to the new row if needed
                // For example:
                // newRow["ColumnName"] = defaultValue;
                newRow["ID"] = GetNextAvailableID();
                // Add the new row to the DataTable
                ((DataTable)dataGridViewResidents.DataSource).Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new resident: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetNextAvailableID()
        {
            // Determine the next available ID based on existing data
            int maxID = 0;
            foreach (DataRow row in ((DataTable)dataGridViewResidents.DataSource).Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                if (id > maxID)
                {
                    maxID = id;
                }
            }
            return maxID + 1;
        }

       

        private void AdminManageResidenceForm_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridViewResidents_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the "Resident Details" tab is selected
            if (tabControl1.SelectedTab == tabPage2)
            {
                // Check if there is a selected row in the DataGridView
                if (dataGridViewResidents.SelectedRows.Count > 0)
                {
                    // Retrieve data from the selected row
                    DataGridViewRow selectedRow = dataGridViewResidents.SelectedRows[0];
                    string firstName = Convert.ToString(selectedRow.Cells["FirstName"].Value);
                    string lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
                    string purokNumber = Convert.ToString(selectedRow.Cells["PurokNumber"].Value);
                    string mobileNumber = Convert.ToString(selectedRow.Cells["MobileNumber"].Value);

                    // Populate text boxes in the "Resident Details" tab with the retrieved data
                    residentFirstNameTextbox.Text = firstName;
                    residentLastnameTextbox.Text = lastName;
                    residentPurokNumberTextbox.Text = purokNumber;
                    residentMobileNumberTextbox.Text = mobileNumber;

                }
                else
                {
                    // Clear text boxes if no row is selected
                    residentFirstNameTextbox.Text = "";
                    residentLastnameTextbox.Text = "";
                    residentPurokNumberTextbox.Text = "";
                    residentMobileNumberTextbox.Text = "";

                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchNameTextbox.Text; // Get the search term from the TextBox
            SearchResidents(searchTerm);
        }
        private void SearchResidents(string searchTerm)
        {
            try
            {
                // Perform the search operation based on the searchTerm
                DataTable searchResults = ResidentDataAccess.SearchResidents(searchTerm);

                // Update the DataGridView with search results
                dataGridViewResidents.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching residents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(searchNameTextbox.Text);
            string searchTerm = searchNameTextbox.Text; // Get the search term from the TextBox
            SearchResidents(searchTerm);
        }



        private void searchNameTextbox_TextChanged(object sender, EventArgs e)
        {

            // Get the search term from the TextBox
            string searchTerm = searchNameTextbox.Text.Trim();

            // If search term is empty, show all rows
            if (string.IsNullOrEmpty(searchTerm))
            {
                dataGridViewResidents.DataSource = ResidentDataAccess.GetAllResidents();
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
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("Username LIKE '%{0}%'", keyword);
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("Password LIKE '%{0}%'", keyword);
                filterExpression.Append(")");
            }
            filterExpression.Append(")");

            // Apply the filter to the DataGridView's DataSource
            ((DataTable)dataGridViewResidents.DataSource).DefaultView.RowFilter = filterExpression.ToString();

        }

        private void residentLastnameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Add new Resident";

            dataGridViewResidents.ClearSelection();

            // Switch to the second tab
            tabControl1.SelectedIndex = 1;
            residentFirstNameTextbox.Text = "";
            residentLastnameTextbox.Text = "";
            residentPurokNumberTextbox.Text = "";
            residentMobileNumberTextbox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values from your form controls
                string firstName = residentFirstNameTextbox.Text;
                string lastName = residentLastnameTextbox.Text;
                string purokNumber = residentPurokNumberTextbox.Text;
                string mobileNumber = residentMobileNumberTextbox.Text;
                string username = usernameTextbox.Text;
                string password = passwordTextbox.Text;

                // Check if a resident is selected in the DataGridView
                if (dataGridViewResidents.SelectedRows.Count > 0)
                {
                    // An existing resident is selected, so update their information
                    int residentID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["ID"].Value);
                    ResidentDataAccess.UpdateResident(residentID, firstName, lastName, purokNumber, mobileNumber, username, password);

                    // Optionally, provide feedback to the user about the success of the update operation
                    MessageBox.Show("Resident information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadResidentsData();
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    // No resident is selected, so add a new resident
                    ResidentDataAccess.AddResident(firstName, lastName, purokNumber, mobileNumber, username, password);

                    // Optionally, provide feedback to the user about the success of the addition operation
                    MessageBox.Show("Resident added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadResidentsData();

                }

                // Optionally, clear the input fields after successful operation
                ClearInputFields();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the operation
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            // Clear input fields after successful operation
            residentFirstNameTextbox.Text = "";
            residentLastnameTextbox.Text = "";
            residentPurokNumberTextbox.Text = "";
            residentMobileNumberTextbox.Text = "";
            usernameTextbox.Text = "";
            passwordTextbox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the selection in the DataGridView
            dataGridViewResidents.ClearSelection();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            labelDetails.Text = "Edit Resident Details";
            tabControl1.SelectedIndex = 1;

            // Check if the "Resident Details" tab is selected

            // Check if there is a selected row in the DataGridView
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = dataGridViewResidents.SelectedRows[0];
                string firstName = Convert.ToString(selectedRow.Cells["FirstName"].Value);
                string lastName = Convert.ToString(selectedRow.Cells["LastName"].Value);
                string purokNumber = Convert.ToString(selectedRow.Cells["PurokNumber"].Value);
                string mobileNumber = Convert.ToString(selectedRow.Cells["MobileNumber"].Value);
                string username = Convert.ToString(selectedRow.Cells["Username"].Value);
                string password = Convert.ToString(selectedRow.Cells["Password"].Value);

                // Populate text boxes in the "Resident Details" tab with the retrieved data
                residentFirstNameTextbox.Text = firstName;
                residentLastnameTextbox.Text = lastName;
                residentPurokNumberTextbox.Text = purokNumber;
                residentMobileNumberTextbox.Text = mobileNumber;
                usernameTextbox.Text = username;
                passwordTextbox.Text = password;


            }
            else
            {
                // Clear text boxes if no row is selected
                residentFirstNameTextbox.Text = "";
                residentLastnameTextbox.Text = "";
                residentPurokNumberTextbox.Text = "";
                residentMobileNumberTextbox.Text = "";

            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Get the ID of the selected resident
                int residentID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["ID"].Value);

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this resident?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Perform deletion
                        ResidentDataAccess.DeleteResident(residentID);

                        // Refresh the DataGridView after deletion
                        LoadResidentsData(); // Assuming you have a method to reload data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting resident: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a resident to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchNameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the "ding" sound
                e.SuppressKeyPress = true;

                // Programmatically click the search button
                searchButton_Click(sender, e);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void myComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Purok from the dropdown
            string selectedPurok = searchByPurokDropdown.Texts.ToString();

            // Perform the search operation based on the selected Purok
            SearchResidentsByPurok(selectedPurok);
        }

        private void SearchResidentsByPurok(string purok)
        {
            try
            {
                // Perform the search operation based on the selected Purok
                DataTable searchResults = ResidentDataAccess.SearchResidentsByPurok(purok);

                // Update the DataGridView with search results
                dataGridViewResidents.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching residents by Purok: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
