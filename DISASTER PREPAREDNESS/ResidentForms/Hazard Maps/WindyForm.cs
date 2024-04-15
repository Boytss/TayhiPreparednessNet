using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace DISASTER_PREPAREDNESS.ResidentForms.Hazard_Maps
{
    public partial class WindyForm : Form
    {
        public WindyForm()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);

            // Construct Windy.com URL with custom coordinates
            string windyUrl = "https://www.windy.com/?13.364,123.730";

            // Load Windy.com map in WebView2 control
            webView21.CoreWebView2.Navigate(windyUrl);
        }
    }
}
