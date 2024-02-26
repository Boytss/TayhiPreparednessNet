namespace DISASTER_PREPAREDNESS
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel5 = new Panel();
            label2 = new Label();
            loginButton = new MyControls.MyButton();
            passwordValue = new MyControls.MyTextBox();
            userNameValue = new MyControls.MyTextBox();
            showpass = new CheckBox();
            panel6 = new Panel();
            panel7 = new Panel();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 20);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(5, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 51, 76);
            label1.Location = new Point(26, 2);
            label1.Name = "label1";
            label1.Size = new Size(407, 15);
            label1.TabIndex = 16;
            label1.Text = "DISASTER PREPAREDNESS SYSTEM OF BARANGAY TAYHI, TABACO";
            // 
            // button4
            // 
            button4.Dock = DockStyle.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(674, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(20, 20);
            button4.TabIndex = 15;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(694, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 14;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(714, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(20, 20);
            button3.TabIndex = 13;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(141, 163, 160);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(loginButton);
            panel5.Controls.Add(passwordValue);
            panel5.Controls.Add(userNameValue);
            panel5.Controls.Add(showpass);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(linkLabel1);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(373, 471);
            panel5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 64, 59);
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 41);
            label2.Name = "label2";
            label2.Size = new Size(217, 29);
            label2.TabIndex = 29;
            label2.Text = "Welcome Back!";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(141, 163, 160);
            loginButton.BackgroundColor = Color.FromArgb(141, 163, 160);
            loginButton.BorderColor = Color.FromArgb(52, 93, 88);
            loginButton.BorderRadius = 20;
            loginButton.BorderSize = 2;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            loginButton.FlatAppearance.MouseOverBackColor = Color.Cyan;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(114, 289);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 40);
            loginButton.TabIndex = 28;
            loginButton.Text = "Login";
            loginButton.TextColor = Color.Black;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordValue
            // 
            passwordValue.BackColor = Color.FromArgb(141, 163, 160);
            passwordValue.BorderColor = Color.FromArgb(52, 93, 88);
            passwordValue.BorderFocusColor = Color.Cyan;
            passwordValue.BorderRadius = 0;
            passwordValue.BorderSize = 2;
            passwordValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            passwordValue.ForeColor = Color.White;
            passwordValue.Location = new Point(85, 171);
            passwordValue.Margin = new Padding(4);
            passwordValue.Multiline = false;
            passwordValue.Name = "passwordValue";
            passwordValue.Padding = new Padding(7);
            passwordValue.PasswordChar = true;
            passwordValue.PlaceholderColor = Color.FromArgb(209, 209, 209);
            passwordValue.PlaceholderText = "Password";
            passwordValue.Size = new Size(217, 36);
            passwordValue.TabIndex = 27;
            passwordValue.UnderlinedStyle = true;
            // 
            // userNameValue
            // 
            userNameValue.BackColor = Color.FromArgb(141, 163, 160);
            userNameValue.BorderColor = Color.FromArgb(52, 93, 88);
            userNameValue.BorderFocusColor = Color.Cyan;
            userNameValue.BorderRadius = 0;
            userNameValue.BorderSize = 2;
            userNameValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            userNameValue.ForeColor = Color.White;
            userNameValue.Location = new Point(85, 130);
            userNameValue.Margin = new Padding(4);
            userNameValue.Multiline = false;
            userNameValue.Name = "userNameValue";
            userNameValue.Padding = new Padding(7);
            userNameValue.PasswordChar = false;
            userNameValue.PlaceholderColor = Color.FromArgb(209, 209, 209);
            userNameValue.PlaceholderText = "Username";
            userNameValue.Size = new Size(217, 36);
            userNameValue.TabIndex = 26;
            userNameValue.UnderlinedStyle = true;
            // 
            // showpass
            // 
            showpass.AutoSize = true;
            showpass.BackColor = Color.Transparent;
            showpass.Location = new Point(308, 194);
            showpass.Name = "showpass";
            showpass.Size = new Size(15, 14);
            showpass.TabIndex = 25;
            showpass.UseVisualStyleBackColor = false;
            showpass.CheckedChanged += showpass_CheckedChanged_2;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(60, 187);
            panel6.Name = "panel6";
            panel6.Size = new Size(20, 20);
            panel6.TabIndex = 24;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(60, 145);
            panel7.Name = "panel7";
            panel7.Size = new Size(20, 20);
            panel7.TabIndex = 23;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(28, 56, 52);
            linkLabel1.Location = new Point(96, 233);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 16);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Didn't have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(373, 20);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 471);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(285, 395);
            panel4.Name = "panel4";
            panel4.Size = new Size(76, 73);
            panel4.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 64, 59);
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 210);
            label4.Name = "label4";
            label4.Size = new Size(219, 16);
            label4.TabIndex = 20;
            label4.Text = "Sign in to access your account.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 64, 59);
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 174);
            label3.Name = "label3";
            label3.Size = new Size(226, 29);
            label3.TabIndex = 19;
            label3.Text = "Hello, Resident!";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(128, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 124);
            panel2.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 491);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label2;
        private MyControls.MyButton loginButton;
        private MyControls.MyTextBox passwordValue;
        private MyControls.MyTextBox userNameValue;
        private CheckBox showpass;
        private Panel panel6;
        private Panel panel7;
        private LinkLabel linkLabel1;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Panel panel2;
    }
}