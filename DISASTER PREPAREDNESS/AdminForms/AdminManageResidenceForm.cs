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
    public partial class AdminManageResidenceForm : Form
    {
        public AdminManageResidenceForm()
        {
            InitializeComponent();
            ConfigureDataGridView();

            // Attach the Resize event handler
            this.Resize += ManageResidenceForm_Resize;


            // Customizing Row and Column Headers
            dataGridViewResidents.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewResidents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewResidents.RowHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewResidents.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            // Changing Cell Styles
            dataGridViewResidents.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewResidents.DefaultCellStyle.ForeColor = Color.Black;

            // Setting Font
            dataGridViewResidents.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridViewResidents.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            // Handling Cell Formatting Events (You can customize this event based on your needs)

            // Row Details
            dataGridViewResidents.RowTemplate.Height = 30; // Set the height for each row

            // Scroll Bars
            dataGridViewResidents.ScrollBars = ScrollBars.Both; // Horizontal and vertical scroll bars
        }



        private void LoadResidentsData()
        {
            try
            {
                // Fetch resident data from the database
                DataTable residentsDataTable = ResidentDataAccess.GetAllResidents();

                // Display the data in the DataGridView
                dataGridViewResidents.DataSource = residentsDataTable;
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
                column.Width = column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = textSearch.Text;

                // Perform a search operation based on the searchTerm
                DataTable searchResults = ResidentDataAccess.SearchResidents(searchTerm);

                // Update the DataGridView with search results
                dataGridViewResidents.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching residents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Open the AddResidentForm
            AddResidentForm addForm = new AddResidentForm();
            addForm.ShowDialog();

            // Refresh the DataGridView after adding a new resident
            LoadResidentsData();
        }

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewResidents.SelectedRows.Count > 0)
            {
                // Get the ID of the selected resident
                int residentID = Convert.ToInt32(dataGridViewResidents.SelectedRows[0].Cells["ID"].Value);

                // Confirm the deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this resident?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Perform the deletion
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
            else
            {
                MessageBox.Show("Please select a resident to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
