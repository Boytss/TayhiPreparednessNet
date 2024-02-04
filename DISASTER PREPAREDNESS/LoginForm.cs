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
            SetDefaultTextAndAttachHandlers(userNameValue, "" + "Username");
            SetDefaultTextAndAttachHandlers(passwordValue, "" + "Password");


            SetRoundedButton(loginButton);
            minimizeButton.Click += minimizeButton_Click;
            maximizeButton.Click += maximizeButton_Click;
            closeButton.Click += closeButton_Click;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginUser();
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
                    MessageBox.Show("Login successful! Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to the ResidentDashboard
                    ResidentDashboard residentDashboard = new ResidentDashboard();
                    residentDashboard.Show();

                    // Optionally, hide the current login form
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }


        // P/Invoke declarations for native functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        private static extern int SetBkColor(IntPtr hdc, int crColor);
        private void SetRoundedButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            loginButton.Size = new Size(143, 40); // Adjust the width and height as needed

            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Adjust the radius to control the roundness
            Rectangle rectangle = button.ClientRectangle;
            path.AddArc(rectangle.Left, rectangle.Top, radius * 2, radius * 2, 180, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Top, radius * 2, radius * 2, 270, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rectangle.Left, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            button.Region = new Region(path);
        }
        private void SetDefaultTextAndAttachHandlers(TextBox textBox, string defaultText)
        {

            textBox.Text = defaultText;
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.TextAlign = HorizontalAlignment.Left;

            // Set the UseSystemPasswordChar property for the password TextBox
            if (textBox.Name == "passwordValue")
            {
                textBox.UseSystemPasswordChar = true;
            }

            textBox.GotFocus += (sender, e) => TextBox_GotFocus(textBox, defaultText);
            textBox.LostFocus += (sender, e) => TextBox_LostFocus(textBox, defaultText);
            textBox.TextChanged += (sender, e) => TextBox_TextChanged(textBox, defaultText);
        }
        private void TextBox_TextChanged(TextBox textBox, string defaultText)
        {
            // If text is being typed in the password TextBox, change the font color and show actual characters
            if (textBox.Name == "passwordValue" && textBox.Text != defaultText)
            {
                textBox.ForeColor = SystemColors.WindowText;
                textBox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox_GotFocus(TextBox textBox, string defaultText)
        {
            // Change font color when the TextBox receives focus
            if (textBox.Text == defaultText)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText; // Set to default text color

            }
        }

        private void TextBox_LostFocus(TextBox textBox, string defaultText)
        {

            // Restore default text and font color if the TextBox is empty
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = defaultText;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximize button clicked"); // Add this line for debugging
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the registration form when the link label is clicked
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();  // Optionally, hide the current login form
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                passwordValue.UseSystemPasswordChar = true;
            }
            else
            {
                passwordValue.UseSystemPasswordChar = false;
            }
        }

       
    }
}
