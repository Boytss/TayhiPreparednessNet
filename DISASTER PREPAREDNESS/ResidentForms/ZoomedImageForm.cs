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
    public partial class ZoomedImageForm : Form
    {
        public ZoomedImageForm(Image image)
        {
            InitializeComponent();
            InitializeForm(image);
        }

        private void InitializeForm(Image image)
        {
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            this.Size = new Size(Math.Min(image.Width, Screen.PrimaryScreen.WorkingArea.Width),
                                 Math.Min(image.Height, Screen.PrimaryScreen.WorkingArea.Height));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Allow the form to be draggable
            this.MouseDown += ZoomedImageForm_MouseDown;
            this.MouseMove += ZoomedImageForm_MouseMove;
        }

        private Point lastLocation;

        private void ZoomedImageForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void ZoomedImageForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }
    }
}
