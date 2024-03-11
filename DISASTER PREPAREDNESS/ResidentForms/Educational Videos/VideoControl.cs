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
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class VideoControl : UserControl
    {
        private bool isInitialized = false;
        private string embedCodeToLoad;

        public VideoControl()
        {
            InitializeComponent();
            webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
        }

        public void LoadVideo(string embedCode)
        {
            // If the control is already initialized, load the embed code
            if (isInitialized)
            {
                webView21.NavigateToString(embedCode);
            }
            // Otherwise, save the embed code to load after initialization
            else
            {
                embedCodeToLoad = embedCode;
            }
        }

        private void WebView2_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {

                isInitialized = true;
                // If there's an embed code waiting to be loaded, load it now
                if (!string.IsNullOrEmpty(embedCodeToLoad))
                {
                    webView21.NavigateToString(embedCodeToLoad);
                    embedCodeToLoad = null;
                }
            }
            else
            {
                MessageBox.Show("WebView2 initialization failed." + e.InitializationException.Message);
            }
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
