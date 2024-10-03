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
    public partial class OpenStreetMapForm : Form
    {
        public OpenStreetMapForm(string houseNumber)
        {
            InitializeComponent();
            // Construct the URL for OpenStreetMapWeather based on the selected house number
            string url = $"https://www.openstreetmap.org/way/{houseNumber}";

            // Load the URL in the WebView2 control
            webView21.Source = new Uri(url);
        }
    }
}
