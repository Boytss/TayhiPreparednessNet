using DISASTER_PREPAREDNESS.AdminForms;
using DISASTER_PREPAREDNESS.DataAccess;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class ResidentEducationalVideosForm : Form
    {
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;

        public ResidentEducationalVideosForm()
        {
            InitializeComponent();
            InitializeWebView21();
            

        }
        private void InitializeControls()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
            webView21.Dock = DockStyle.Fill;
            Controls.Add(webView21);
        }
        private void InitializeWebView21()
        {
            try
            {
                MessageBox.Show("Initializing WebView21");
                webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
                webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
                webView21.Dock = DockStyle.Fill;
                Controls.Add(webView21);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing WebView2: {ex.Message}");
                MessageBox.Show($"Error initializing WebView2: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                webView21.Source = new Uri("about:blank");
            }
            else
            {
                MessageBox.Show($"Error initializing WebView2: {e.InitializationException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadVideosAsync()
        {
            try
            {
                VideoDataAccess videoDataAccess = new VideoDataAccess();
                DataTable videosDataTable = await Task.Run(() => VideoDataAccess.GetVideos());

                if (videosDataTable != null)
                {
                    foreach (DataRow row in videosDataTable.Rows)
                    {
                        string title = row["Title"].ToString();
                        string videoLink = row["VideoLink"].ToString();

                        VideoControl videoControl = new VideoControl
                        {
                            Title = title,
                            VideoLink = videoLink
                        };

                        flowLayoutPanelVideos.Controls.Add(videoControl);
                    }
                }
                else
                {
                    MessageBox.Show("Video data is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Specific error loading videos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadVideosAsync();
        }

    }
    
}
