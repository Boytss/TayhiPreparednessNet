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
    public partial class PersonConditionList : Form
    {
        private string selectedDisaster;
        public PersonConditionList(string selectedDisaster)
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
                List<PersonByCondition> personByConditions = AffectedDataAccess.RetrievePersonByCondition(selectedDisaster);

                // Set DataGridView data source
                personByConditionDataGridView.DataSource = personByConditions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void personByConditionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
