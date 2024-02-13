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
        private ComboBox purokDropdown;
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

            SetDefaultTextAndAttachHandlers(firstNameValue, "" + "First Name");
            SetDefaultTextAndAttachHandlers(lastNameValue, "" + "Last Name");
            SetDefaultTextAndAttachHandlers(mobileNumberValue, "" + "Mobile Number");
            SetDefaultTextAndAttachHandlers(userNameValue, "" + "Username");
            SetDefaultTextAndAttachHandlers(passwordValue, "" + "Password");
            // Create a ComboBox
            ComboBox comboBox1 = new ComboBox();
            purokDropdwon.Items.Add("Purok 1");
            purokDropdwon.Items.Add("Purok 2");
            purokDropdwon.Items.Add("Purok 3");
            purokDropdwon.Items.Add("Purok 4");
            purokDropdwon.Items.Add("Purok 5");
            purokDropdwon.Items.Add("Purok 6");


            // Set ComboBox properties
            purokDropdwon.DrawMode = DrawMode.OwnerDrawFixed; // Enable owner-drawn mode
            purokDropdwon.DropDownStyle = ComboBoxStyle.DropDownList;
            purokDropdwon.FlatStyle = FlatStyle.Flat;
            purokDropdwon.BackColor = SystemColors.ButtonFace; // Match the form's background color
            purokDropdwon.ForeColor = SystemColors.GrayText; // Set text color

            purokDropdwon.DrawItem += PurokDropdown_DrawItem;
            purokDropdwon.DropDown += PurokDropdown_DropDown;

            // Add the ComboBox to the form
            this.Controls.Add(comboBox1);



            SetRoundedButton(signUpButton);
            panel3.MouseDown += panel3_MouseDown;
        }
        private void RegisterUser()
        {
            string firstName = firstNameValue.Text;
            string lastName = lastNameValue.Text;
            string purokNumber = purokDropdwon.Text;
            string mobileNumber = mobileNumberValue.Text;
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
                MessageBox.Show("Password does not meet the requirements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                purokDropdwon.SelectedIndex = -1; // Assuming purokDropdwon is a ComboBox
                mobileNumberValue.Text = "";
                userNameValue.Text = "";
                passwordValue.Text = "";
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }
        private void SetRoundedButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            signUpButton.Size = new Size(143, 40); // Adjust the width and height as needed

            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Adjust the radius to control the roundness
            Rectangle rectangle = button.ClientRectangle;
            path.AddArc(rectangle.Left, rectangle.Top, radius * 2, radius * 2, 180, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Top, radius * 2, radius * 2, 270, 90);
            path.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rectangle.Left, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            button.Region = new Region(path);
        }
        private void PurokDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                ComboBox comboBox = (ComboBox)sender;
                Graphics g = e.Graphics;
                Rectangle rect = e.Bounds;

                // Check if the item is selected
                bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

                // Draw background
                Color backgroundColor = isSelected ? SystemColors.Highlight : comboBox.BackColor;
                using (SolidBrush brush = new SolidBrush(backgroundColor))
                {
                    g.FillRectangle(brush, rect);
                }

                // Draw text
                Color textColor = isSelected ? SystemColors.WindowText : comboBox.ForeColor;
                using (SolidBrush brush = new SolidBrush(textColor))
                {
                    g.DrawString(comboBox.Items[e.Index].ToString(), comboBox.Font, brush, rect.X, rect.Y);
                }

                // Draw focus rectangle
                e.DrawFocusRectangle();
            }
        }

        private void PurokDropdown_DropDown(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.SelectedIndexChanged += PurokDropdown_SelectedIndexChanged;

            // Set the dropdown background color to match the form's background
            IntPtr hwnd = (IntPtr)comboBox.Handle;
            IntPtr hdc = GetWindowDC(hwnd);
            SetBkColor(hdc, ColorTranslator.ToWin32(this.BackColor));
            ReleaseDC(hwnd, hdc);
        }
        private void PurokDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Set the text color to SystemColors.WindowText when an item is selected
            comboBox.ForeColor = SystemColors.WindowText;
        }
        // Remove the event handler when the DropDown is closed
        private void PurokDropdown_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.SelectedIndexChanged -= PurokDropdown_SelectedIndexChanged;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set the initial selected item
            purokDropdwon.SelectedIndex = 0;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            // Clear the ComboBox text when the form is clicked
            purokDropdwon.Text = "";
        }

        // P/Invoke declarations for native functions
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        private static extern int SetBkColor(IntPtr hdc, int crColor);

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
            if (showPassCheckbox.Checked)
            {
                passwordValue.UseSystemPasswordChar = true;
            }
            else
            {
                passwordValue.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the registration form when the link label is clicked
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();  // Optionally, hide the current login form
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            RegisterUser();


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
    }
}
