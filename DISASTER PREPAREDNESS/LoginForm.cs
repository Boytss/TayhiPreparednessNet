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
using System.Windows.Forms.VisualStyles;
using DISASTER_PREPAREDNESS.DataAccess;
namespace DISASTER_PREPAREDNESS
{
    public partial class LoginForm : Form
    {
        // Import the necessary Windows API functions
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Define constants for window messages
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public LoginForm()
        {
            InitializeComponent();


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

        private void LoginUser()
        {
            string username = userNameValue.Text;
            string password = passwordValue.Text;

            // Call the AuthenticateUser method from LoginHelper
            bool authenticationSuccess = LoginHelper.AuthenticateUser(username, password);

            if (authenticationSuccess)
            {
                if (username.ToLower() == "admin" && password == "admin")
                {
                    MessageBox.Show("Admin login successful! Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to the AdminDashboard
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();

                    // Optionally, hide the current login form
                    this.Hide();
                }
                else
                {
                    if (username == null && password == null)
                    {
                        MessageBox.Show("Invalid input fields");
                    }
                    else
                    {
                        MessageBox.Show("Login successful! Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to the ResidentDashboard
                        ResidentDashboard residentDashboard = new ResidentDashboard(username);
                        residentDashboard.Show();

                        // Optionally, hide the current login form
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
        }

        private void showpass_CheckedChanged_2(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                passwordValue.PasswordChar = false;
            }
            else
            {
                passwordValue.PasswordChar = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the registration form when the link label is clicked
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();  // Optionally, hide the current login form
        }
    }
}
