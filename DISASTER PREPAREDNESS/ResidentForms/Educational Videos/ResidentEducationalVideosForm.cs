using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DISASTER_PREPAREDNESS.AdminForms;
using DISASTER_PREPAREDNESS.MyControls;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class ResidentEducationalVideosForm : Form
    {
        public ResidentEducationalVideosForm()
        {
            InitializeComponent();

        }


        private void ResidentEducationalVideosForm_Load_1(object sender, EventArgs e)
        {
            // Fetch videos from the database
            DataTable videosDataTable = VideoDataAccess.GetVideos();

            // Loop through the fetched videos and create VideoControl instances
            foreach (DataRow row in videosDataTable.Rows)
            {
                string title = row["Title"].ToString();
                string videoURL = row["VideoURL"].ToString();

                // Create an instance of VideoControl
                VideoControl videoControl = new VideoControl();

                // Generate embed code for the video URL
                string embedCode = $"<iframe width='100%' height='100%' src='{videoURL}' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";

                // Load the video into the VideoControl
                videoControl.LoadVideo(embedCode);

                // Add the videoControl to the flowLayoutPanel1
                flowLayoutPanel.Controls.Add(videoControl);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
