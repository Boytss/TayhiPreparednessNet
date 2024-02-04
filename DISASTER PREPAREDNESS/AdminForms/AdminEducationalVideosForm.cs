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

namespace DISASTER_PREPAREDNESS.Forms
{
    public partial class AdminEducationalVideosForm : Form
    {
        public AdminEducationalVideosForm()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // Get information from form controls
            string title = txtTitle.Text;
            string videolink = txtVideoLink.Text;
         
            // Insert video into the database
            VideoDataAccess.InsertVideo(title, videolink);
            MessageBox.Show("Hazard map uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
