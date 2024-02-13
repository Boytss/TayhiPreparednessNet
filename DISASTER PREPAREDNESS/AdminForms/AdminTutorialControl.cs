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

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class AdminTutorialControl : UserControl
    {
        public AdminTutorialControl()
        {
            InitializeComponent();
        }
        public void SetTutorialText(string text)
        {
            labelTutorialText.Text = text;
        }

        private void labelTutorialText_Click(object sender, EventArgs e)
        {

        }
    }
}
