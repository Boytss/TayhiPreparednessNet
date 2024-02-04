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
        private PictureBox pictureBoxZoomed;
        public ZoomedImageForm(Image image)
        {
            InitializeComponent();
            InitializePictureBox(image);
        }
        private void InitializePictureBox(Image image)
        {
            pictureBoxZoomed = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(pictureBoxZoomed);

            this.Size = new Size(Math.Min(image.Width, Screen.PrimaryScreen.WorkingArea.Width),
                                Math.Min(image.Height, Screen.PrimaryScreen.WorkingArea.Height));

            this.StartPosition = FormStartPosition.CenterParent;
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
