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

namespace DISASTER_PREPAREDNESS.AdminForms.EvacuationcCenters
{
    public partial class EvacueeListForm : Form
    {
        private string selectedDisaster;
        public EvacueeListForm(string selectedDisaster)
        {
            InitializeComponent();
            this.selectedDisaster = selectedDisaster;
            PopulateDataGridView();
            this.evacueeDataGridView.CellMouseClick += evacueeDataGridView_CellMouseClick;
            
        }
        private void PopulateDataGridView()
        {
            evacueeDataGridView.ClearSelection();
            try
            {
                // Retrieve evacuee information based on the selected disaster
                List<Evacuee> evacuees = EvacueeDataAccess.RetrieveEvacueesByDisaster(selectedDisaster);

                // Set DataGridView data source
                evacueeDataGridView.DataSource = evacuees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void showLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (evacueeDataGridView.SelectedRows.Count > 0)
            {
                // Get the ID of the selected resident
                int evacueeID = Convert.ToInt32(evacueeDataGridView.SelectedRows[0].Cells["EvacueeID"].Value);

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this resident?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Perform deletion
                        EvacueeDataAccess.DeleteEvacuee(evacueeID);

                        // Refresh the DataGridView after deletion
                        PopulateDataGridView(); // Assuming you have a method to reload data
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

        private void evacueeDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                evacueeDataGridView.ClearSelection();
                evacueeDataGridView.Rows[e.RowIndex].Selected = true;
                contextMenuStrip1.Show(evacueeDataGridView, e.Location);
            }
        }
    }
}
