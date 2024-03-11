namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class AdminManageResidenceForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageResidenceForm));
            gradientPanel1 = new GradientPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            clearButton = new MyControls.MyButton();
            dataGridViewResidents = new DataGridView();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            searchByPurokDropdown = new MyControls.MyComboBox();
            label9 = new Label();
            searchNameTextbox = new MyControls.MyTextBox();
            panel3 = new Panel();
            panel1 = new Panel();
            editButton = new MyControls.MyButton();
            addnewButton = new MyControls.MyButton();
            deleteButton = new MyControls.MyButton();
            tabPage2 = new TabPage();
            passwordTextbox = new MyControls.MyTextBox();
            label7 = new Label();
            usernameTextbox = new MyControls.MyTextBox();
            label6 = new Label();
            labelDetails = new Label();
            residentFirstNameTextbox = new MyControls.MyTextBox();
            cancelButton = new MyControls.MyButton();
            saveButton = new MyControls.MyButton();
            residentMobileNumberTextbox = new MyControls.MyTextBox();
            label5 = new Label();
            residentPurokNumberTextbox = new MyControls.MyTextBox();
            label4 = new Label();
            residentLastnameTextbox = new MyControls.MyTextBox();
            label3 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            label12 = new Label();
            gradientPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.ColorBottom = Color.LightGray;
            gradientPanel1.ColorTop = Color.White;
            gradientPanel1.Controls.Add(tabControl1);
            gradientPanel1.Controls.Add(panel2);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(928, 695);
            gradientPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 84);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(928, 611);
            tabControl1.TabIndex = 37;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(190, 196, 228);
            tabPage1.Controls.Add(clearButton);
            tabPage1.Controls.Add(dataGridViewResidents);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(920, 583);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Resident List";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.MediumSlateBlue;
            clearButton.BackgroundColor = Color.MediumSlateBlue;
            clearButton.BorderColor = Color.PaleVioletRed;
            clearButton.BorderRadius = 15;
            clearButton.BorderSize = 0;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(675, 373);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 35);
            clearButton.TabIndex = 52;
            clearButton.Text = "Clear Selection";
            clearButton.TextColor = Color.White;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // dataGridViewResidents
            // 
            dataGridViewResidents.AllowUserToDeleteRows = false;
            dataGridViewResidents.AllowUserToResizeColumns = false;
            dataGridViewResidents.AllowUserToResizeRows = false;
            dataGridViewResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewResidents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewResidents.BackgroundColor = Color.FromArgb(223, 228, 231);
            dataGridViewResidents.BorderStyle = BorderStyle.None;
            dataGridViewResidents.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewResidents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 218, 232);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewResidents.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(223, 228, 231);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewResidents.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewResidents.Dock = DockStyle.Top;
            dataGridViewResidents.EnableHeadersVisualStyles = false;
            dataGridViewResidents.Location = new Point(25, 141);
            dataGridViewResidents.Name = "dataGridViewResidents";
            dataGridViewResidents.RowHeadersVisible = false;
            dataGridViewResidents.RowHeadersWidth = 40;
            dataGridViewResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResidents.Size = new Size(767, 226);
            dataGridViewResidents.TabIndex = 51;
            dataGridViewResidents.SelectionChanged += dataGridViewResidents_SelectionChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(searchByPurokDropdown);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(searchNameTextbox);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(25, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(767, 138);
            panel4.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(347, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 23);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 37);
            label10.Name = "label10";
            label10.Size = new Size(135, 21);
            label10.TabIndex = 8;
            label10.Text = "Of Barangay Tayhi";
            // 
            // searchByPurokDropdown
            // 
            searchByPurokDropdown.Anchor = AnchorStyles.Right;
            searchByPurokDropdown.BackColor = Color.FromArgb(190, 196, 228);
            searchByPurokDropdown.BorderColor = Color.MediumSlateBlue;
            searchByPurokDropdown.BorderSize = 2;
            searchByPurokDropdown.DropDownStyle = ComboBoxStyle.DropDown;
            searchByPurokDropdown.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchByPurokDropdown.ForeColor = Color.Gray;
            searchByPurokDropdown.IconColor = Color.MediumSlateBlue;
            searchByPurokDropdown.Items.AddRange(new object[] { "Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6" });
            searchByPurokDropdown.ListBackColor = Color.White;
            searchByPurokDropdown.ListTextColor = Color.Black;
            searchByPurokDropdown.Location = new Point(550, 99);
            searchByPurokDropdown.MinimumSize = new Size(200, 30);
            searchByPurokDropdown.Name = "searchByPurokDropdown";
            searchByPurokDropdown.Padding = new Padding(2);
            searchByPurokDropdown.Size = new Size(211, 33);
            searchByPurokDropdown.TabIndex = 7;
            searchByPurokDropdown.Texts = "Search by purok";
            searchByPurokDropdown.OnSelectedIndexChanged += myComboBox1_OnSelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(180, 37);
            label9.TabIndex = 6;
            label9.Text = "Resident List";
            // 
            // searchNameTextbox
            // 
            searchNameTextbox.BackColor = Color.FromArgb(190, 196, 228);
            searchNameTextbox.BorderColor = Color.MediumSlateBlue;
            searchNameTextbox.BorderFocusColor = Color.Blue;
            searchNameTextbox.BorderRadius = 15;
            searchNameTextbox.BorderSize = 2;
            searchNameTextbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchNameTextbox.ForeColor = Color.Black;
            searchNameTextbox.Location = new Point(6, 99);
            searchNameTextbox.Margin = new Padding(4);
            searchNameTextbox.Multiline = false;
            searchNameTextbox.Name = "searchNameTextbox";
            searchNameTextbox.Padding = new Padding(7);
            searchNameTextbox.PasswordChar = false;
            searchNameTextbox.PlaceholderColor = Color.Gray;
            searchNameTextbox.PlaceholderText = "Search by Name";
            searchNameTextbox.Size = new Size(380, 35);
            searchNameTextbox.TabIndex = 4;
            searchNameTextbox.UnderlinedStyle = false;
            searchNameTextbox.TextChanged += searchNameTextbox_TextChanged;
            searchNameTextbox.KeyDown += searchNameTextbox_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(190, 196, 228);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(22, 577);
            panel3.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(addnewButton);
            panel1.Controls.Add(deleteButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(792, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 577);
            panel1.TabIndex = 46;
            panel1.Paint += panel1_Paint;
            // 
            // editButton
            // 
            editButton.BackColor = Color.MediumSlateBlue;
            editButton.BackgroundColor = Color.MediumSlateBlue;
            editButton.BorderColor = Color.PaleVioletRed;
            editButton.BorderRadius = 15;
            editButton.BorderSize = 0;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(13, 206);
            editButton.Name = "editButton";
            editButton.Size = new Size(88, 35);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.TextColor = Color.White;
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addnewButton
            // 
            addnewButton.BackColor = Color.MediumSlateBlue;
            addnewButton.BackgroundColor = Color.MediumSlateBlue;
            addnewButton.BorderColor = Color.PaleVioletRed;
            addnewButton.BorderRadius = 15;
            addnewButton.BorderSize = 0;
            addnewButton.FlatAppearance.BorderSize = 0;
            addnewButton.FlatStyle = FlatStyle.Flat;
            addnewButton.ForeColor = Color.White;
            addnewButton.Location = new Point(13, 138);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(88, 35);
            addnewButton.TabIndex = 6;
            addnewButton.Text = "Add new";
            addnewButton.TextColor = Color.White;
            addnewButton.UseVisualStyleBackColor = false;
            addnewButton.Click += addnewButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.MediumSlateBlue;
            deleteButton.BackgroundColor = Color.MediumSlateBlue;
            deleteButton.BorderColor = Color.PaleVioletRed;
            deleteButton.BorderRadius = 15;
            deleteButton.BorderSize = 0;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(13, 272);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 35);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.TextColor = Color.White;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(190, 196, 228);
            tabPage2.Controls.Add(passwordTextbox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(usernameTextbox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(labelDetails);
            tabPage2.Controls.Add(residentFirstNameTextbox);
            tabPage2.Controls.Add(cancelButton);
            tabPage2.Controls.Add(saveButton);
            tabPage2.Controls.Add(residentMobileNumberTextbox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(residentPurokNumberTextbox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(residentLastnameTextbox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(920, 583);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Resident Details";
            tabPage2.Click += tabPage2_Click;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Anchor = AnchorStyles.None;
            passwordTextbox.BackColor = Color.FromArgb(190, 196, 228);
            passwordTextbox.BorderColor = Color.MediumSlateBlue;
            passwordTextbox.BorderFocusColor = Color.Blue;
            passwordTextbox.BorderRadius = 0;
            passwordTextbox.BorderSize = 1;
            passwordTextbox.Font = new Font("Segoe UI", 11.25F);
            passwordTextbox.ForeColor = Color.Black;
            passwordTextbox.Location = new Point(470, 289);
            passwordTextbox.Margin = new Padding(4);
            passwordTextbox.Multiline = false;
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Padding = new Padding(7);
            passwordTextbox.PasswordChar = false;
            passwordTextbox.PlaceholderColor = Color.DarkGray;
            passwordTextbox.PlaceholderText = "";
            passwordTextbox.Size = new Size(195, 35);
            passwordTextbox.TabIndex = 5;
            passwordTextbox.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(467, 270);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 24;
            label7.Text = "Resident Password";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Anchor = AnchorStyles.None;
            usernameTextbox.BackColor = Color.FromArgb(190, 196, 228);
            usernameTextbox.BorderColor = Color.MediumSlateBlue;
            usernameTextbox.BorderFocusColor = Color.Blue;
            usernameTextbox.BorderRadius = 0;
            usernameTextbox.BorderSize = 1;
            usernameTextbox.Font = new Font("Segoe UI", 11.25F);
            usernameTextbox.ForeColor = Color.Black;
            usernameTextbox.Location = new Point(257, 289);
            usernameTextbox.Margin = new Padding(4);
            usernameTextbox.Multiline = false;
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Padding = new Padding(7);
            usernameTextbox.PasswordChar = false;
            usernameTextbox.PlaceholderColor = Color.DarkGray;
            usernameTextbox.PlaceholderText = "";
            usernameTextbox.Size = new Size(195, 35);
            usernameTextbox.TabIndex = 4;
            usernameTextbox.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(254, 270);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 22;
            label6.Text = "Resident Username";
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDetails.Location = new Point(21, 13);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(224, 37);
            labelDetails.TabIndex = 21;
            labelDetails.Text = "Resident Details";
            // 
            // residentFirstNameTextbox
            // 
            residentFirstNameTextbox.Anchor = AnchorStyles.None;
            residentFirstNameTextbox.BackColor = Color.FromArgb(190, 196, 228);
            residentFirstNameTextbox.BorderColor = Color.MediumSlateBlue;
            residentFirstNameTextbox.BorderFocusColor = Color.Blue;
            residentFirstNameTextbox.BorderRadius = 0;
            residentFirstNameTextbox.BorderSize = 1;
            residentFirstNameTextbox.Font = new Font("Segoe UI", 11.25F);
            residentFirstNameTextbox.ForeColor = Color.Black;
            residentFirstNameTextbox.Location = new Point(260, 150);
            residentFirstNameTextbox.Margin = new Padding(4);
            residentFirstNameTextbox.Multiline = false;
            residentFirstNameTextbox.Name = "residentFirstNameTextbox";
            residentFirstNameTextbox.Padding = new Padding(7);
            residentFirstNameTextbox.PasswordChar = false;
            residentFirstNameTextbox.PlaceholderColor = Color.DarkGray;
            residentFirstNameTextbox.PlaceholderText = "";
            residentFirstNameTextbox.Size = new Size(195, 35);
            residentFirstNameTextbox.TabIndex = 0;
            residentFirstNameTextbox.UnderlinedStyle = true;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.BackColor = Color.MediumSlateBlue;
            cancelButton.BackgroundColor = Color.MediumSlateBlue;
            cancelButton.BorderColor = Color.PaleVioletRed;
            cancelButton.BorderRadius = 20;
            cancelButton.BorderSize = 0;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(470, 382);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 40);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.BackColor = Color.MediumSlateBlue;
            saveButton.BackgroundColor = Color.MediumSlateBlue;
            saveButton.BorderColor = Color.PaleVioletRed;
            saveButton.BorderRadius = 20;
            saveButton.BorderSize = 0;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(276, 382);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 40);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.TextColor = Color.White;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // residentMobileNumberTextbox
            // 
            residentMobileNumberTextbox.Anchor = AnchorStyles.None;
            residentMobileNumberTextbox.BackColor = Color.FromArgb(190, 196, 228);
            residentMobileNumberTextbox.BorderColor = Color.MediumSlateBlue;
            residentMobileNumberTextbox.BorderFocusColor = Color.Blue;
            residentMobileNumberTextbox.BorderRadius = 0;
            residentMobileNumberTextbox.BorderSize = 1;
            residentMobileNumberTextbox.Font = new Font("Segoe UI", 11.25F);
            residentMobileNumberTextbox.ForeColor = Color.Black;
            residentMobileNumberTextbox.Location = new Point(470, 220);
            residentMobileNumberTextbox.Margin = new Padding(4);
            residentMobileNumberTextbox.Multiline = false;
            residentMobileNumberTextbox.Name = "residentMobileNumberTextbox";
            residentMobileNumberTextbox.Padding = new Padding(7);
            residentMobileNumberTextbox.PasswordChar = false;
            residentMobileNumberTextbox.PlaceholderColor = Color.DarkGray;
            residentMobileNumberTextbox.PlaceholderText = "";
            residentMobileNumberTextbox.Size = new Size(195, 35);
            residentMobileNumberTextbox.TabIndex = 3;
            residentMobileNumberTextbox.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(467, 201);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 8;
            label5.Text = "Resident Mobile Number";
            // 
            // residentPurokNumberTextbox
            // 
            residentPurokNumberTextbox.Anchor = AnchorStyles.None;
            residentPurokNumberTextbox.BackColor = Color.FromArgb(190, 196, 228);
            residentPurokNumberTextbox.BorderColor = Color.MediumSlateBlue;
            residentPurokNumberTextbox.BorderFocusColor = Color.Blue;
            residentPurokNumberTextbox.BorderRadius = 0;
            residentPurokNumberTextbox.BorderSize = 1;
            residentPurokNumberTextbox.Font = new Font("Segoe UI", 11.25F);
            residentPurokNumberTextbox.ForeColor = Color.Black;
            residentPurokNumberTextbox.Location = new Point(260, 220);
            residentPurokNumberTextbox.Margin = new Padding(4);
            residentPurokNumberTextbox.Multiline = false;
            residentPurokNumberTextbox.Name = "residentPurokNumberTextbox";
            residentPurokNumberTextbox.Padding = new Padding(7);
            residentPurokNumberTextbox.PasswordChar = false;
            residentPurokNumberTextbox.PlaceholderColor = Color.DarkGray;
            residentPurokNumberTextbox.PlaceholderText = "";
            residentPurokNumberTextbox.Size = new Size(195, 35);
            residentPurokNumberTextbox.TabIndex = 2;
            residentPurokNumberTextbox.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(257, 201);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 6;
            label4.Text = "Resident Purok Number";
            // 
            // residentLastnameTextbox
            // 
            residentLastnameTextbox.Anchor = AnchorStyles.None;
            residentLastnameTextbox.BackColor = Color.FromArgb(190, 196, 228);
            residentLastnameTextbox.BorderColor = Color.MediumSlateBlue;
            residentLastnameTextbox.BorderFocusColor = Color.Blue;
            residentLastnameTextbox.BorderRadius = 0;
            residentLastnameTextbox.BorderSize = 1;
            residentLastnameTextbox.Font = new Font("Segoe UI", 11.25F);
            residentLastnameTextbox.ForeColor = Color.Black;
            residentLastnameTextbox.Location = new Point(467, 150);
            residentLastnameTextbox.Margin = new Padding(4);
            residentLastnameTextbox.Multiline = false;
            residentLastnameTextbox.Name = "residentLastnameTextbox";
            residentLastnameTextbox.Padding = new Padding(7);
            residentLastnameTextbox.PasswordChar = false;
            residentLastnameTextbox.PlaceholderColor = Color.DarkGray;
            residentLastnameTextbox.PlaceholderText = "";
            residentLastnameTextbox.Size = new Size(195, 35);
            residentLastnameTextbox.TabIndex = 1;
            residentLastnameTextbox.UnderlinedStyle = true;
            residentLastnameTextbox.TextChanged += residentLastnameTextbox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(464, 131);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 4;
            label3.Text = "Resident Last Name";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(260, 131);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 2;
            label8.Text = "Resident First Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 84);
            panel2.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2214, -2);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Manage Tips";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(244, 18);
            label12.Name = "label12";
            label12.Size = new Size(431, 47);
            label12.TabIndex = 4;
            label12.Text = "Manage Resident Informations";
            // 
            // AdminManageResidenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(928, 695);
            Controls.Add(gradientPanel1);
            Name = "AdminManageResidenceForm";
            Text = "ManageResidenceForm";
            Load += ManageResidenceForm_Load_1;
            Paint += AdminManageResidenceForm_Paint;
            Resize += ManageResidenceForm_Resize;
            gradientPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private Panel panel2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MyControls.MyButton deleteButton;
        private MyControls.MyButton addnewButton;
        private TabPage tabPage2;
        private MyControls.MyButton cancelButton;
        private MyControls.MyButton saveButton;
        private MyControls.MyTextBox residentMobileNumberTextbox;
        private Label label5;
        private MyControls.MyTextBox residentPurokNumberTextbox;
        private Label label4;
        private MyControls.MyTextBox residentLastnameTextbox;
        private Label label3;
        private Label label8;
        private Panel panel1;
        private DataGridView dataGridViewResidents;
        private Panel panel4;
        private Label label9;
        private MyControls.MyTextBox searchNameTextbox;
        private Panel panel3;
        private MyControls.MyComboBox searchByPurokDropdown;
        private Label label10;
        private MyControls.MyButton editButton;
        private Label label11;
        private PictureBox pictureBox1;
        private MyControls.MyTextBox residentFirstNameTextbox;
        private Label labelDetails;
        private MyControls.MyTextBox passwordTextbox;
        private Label label7;
        private MyControls.MyTextBox usernameTextbox;
        private Label label6;
        private MyControls.MyButton clearButton;
        private Label label12;
    }
}