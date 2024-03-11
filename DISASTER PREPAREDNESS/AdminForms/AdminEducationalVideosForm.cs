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
            try
            {
                string title = Title.Text;
                string videoLink = url.Text;

                VideoDataAccess.InsertVideo(title, videoLink);

                MessageBox.Show("Video upload successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading Video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
