using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;


namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class VideoControl : UserControl
    {
        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }


        public string VideoLink { get; set; }

        public VideoControl()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
            webView21.Dock = DockStyle.Fill;
            Controls.Add(webView21);

        }



        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                MessageBox.Show("WebView2 initialization completed successfully.");
                webView21.Source = new Uri("about:blank");
            }
            else
            {
                MessageBox.Show($"Error initializing WebView2: {e.InitializationException.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetVideoLink(string videoLink)
        {
            try
            {
                MessageBox.Show("SetVideoLink called with VideoLink: " + videoLink);
                string videoId = GetYouTubeVideoId(videoLink);

                string embedHtml = $@"
<!DOCTYPE html>
<html>
<body style='margin:0;'>
    <iframe width='100%' height='100%' src='https://www.youtube.com/embed/{videoId}?autoplay=1' frameborder='0' allowfullscreen></iframe>
</body>
</html>";

                webView21.CoreWebView2.Navigate("about:blank");
                webView21.CoreWebView2.NavigateToString(embedHtml);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting video link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private string GetYouTubeVideoId(string videoLink)
        {
            try
            {
                var uri = new Uri(videoLink);
                var query = uri.Query;

                if (!string.IsNullOrEmpty(query))
                {
                    var queryParams = System.Web.HttpUtility.ParseQueryString(query);
                    var videoId = queryParams["v"];

                    if (!string.IsNullOrEmpty(videoId))
                    {
                        return videoId;
                    }
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error extracting video ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hazard map uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }
    }
}
