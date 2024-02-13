 using System;
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
using DISASTER_PREPAREDNESS.AdminForms;
using DISASTER_PREPAREDNESS.DataAccess;
using DISASTER_PREPAREDNESS.Forms;
namespace DISASTER_PREPAREDNESS
{

    public partial class AdminDashboard : Form
    {
        // Define a property to access the panelDesktopPanel
        public Panel PanelDesktopPanel { get { return panelDesktopPanel; } }

        // Other code in the AdminDashboard class...

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
        public AdminDashboard()
        {
            InitializeComponent();
            random = new Random();
            SetRoundedCorners(this, 15);

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
                    //panelTitleBar.BackColor = color;
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
            //labelHome.Text = childForm.Text;
        }



        private void buttonHazardMaps_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminHazardMapsForm(), sender);


        }

        private void buttonEducationalVideos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminEducationalVideosForm(), sender);


        }

        private void buttonEvacuationCenter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminEvacuationCenterForm(), sender);


        }

        private void buttonNewsEvents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminNewsEventsForm(), sender);


        }

        private void buttonHelpfulTips_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminHelpfulTipsForm(), sender);

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

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
            // If the user clicks No, the log out action is canceled.
        }

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmergencyAlert_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmergencyAlertForm(), sender);

        }

        private void buttonManageResidence_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminManageResidenceForm(), sender);

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
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

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttonMini_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
            SetRoundedCorners(this, 15);
        }
    }
}
