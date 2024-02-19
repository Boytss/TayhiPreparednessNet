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
            dataGridViewResidents = new DataGridView();
            panel4 = new Panel();
            myComboBox1 = new MyControls.MyComboBox();
            label9 = new Label();
            searchNameTextbox = new MyControls.MyTextBox();
            searchButton = new MyControls.MyButton();
            panel3 = new Panel();
            panel1 = new Panel();
            editButton = new MyControls.MyButton();
            addnewButton = new MyControls.MyButton();
            deleteButton = new MyControls.MyButton();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            cancelButton = new MyControls.MyButton();
            saveButton = new MyControls.MyButton();
            residentPasswordTextbox = new MyControls.MyTextBox();
            label7 = new Label();
            residentUsernameTextbox = new MyControls.MyTextBox();
            label6 = new Label();
            residentMobileNumberTextbox = new MyControls.MyTextBox();
            label5 = new Label();
            residentPurokNumberTextbox = new MyControls.MyTextBox();
            label4 = new Label();
            residentLastnameTextbox = new MyControls.MyTextBox();
            label3 = new Label();
            residentFirstNameTextbox = new MyControls.MyTextBox();
            label8 = new Label();
            residentIdTextbox = new MyControls.MyTextBox();
            residentId = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            gradientPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).BeginInit();
            panel4.SuspendLayout();
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
            tabPage1.UseVisualStyleBackColor = true;
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
            dataGridViewResidents.ColumnHeadersHeight = 35;
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
            dataGridViewResidents.Location = new Point(46, 141);
            dataGridViewResidents.Name = "dataGridViewResidents";
            dataGridViewResidents.RowHeadersVisible = false;
            dataGridViewResidents.RowHeadersWidth = 25;
            dataGridViewResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResidents.Size = new Size(746, 226);
            dataGridViewResidents.TabIndex = 51;
            dataGridViewResidents.SelectionChanged += dataGridViewResidents_SelectionChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(myComboBox1);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(searchNameTextbox);
            panel4.Controls.Add(searchButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(46, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(746, 138);
            panel4.TabIndex = 50;
            // 
            // myComboBox1
            // 
            myComboBox1.Anchor = AnchorStyles.Left;
            myComboBox1.BackColor = Color.WhiteSmoke;
            myComboBox1.BorderColor = Color.MediumSlateBlue;
            myComboBox1.BorderSize = 2;
            myComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            myComboBox1.Font = new Font("Segoe UI", 10F);
            myComboBox1.ForeColor = Color.DarkGray;
            myComboBox1.IconColor = Color.MediumSlateBlue;
            myComboBox1.ListBackColor = Color.White;
            myComboBox1.ListTextColor = Color.Black;
            myComboBox1.Location = new Point(358, 102);
            myComboBox1.MinimumSize = new Size(200, 30);
            myComboBox1.Name = "myComboBox1";
            myComboBox1.Padding = new Padding(2);
            myComboBox1.Size = new Size(200, 30);
            myComboBox1.TabIndex = 7;
            myComboBox1.Texts = "Search by purok";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 9);
            label9.Name = "label9";
            label9.Size = new Size(212, 43);
            label9.TabIndex = 6;
            label9.Text = "Resident List";
            // 
            // searchNameTextbox
            // 
            searchNameTextbox.BackColor = SystemColors.Window;
            searchNameTextbox.BorderColor = Color.MediumSlateBlue;
            searchNameTextbox.BorderFocusColor = Color.Blue;
            searchNameTextbox.BorderRadius = 18;
            searchNameTextbox.BorderSize = 2;
            searchNameTextbox.Font = new Font("Segoe UI", 9.5F);
            searchNameTextbox.ForeColor = Color.DimGray;
            searchNameTextbox.Location = new Point(6, 100);
            searchNameTextbox.Margin = new Padding(4);
            searchNameTextbox.Multiline = false;
            searchNameTextbox.Name = "searchNameTextbox";
            searchNameTextbox.Padding = new Padding(7);
            searchNameTextbox.PasswordChar = false;
            searchNameTextbox.PlaceholderColor = Color.DarkGray;
            searchNameTextbox.PlaceholderText = "Search by Name";
            searchNameTextbox.Size = new Size(345, 32);
            searchNameTextbox.TabIndex = 4;
            searchNameTextbox.UnderlinedStyle = false;
            searchNameTextbox.TextChanged += searchNameTextbox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Right;
            searchButton.BackColor = Color.FromArgb(128, 128, 255);
            searchButton.BackgroundColor = Color.FromArgb(128, 128, 255);
            searchButton.BorderColor = Color.MediumSlateBlue;
            searchButton.BorderRadius = 18;
            searchButton.BorderSize = 1;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 76);
            searchButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(124, 146, 237);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = Color.Blue;
            searchButton.Location = new Point(656, 99);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(84, 33);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search";
            searchButton.TextColor = Color.Blue;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(43, 577);
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
            editButton.Location = new Point(26, 73);
            editButton.Name = "editButton";
            editButton.Size = new Size(88, 35);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.TextColor = Color.White;
            editButton.UseVisualStyleBackColor = false;
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
            addnewButton.Location = new Point(21, 138);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(88, 35);
            addnewButton.TabIndex = 6;
            addnewButton.Text = "Add new";
            addnewButton.TextColor = Color.White;
            addnewButton.UseVisualStyleBackColor = false;
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
            deleteButton.Location = new Point(21, 207);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 35);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.TextColor = Color.White;
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(cancelButton);
            tabPage2.Controls.Add(saveButton);
            tabPage2.Controls.Add(residentPasswordTextbox);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(residentUsernameTextbox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(residentMobileNumberTextbox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(residentPurokNumberTextbox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(residentLastnameTextbox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(residentFirstNameTextbox);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(residentIdTextbox);
            tabPage2.Controls.Add(residentId);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(920, 583);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Resident Details";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(641, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 18;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.MediumSlateBlue;
            cancelButton.BackgroundColor = Color.MediumSlateBlue;
            cancelButton.BorderColor = Color.PaleVioletRed;
            cancelButton.BorderRadius = 20;
            cancelButton.BorderSize = 0;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(307, 300);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 40);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.MediumSlateBlue;
            saveButton.BackgroundColor = Color.MediumSlateBlue;
            saveButton.BorderColor = Color.PaleVioletRed;
            saveButton.BorderRadius = 20;
            saveButton.BorderSize = 0;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(113, 300);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 40);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.TextColor = Color.White;
            saveButton.UseVisualStyleBackColor = false;
            // 
            // residentPasswordTextbox
            // 
            residentPasswordTextbox.BackColor = SystemColors.Window;
            residentPasswordTextbox.BorderColor = Color.MediumSlateBlue;
            residentPasswordTextbox.BorderFocusColor = Color.HotPink;
            residentPasswordTextbox.BorderRadius = 0;
            residentPasswordTextbox.BorderSize = 2;
            residentPasswordTextbox.Font = new Font("Segoe UI", 9.5F);
            residentPasswordTextbox.ForeColor = Color.DimGray;
            residentPasswordTextbox.Location = new Point(575, 62);
            residentPasswordTextbox.Margin = new Padding(4);
            residentPasswordTextbox.Multiline = false;
            residentPasswordTextbox.Name = "residentPasswordTextbox";
            residentPasswordTextbox.Padding = new Padding(7);
            residentPasswordTextbox.PasswordChar = false;
            residentPasswordTextbox.PlaceholderColor = Color.DarkGray;
            residentPasswordTextbox.PlaceholderText = "";
            residentPasswordTextbox.Size = new Size(195, 32);
            residentPasswordTextbox.TabIndex = 13;
            residentPasswordTextbox.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(578, 46);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 12;
            label7.Text = "Resident Id";
            // 
            // residentUsernameTextbox
            // 
            residentUsernameTextbox.BackColor = SystemColors.Window;
            residentUsernameTextbox.BorderColor = Color.MediumSlateBlue;
            residentUsernameTextbox.BorderFocusColor = Color.HotPink;
            residentUsernameTextbox.BorderRadius = 0;
            residentUsernameTextbox.BorderSize = 2;
            residentUsernameTextbox.Font = new Font("Segoe UI", 9.5F);
            residentUsernameTextbox.ForeColor = Color.DimGray;
            residentUsernameTextbox.Location = new Point(352, 237);
            residentUsernameTextbox.Margin = new Padding(4);
            residentUsernameTextbox.Multiline = false;
            residentUsernameTextbox.Name = "residentUsernameTextbox";
            residentUsernameTextbox.Padding = new Padding(7);
            residentUsernameTextbox.PasswordChar = false;
            residentUsernameTextbox.PlaceholderColor = Color.DarkGray;
            residentUsernameTextbox.PlaceholderText = "";
            residentUsernameTextbox.Size = new Size(195, 32);
            residentUsernameTextbox.TabIndex = 11;
            residentUsernameTextbox.UnderlinedStyle = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 221);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 10;
            label6.Text = "Resident Id";
            // 
            // residentMobileNumberTextbox
            // 
            residentMobileNumberTextbox.BackColor = SystemColors.Window;
            residentMobileNumberTextbox.BorderColor = Color.MediumSlateBlue;
            residentMobileNumberTextbox.BorderFocusColor = Color.HotPink;
            residentMobileNumberTextbox.BorderRadius = 0;
            residentMobileNumberTextbox.BorderSize = 2;
            residentMobileNumberTextbox.Font = new Font("Segoe UI", 9.5F);
            residentMobileNumberTextbox.ForeColor = Color.DimGray;
            residentMobileNumberTextbox.Location = new Point(352, 144);
            residentMobileNumberTextbox.Margin = new Padding(4);
            residentMobileNumberTextbox.Multiline = false;
            residentMobileNumberTextbox.Name = "residentMobileNumberTextbox";
            residentMobileNumberTextbox.Padding = new Padding(7);
            residentMobileNumberTextbox.PasswordChar = false;
            residentMobileNumberTextbox.PlaceholderColor = Color.DarkGray;
            residentMobileNumberTextbox.PlaceholderText = "";
            residentMobileNumberTextbox.Size = new Size(195, 32);
            residentMobileNumberTextbox.TabIndex = 9;
            residentMobileNumberTextbox.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 128);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 8;
            label5.Text = "Resident Id";
            // 
            // residentPurokNumberTextbox
            // 
            residentPurokNumberTextbox.BackColor = SystemColors.Window;
            residentPurokNumberTextbox.BorderColor = Color.MediumSlateBlue;
            residentPurokNumberTextbox.BorderFocusColor = Color.HotPink;
            residentPurokNumberTextbox.BorderRadius = 0;
            residentPurokNumberTextbox.BorderSize = 2;
            residentPurokNumberTextbox.Font = new Font("Segoe UI", 9.5F);
            residentPurokNumberTextbox.ForeColor = Color.DimGray;
            residentPurokNumberTextbox.Location = new Point(352, 62);
            residentPurokNumberTextbox.Margin = new Padding(4);
            residentPurokNumberTextbox.Multiline = false;
            residentPurokNumberTextbox.Name = "residentPurokNumberTextbox";
            residentPurokNumberTextbox.Padding = new Padding(7);
            residentPurokNumberTextbox.PasswordChar = false;
            residentPurokNumberTextbox.PlaceholderColor = Color.DarkGray;
            residentPurokNumberTextbox.PlaceholderText = "";
            residentPurokNumberTextbox.Size = new Size(195, 32);
            residentPurokNumberTextbox.TabIndex = 7;
            residentPurokNumberTextbox.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 46);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Resident Id";
            // 
            // residentLastnameTextbox
            // 
            residentLastnameTextbox.BackColor = SystemColors.Window;
            residentLastnameTextbox.BorderColor = Color.MediumSlateBlue;
            residentLastnameTextbox.BorderFocusColor = Color.HotPink;
            residentLastnameTextbox.BorderRadius = 0;
            residentLastnameTextbox.BorderSize = 2;
            residentLastnameTextbox.Font = new Font("Segoe UI", 9.5F);
            residentLastnameTextbox.ForeColor = Color.DimGray;
            residentLastnameTextbox.Location = new Point(83, 237);
            residentLastnameTextbox.Margin = new Padding(4);
            residentLastnameTextbox.Multiline = false;
            residentLastnameTextbox.Name = "residentLastnameTextbox";
            residentLastnameTextbox.Padding = new Padding(7);
            residentLastnameTextbox.PasswordChar = false;
            residentLastnameTextbox.PlaceholderColor = Color.DarkGray;
            residentLastnameTextbox.PlaceholderText = "";
            residentLastnameTextbox.Size = new Size(195, 32);
            residentLastnameTextbox.TabIndex = 5;
            residentLastnameTextbox.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 221);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Resident Id";
            // 
            // residentFirstNameTextbox
            // 
            residentFirstNameTextbox.BackColor = SystemColors.Window;
            residentFirstNameTextbox.BorderColor = Color.MediumSlateBlue;
            residentFirstNameTextbox.BorderFocusColor = Color.HotPink;
            residentFirstNameTextbox.BorderRadius = 0;
            residentFirstNameTextbox.BorderSize = 2;
            residentFirstNameTextbox.Font = new Font("Segoe UI", 9.5F);
            residentFirstNameTextbox.ForeColor = Color.DimGray;
            residentFirstNameTextbox.Location = new Point(83, 144);
            residentFirstNameTextbox.Margin = new Padding(4);
            residentFirstNameTextbox.Multiline = false;
            residentFirstNameTextbox.Name = "residentFirstNameTextbox";
            residentFirstNameTextbox.Padding = new Padding(7);
            residentFirstNameTextbox.PasswordChar = false;
            residentFirstNameTextbox.PlaceholderColor = Color.DarkGray;
            residentFirstNameTextbox.PlaceholderText = "";
            residentFirstNameTextbox.Size = new Size(195, 32);
            residentFirstNameTextbox.TabIndex = 3;
            residentFirstNameTextbox.UnderlinedStyle = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 128);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 2;
            label8.Text = "Resident Id";
            // 
            // residentIdTextbox
            // 
            residentIdTextbox.BackColor = SystemColors.Window;
            residentIdTextbox.BorderColor = Color.MediumSlateBlue;
            residentIdTextbox.BorderFocusColor = Color.HotPink;
            residentIdTextbox.BorderRadius = 0;
            residentIdTextbox.BorderSize = 2;
            residentIdTextbox.Font = new Font("Segoe UI", 9.5F);
            residentIdTextbox.ForeColor = Color.DimGray;
            residentIdTextbox.Location = new Point(83, 62);
            residentIdTextbox.Margin = new Padding(4);
            residentIdTextbox.Multiline = false;
            residentIdTextbox.Name = "residentIdTextbox";
            residentIdTextbox.Padding = new Padding(7);
            residentIdTextbox.PasswordChar = false;
            residentIdTextbox.PlaceholderColor = Color.Black;
            residentIdTextbox.PlaceholderText = "aasdasd";
            residentIdTextbox.Size = new Size(195, 32);
            residentIdTextbox.TabIndex = 1;
            residentIdTextbox.UnderlinedStyle = true;
            // 
            // residentId
            // 
            residentId.AutoSize = true;
            residentId.Location = new Point(86, 46);
            residentId.Name = "residentId";
            residentId.Size = new Size(65, 15);
            residentId.TabIndex = 0;
            residentId.Text = "Resident Id";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sigmar One", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 19);
            label1.Name = "label1";
            label1.Size = new Size(316, 45);
            label1.TabIndex = 0;
            label1.Text = "Manage Residence";
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
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MyControls.MyButton deleteButton;
        private MyControls.MyButton editButton;
        private MyControls.MyButton addnewButton;
        private TabPage tabPage2;
        private MyControls.MyButton cancelButton;
        private MyControls.MyButton saveButton;
        private MyControls.MyTextBox residentPasswordTextbox;
        private Label label7;
        private MyControls.MyTextBox residentUsernameTextbox;
        private Label label6;
        private MyControls.MyTextBox residentMobileNumberTextbox;
        private Label label5;
        private MyControls.MyTextBox residentPurokNumberTextbox;
        private Label label4;
        private MyControls.MyTextBox residentLastnameTextbox;
        private Label label3;
        private MyControls.MyTextBox residentFirstNameTextbox;
        private Label label8;
        private MyControls.MyTextBox residentIdTextbox;
        private Label residentId;
        private Panel panel1;
        private DataGridView dataGridViewResidents;
        private Panel panel4;
        private Label label9;
        private MyControls.MyTextBox searchNameTextbox;
        private MyControls.MyButton searchButton;
        private Panel panel3;
        private TextBox textBox1;
        private MyControls.MyComboBox myComboBox1;
    }
}