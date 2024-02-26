﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DISASTER_PREPAREDNESS.ResidentForms;
namespace DISASTER_PREPAREDNESS
{
    public partial class ResidentDashboard : Form
    {
        private string loggedInUsername;
        public Panel PanelDesktopPanels { get { return panelDesktopPanel; } }

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        // Import the necessary Windows API functions
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // Define constants for window messages
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        public ResidentDashboard(string username)
        {
            InitializeComponent();

            loggedInUsername = username;
            userLabel.Text = loggedInUsername;

            random = new Random();
            buttonWeatherForecast_Click(null, EventArgs.Empty);
            SetRoundedCorners(this, 15);

            ApplyRoundedEdges(panel2);
            ApplyCircularBorder(panel4);
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            this.loggedInUsername = loggedInUsername;
        }
        private void ApplyCircularBorder(Panel panel)
        {
            panel.BackColor = Color.Transparent; // Set background color as transparent

            // Override OnPaint event to draw circular border
            panel.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle bounds = panel.ClientRectangle;
                    bounds.Width--; // Adjust width and height to compensate for the border
                    bounds.Height--;
                    path.AddEllipse(bounds);

                    using (Pen pen = new Pen(Color.White, 1)) // Set border color and width
                    {
                        e.Graphics.DrawEllipse(pen, bounds);
                    }
                }
            };
        }
        private void ApplyRoundedEdges(Panel panel)
        {
            panel.BackColor = Color.FromArgb(39, 39, 54); // Set background color as required
            panel.BorderStyle = BorderStyle.None; // Remove default border

            // Override OnPaint event to draw rounded edges
            panel.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int cornerRadius = 20; // Adjust the corner radius as required
                    Rectangle bounds = panel.ClientRectangle;
                    int arcSize = cornerRadius * 2;

                    path.AddArc(bounds.X, bounds.Y, arcSize, arcSize, 180, 90);
                    path.AddArc(bounds.Right - arcSize, bounds.Y, arcSize, arcSize, 270, 90);
                    path.AddArc(bounds.Right - arcSize, bounds.Bottom - arcSize, arcSize, arcSize, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - arcSize, arcSize, arcSize, 90, 90);
                    path.CloseAllFigures();

                    panel.Region = new Region(path);

                    using (Pen pen = new Pen(Color.White, 2)) // Adjust border color and width as required
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ModernUI.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ModernUI.ColorList.Count);
            }
            tempIndex = index;
            string color = ModernUI.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with log out
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            // If the user clicks No, the log out action is canceled.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with log out
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void buttonWeatherForecast_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentWeatherForm(), sender);

        }

        private void buttonHazardMaps_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentHazardMapsForm(), sender);

        }

        private void buttonEducationalVideos_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentEducationalVideosForm(), sender);

        }

        private void buttonEvacuationCenter_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentAdminEvacuationCenterForm(), sender);

        }

        private void buttonNewsEvents_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentNewsEventsForm(), sender);

        }

        private void buttonHelpfulTips_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentHelpfulTipsForm(), sender);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            SetRoundedCorners(this, 15);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Normal;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();

        }
        private void SetRoundedCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with log out
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            // If the user clicks No, the log out action is canceled.
        }
    }
}
