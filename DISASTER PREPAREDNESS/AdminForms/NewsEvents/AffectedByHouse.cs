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

namespace DISASTER_PREPAREDNESS.AdminForms.NewsEvents
{
    public partial class AffectedByHouse : Form
    {
        private string selectedDisaster;

        public AffectedByHouse(string selectedDisaster)
        {
            InitializeComponent();
            this.selectedDisaster = selectedDisaster;
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            try
            {
                // Retrieve evacuee information based on the selected disaster
                List<ConditionByHouse> affectedByHouses = AffectedDataAccess.RetrieveAffectedByHouse(selectedDisaster);

                // Set DataGridView data source
                affectedByHouseDataGridView.DataSource = affectedByHouses;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void affectedByHouseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void affectedByHouseDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            // Get the house number from the selected row
            string houseNumber = affectedByHouseDataGridView.CurrentRow.Cells["HouseNumber"].Value.ToString();

            // Open the OpenStreetMapForm with the selected house number
            OpenStreetMapForm openStreetMapForm = new OpenStreetMapForm(houseNumber);
            openStreetMapForm.Show();
        }

        private void affectedByHouseDataGridView_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void affectedByHouseDataGridView_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if right-click occurred
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Select the cell
                affectedByHouseDataGridView.CurrentCell = affectedByHouseDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Show the context menu at the mouse position
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                ToolStripMenuItem menuItem = new ToolStripMenuItem("Show location");
                menuItem.Click += MenuItem_Click;
                contextMenu.Items.Add(menuItem);
                contextMenu.Show(affectedByHouseDataGridView, e.Location);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void affectedByHouseDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
