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
            webView21.NavigationCompleted += webView21_NavigationCompleted;
            webView21.Dock = DockStyle.Fill;
            Controls.Add(webView21);

            // Add the following line to ensure CoreWebView2 is initialized
            webView21.EnsureCoreWebView2Async(null);

        }
        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Console.WriteLine($"Navigation completed with result: {e.IsSuccess}, WebErrorStatus: {e.WebErrorStatus}");

        }


        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                Console.WriteLine("WebView2 initialization completed successfully.");
                SetVideoLink(VideoLink);
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

                string html = $@"
<!DOCTYPE html>
<html>
<body style='margin:0;'>
    <iframe width='100%' height='100%' src='https://www.youtube.com/embed/{videoId}' frameborder='0' allowfullscreen></iframe>
</body>
</html>";

                webView21.CoreWebView2.Navigate("about:blank");
                webView21.CoreWebView2.NavigateToString(html);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting video link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private string GetYouTubeVideoId(string videoLink)
        {
            // Extract the video ID from the YouTube video link
            Uri uri = new Uri(videoLink);
            string query = uri.Query;
            if (!string.IsNullOrEmpty(query))
            {
                string[] queryParams = query.Substring(1).Split('&');
                foreach (string param in queryParams)
                {
                    string[] keyValue = param.Split('=');
                    if (keyValue.Length == 2 && keyValue[0] == "v")
                    {
                        return keyValue[1];
                    }
                }
            }
            return string.Empty;
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hazard map uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
