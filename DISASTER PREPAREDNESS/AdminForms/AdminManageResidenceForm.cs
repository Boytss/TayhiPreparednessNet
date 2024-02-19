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

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class AdminManageResidenceForm : Form
    {
        public AdminManageResidenceForm()
        {
            InitializeComponent();
            ConfigureDataGridView();

            // Attach the Resize event handler
            this.Resize += ManageResidenceForm_Resize;

            // Customize the searchName TextBox
        }
        // Function to customize TextBox appearance
        // Function to apply rounded border to TextBox



        private void LoadResidentsData()
        {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading residents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageResidenceForm_Load_1(object sender, EventArgs e)
        {
            LoadResidentsData();

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




        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Get the ID of the selected resident
                int residentID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["ID"].Value);

                // Open the EditResidentForm with the selected resident's ID
                EditResidentForm editForm = new EditResidentForm(residentID);
                editForm.ShowDialog();

                // Refresh the DataGridView after editing
                LoadResidentsData();
            }
            else
            {
                MessageBox.Show("Please select a resident to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }











        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
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
                        LoadResidentsData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting resident: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {

                // Enable edit mode for the DataGridView
                dataGridViewResidents.BeginEdit(true);
            }
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

        private void dataGridViewResidents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewResidents.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    // Select the row under the mouse pointer
                    dataGridViewResidents.Rows[currentMouseOverRow].Selected = true;

                    // Display the ContextMenuStrip at the mouse pointer's location
                    contextMenuStrip1.Show(dataGridViewResidents, new Point(e.X, e.Y));
                }
            }
        }

        private void AdminManageResidenceForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myTextBox1_Load(object sender, EventArgs e)
        {
        }

        private void myTextBox2__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("sasdas");

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
                    string username = Convert.ToString(selectedRow.Cells["Username"].Value);
                    string password = Convert.ToString(selectedRow.Cells["Password"].Value);

                    // Populate text boxes in the "Resident Details" tab with the retrieved data
                    textBox1.Text = firstName;
                    residentLastnameTextbox.Text = lastName;
                    residentPurokNumberTextbox.Text = purokNumber;
                    residentMobileNumberTextbox.Text = mobileNumber;
                    residentUsernameTextbox.Text = username;
                    residentPasswordTextbox.Text = password;
                }
                else
                {
                    // Clear text boxes if no row is selected
                    residentFirstNameTextbox.Text = "";
                    residentLastnameTextbox.Text = "";
                    residentPurokNumberTextbox.Text = "";
                    residentMobileNumberTextbox.Text = "";
                    residentUsernameTextbox.Text = "";
                    residentPasswordTextbox.Text = "";
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
           

        }
    }
}
