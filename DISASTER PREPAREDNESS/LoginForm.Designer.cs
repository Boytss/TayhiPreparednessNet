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
            showpass = new CheckBox();
            panel6 = new Panel();
            panel5 = new Panel();
            passwordValue = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            loginButton = new Button();
            flowLayoutPanel15 = new FlowLayoutPanel();
            flowLayoutPanel16 = new FlowLayoutPanel();
            textBox13 = new TextBox();
            flowLayoutPanel17 = new FlowLayoutPanel();
            flowLayoutPanel18 = new FlowLayoutPanel();
            textBox15 = new TextBox();
            flowLayoutPanel19 = new FlowLayoutPanel();
            flowLayoutPanel20 = new FlowLayoutPanel();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            userNameValue = new TextBox();
            panel3 = new Panel();
            minimizeButton = new Button();
            maximizeButton = new Button();
            closeButton = new Button();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel15.SuspendLayout();
            flowLayoutPanel17.SuspendLayout();
            flowLayoutPanel19.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(showpass);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(passwordValue);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(flowLayoutPanel15);
            panel1.Controls.Add(flowLayoutPanel17);
            panel1.Controls.Add(userNameValue);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 452);
            panel1.TabIndex = 1;
            // 
            // showpass
            // 
            showpass.AutoSize = true;
            showpass.Location = new Point(292, 204);
            showpass.Name = "showpass";
            showpass.Size = new Size(15, 14);
            showpass.TabIndex = 25;
            showpass.UseVisualStyleBackColor = true;
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(44, 197);
            panel6.Name = "panel6";
            panel6.Size = new Size(20, 20);
            panel6.TabIndex = 24;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(44, 155);
            panel5.Name = "panel5";
            panel5.Size = new Size(20, 20);
            panel5.TabIndex = 23;
            // 
            // passwordValue
            // 
            passwordValue.BackColor = SystemColors.Control;
            passwordValue.BorderStyle = BorderStyle.None;
            passwordValue.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordValue.Location = new Point(62, 199);
            passwordValue.Multiline = true;
            passwordValue.Name = "passwordValue";
            passwordValue.PasswordChar = '•';
            passwordValue.Size = new Size(224, 20);
            passwordValue.TabIndex = 21;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(80, 243);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 16);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Didn't have an account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(56, 170, 147);
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(191, 27);
            label1.TabIndex = 16;
            label1.Text = "Welcome back!";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(56, 170, 147);
            loginButton.Font = new Font("Verdana", 11.25F);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(96, 303);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(143, 40);
            loginButton.TabIndex = 15;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // flowLayoutPanel15
            // 
            flowLayoutPanel15.BackColor = Color.FromArgb(56, 170, 147);
            flowLayoutPanel15.Controls.Add(flowLayoutPanel16);
            flowLayoutPanel15.Controls.Add(textBox13);
            flowLayoutPanel15.Location = new Point(44, 219);
            flowLayoutPanel15.Name = "flowLayoutPanel15";
            flowLayoutPanel15.Size = new Size(242, 1);
            flowLayoutPanel15.TabIndex = 13;
            // 
            // flowLayoutPanel16
            // 
            flowLayoutPanel16.BackColor = Color.FromArgb(56, 170, 147);
            flowLayoutPanel16.Location = new Point(3, 3);
            flowLayoutPanel16.Name = "flowLayoutPanel16";
            flowLayoutPanel16.Size = new Size(189, 1);
            flowLayoutPanel16.TabIndex = 7;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox13.Location = new Point(3, 10);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(189, 20);
            textBox13.TabIndex = 6;
            // 
            // flowLayoutPanel17
            // 
            flowLayoutPanel17.BackColor = Color.FromArgb(56, 170, 147);
            flowLayoutPanel17.Controls.Add(flowLayoutPanel18);
            flowLayoutPanel17.Controls.Add(textBox15);
            flowLayoutPanel17.Controls.Add(flowLayoutPanel19);
            flowLayoutPanel17.Controls.Add(textBox17);
            flowLayoutPanel17.Location = new Point(44, 177);
            flowLayoutPanel17.Name = "flowLayoutPanel17";
            flowLayoutPanel17.Size = new Size(242, 1);
            flowLayoutPanel17.TabIndex = 11;
            // 
            // flowLayoutPanel18
            // 
            flowLayoutPanel18.BackColor = Color.FromArgb(56, 170, 147);
            flowLayoutPanel18.Location = new Point(3, 3);
            flowLayoutPanel18.Name = "flowLayoutPanel18";
            flowLayoutPanel18.Size = new Size(189, 1);
            flowLayoutPanel18.TabIndex = 7;
            // 
            // textBox15
            // 
            textBox15.BackColor = Color.White;
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox15.Location = new Point(3, 10);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(189, 20);
            textBox15.TabIndex = 6;
            // 
            // flowLayoutPanel19
            // 
            flowLayoutPanel19.BackColor = Color.FromArgb(56, 170, 147);
            flowLayoutPanel19.Controls.Add(flowLayoutPanel20);
            flowLayoutPanel19.Controls.Add(textBox16);
            flowLayoutPanel19.Location = new Point(3, 36);
            flowLayoutPanel19.Name = "flowLayoutPanel19";
            flowLayoutPanel19.Size = new Size(189, 1);
            flowLayoutPanel19.TabIndex = 9;
            // 
            // flowLayoutPanel20
            // 
            flowLayoutPanel20.BackColor = Color.FromArgb(56, 170, 147);
            flowLayoutPanel20.Location = new Point(3, 3);
            flowLayoutPanel20.Name = "flowLayoutPanel20";
            flowLayoutPanel20.Size = new Size(189, 1);
            flowLayoutPanel20.TabIndex = 7;
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.White;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox16.Location = new Point(3, 10);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(189, 20);
            textBox16.TabIndex = 6;
            // 
            // textBox17
            // 
            textBox17.BackColor = Color.White;
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox17.Location = new Point(3, 43);
            textBox17.Multiline = true;
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(189, 20);
            textBox17.TabIndex = 8;
            // 
            // userNameValue
            // 
            userNameValue.BackColor = SystemColors.Control;
            userNameValue.BorderStyle = BorderStyle.None;
            userNameValue.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameValue.Location = new Point(62, 157);
            userNameValue.Multiline = true;
            userNameValue.Name = "userNameValue";
            userNameValue.Size = new Size(242, 20);
            userNameValue.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(minimizeButton);
            panel3.Controls.Add(maximizeButton);
            panel3.Controls.Add(closeButton);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(341, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 452);
            panel3.TabIndex = 2;
            panel3.MouseDown += panel3_MouseDown_1;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.FromArgb(65, 114, 107);
            minimizeButton.BackgroundImage = (Image)resources.GetObject("minimizeButton.BackgroundImage");
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.ForeColor = SystemColors.ControlLight;
            minimizeButton.Location = new Point(313, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(22, 22);
            minimizeButton.TabIndex = 24;
            minimizeButton.UseVisualStyleBackColor = false;
            // 
            // maximizeButton
            // 
            maximizeButton.BackColor = Color.FromArgb(65, 114, 107);
            maximizeButton.BackgroundImage = (Image)resources.GetObject("maximizeButton.BackgroundImage");
            maximizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.ForeColor = SystemColors.ControlLight;
            maximizeButton.Location = new Point(334, 0);
            maximizeButton.Name = "maximizeButton";
            maximizeButton.Size = new Size(22, 22);
            maximizeButton.TabIndex = 23;
            maximizeButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(65, 114, 107);
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = SystemColors.Control;
            closeButton.Location = new Point(355, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(22, 22);
            closeButton.TabIndex = 22;
            closeButton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(65, 114, 107);
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(289, 379);
            panel4.Name = "panel4";
            panel4.Size = new Size(76, 73);
            panel4.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 64, 59);
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 191);
            label4.Name = "label4";
            label4.Size = new Size(219, 16);
            label4.TabIndex = 20;
            label4.Text = "Sign in to access your account.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 64, 59);
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 155);
            label3.Name = "label3";
            label3.Size = new Size(226, 29);
            label3.TabIndex = 19;
            label3.Text = "Hello, Resident!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 64, 59);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(35, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 124);
            panel2.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 452);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel15.ResumeLayout(false);
            flowLayoutPanel15.PerformLayout();
            flowLayoutPanel17.ResumeLayout(false);
            flowLayoutPanel17.PerformLayout();
            flowLayoutPanel19.ResumeLayout(false);
            flowLayoutPanel19.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox passwordValue;
        private LinkLabel linkLabel1;
        private Label label1;
        private Button loginButton;
        private FlowLayoutPanel flowLayoutPanel15;
        private FlowLayoutPanel flowLayoutPanel16;
        private TextBox textBox13;
        private FlowLayoutPanel flowLayoutPanel17;
        private FlowLayoutPanel flowLayoutPanel18;
        private TextBox textBox15;
        private FlowLayoutPanel flowLayoutPanel19;
        private FlowLayoutPanel flowLayoutPanel20;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox userNameValue;
        private Panel panel3;
        private Button minimizeButton;
        private Button maximizeButton;
        private Button closeButton;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private CheckBox showpass;
    }
}