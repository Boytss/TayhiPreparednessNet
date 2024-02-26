using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DISASTER_PREPAREDNESS.DataAccess;
namespace DISASTER_PREPAREDNESS
{
    public partial class RegistrationForm : Form
    {

        // Import the necessary Windows API functions
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Define constants for window messages
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public RegistrationForm()
        {
            InitializeComponent();
            SetRoundedCorners(this, 15);


            panel3.MouseDown += panel3_MouseDown;
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
        private void RegisterUser()
        {
            string firstName = firstNameValue.Text;
            string lastName = lastNameValue.Text;
            string purokNumber = purokDropdown.Texts;
            string mobileNumber = mobileNumberVal.Text;
            string username = userNameValue.Text;
            string password = passwordValue.Text;

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(purokNumber) || string.IsNullOrWhiteSpace(mobileNumber) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check password strength
            if (!IsPasswordStrong(password))
            {
                MessageBox.Show("Password does not meet the requirements.\n\n" +
                    "- It must contain at least 8 characters.\n- It must contain at least one uppercase letter.\n- It must contain at least one lowercase letter.\n- It must contain at least one digit.\n- It must contain at least one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Return without attempting registration
            }

            // Call the RegistrationHelper method
            bool registrationSuccess = RegistrationHelper.RegisterUser(firstName, lastName, purokNumber, mobileNumber, username, password);

            if (registrationSuccess)
            {
                MessageBox.Show("Registration successful!");
                // Clear textboxes after successful registration
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                purokDropdown.SelectedIndex = -1; // Assuming purokDropdown is a ComboBox
                mobileNumberVal.Text = "";
                userNameValue.Text = "";
                passwordValue.Text = "";
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }



        // P/Invoke declarations for native functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        private static extern int SetBkColor(IntPtr hdc, int crColor);






        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void passwordValue_TextChanged(object sender, EventArgs e)
        {


        }

        private void showPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }




        private bool IsPasswordStrong(string password)
        {
            bool isLengthValid = password.Length >= 8;
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = Regex.IsMatch(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            return isLengthValid && hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showPassCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPassCheckbox.Checked)
            {
                passwordValue.PasswordChar = false;
            }
            else
            {
                passwordValue.PasswordChar = true;
            }
        }

        private void signUpButton_Click_1(object sender, EventArgs e)
        {
            RegisterUser();

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the registration form when the link label is clicked
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();  // Optionally, hide the current login form
        }

        private void backgroundPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            SetRoundedCorners(this, 15);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
