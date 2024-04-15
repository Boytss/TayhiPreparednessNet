namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminEvacuationCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEvacuationCenterForm));
            label1 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            barChartControl1 = new BarChartControl();
            label3 = new Label();
            label2 = new Label();
            addRoomButton = new MyControls.MyButton();
            roomCapacityTextBox = new MyControls.MyTextBox();
            myComboBox1 = new MyControls.MyComboBox();
            roomNameTextBox = new MyControls.MyTextBox();
            uploadCenterButton = new MyControls.MyButton();
            centerLocationTextBox = new MyControls.MyTextBox();
            centerNameTextBox = new MyControls.MyTextBox();
            tabPage2 = new TabPage();
            lastNameText = new MyControls.MyTextBox();
            saveButton = new MyControls.MyButton();
            label12 = new Label();
            roomNameDrop = new MyControls.MyComboBox();
            label11 = new Label();
            label10 = new Label();
            purokDrop = new MyControls.MyComboBox();
            label9 = new Label();
            genderDrop = new MyControls.MyComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numberFamilyText = new MyControls.MyTextBox();
            ageText = new MyControls.MyTextBox();
            middleNameText = new MyControls.MyTextBox();
            firstNameText = new MyControls.MyTextBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 20);
            label1.Name = "label1";
            label1.Size = new Size(264, 47);
            label1.TabIndex = 0;
            label1.Text = "Evacuation Center";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 90);
            panel2.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(893, 446);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(885, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Evacuation";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(barChartControl1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addRoomButton);
            panel1.Controls.Add(roomCapacityTextBox);
            panel1.Controls.Add(myComboBox1);
            panel1.Controls.Add(roomNameTextBox);
            panel1.Controls.Add(uploadCenterButton);
            panel1.Controls.Add(centerLocationTextBox);
            panel1.Controls.Add(centerNameTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 412);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // barChartControl1
            // 
            barChartControl1.BarColor = Color.Blue;
            barChartControl1.DataValues = (List<int>)resources.GetObject("barChartControl1.DataValues");
            barChartControl1.Labels = (List<string>)resources.GetObject("barChartControl1.Labels");
            barChartControl1.Location = new Point(80, 41);
            barChartControl1.Name = "barChartControl1";
            barChartControl1.Size = new Size(8, 8);
            barChartControl1.TabIndex = 64;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(506, 74);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 63;
            label3.Text = "Add Room and Capacity";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 84);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 62;
            label2.Text = "Add Evacuation Center";
            // 
            // addRoomButton
            // 
            addRoomButton.Anchor = AnchorStyles.None;
            addRoomButton.BackColor = Color.MediumSlateBlue;
            addRoomButton.BackgroundColor = Color.MediumSlateBlue;
            addRoomButton.BorderColor = Color.MidnightBlue;
            addRoomButton.BorderRadius = 15;
            addRoomButton.BorderSize = 1;
            addRoomButton.FlatAppearance.BorderSize = 0;
            addRoomButton.FlatStyle = FlatStyle.Flat;
            addRoomButton.ForeColor = Color.White;
            addRoomButton.Location = new Point(559, 305);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new Size(102, 40);
            addRoomButton.TabIndex = 60;
            addRoomButton.Text = "Upload";
            addRoomButton.TextColor = Color.White;
            addRoomButton.UseVisualStyleBackColor = false;
            addRoomButton.Click += addRoomButton_Click;
            // 
            // roomCapacityTextBox
            // 
            roomCapacityTextBox.Anchor = AnchorStyles.None;
            roomCapacityTextBox.BackColor = Color.FromArgb(224, 224, 224);
            roomCapacityTextBox.BorderColor = Color.MidnightBlue;
            roomCapacityTextBox.BorderFocusColor = Color.HotPink;
            roomCapacityTextBox.BorderRadius = 15;
            roomCapacityTextBox.BorderSize = 1;
            roomCapacityTextBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            roomCapacityTextBox.ForeColor = Color.DimGray;
            roomCapacityTextBox.Location = new Point(514, 189);
            roomCapacityTextBox.Margin = new Padding(4);
            roomCapacityTextBox.Multiline = false;
            roomCapacityTextBox.Name = "roomCapacityTextBox";
            roomCapacityTextBox.Padding = new Padding(7);
            roomCapacityTextBox.PasswordChar = false;
            roomCapacityTextBox.PlaceholderColor = Color.DarkGray;
            roomCapacityTextBox.PlaceholderText = "Room Capacity Per Family";
            roomCapacityTextBox.Size = new Size(200, 32);
            roomCapacityTextBox.TabIndex = 59;
            roomCapacityTextBox.UnderlinedStyle = false;
            // 
            // myComboBox1
            // 
            myComboBox1.Anchor = AnchorStyles.None;
            myComboBox1.BackColor = Color.FromArgb(224, 224, 224);
            myComboBox1.BorderColor = Color.MediumSlateBlue;
            myComboBox1.BorderSize = 1;
            myComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            myComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            myComboBox1.ForeColor = Color.DimGray;
            myComboBox1.IconColor = Color.MediumSlateBlue;
            myComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            myComboBox1.ListTextColor = Color.DimGray;
            myComboBox1.Location = new Point(514, 246);
            myComboBox1.MinimumSize = new Size(200, 30);
            myComboBox1.Name = "myComboBox1";
            myComboBox1.Padding = new Padding(1);
            myComboBox1.Size = new Size(200, 30);
            myComboBox1.TabIndex = 58;
            myComboBox1.Texts = "Select Evacuation Center";
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.Anchor = AnchorStyles.None;
            roomNameTextBox.BackColor = Color.FromArgb(224, 224, 224);
            roomNameTextBox.BorderColor = Color.MidnightBlue;
            roomNameTextBox.BorderFocusColor = Color.HotPink;
            roomNameTextBox.BorderRadius = 15;
            roomNameTextBox.BorderSize = 1;
            roomNameTextBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            roomNameTextBox.ForeColor = Color.DimGray;
            roomNameTextBox.Location = new Point(514, 129);
            roomNameTextBox.Margin = new Padding(4);
            roomNameTextBox.Multiline = false;
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Padding = new Padding(7);
            roomNameTextBox.PasswordChar = false;
            roomNameTextBox.PlaceholderColor = Color.DarkGray;
            roomNameTextBox.PlaceholderText = "Room Name";
            roomNameTextBox.Size = new Size(200, 32);
            roomNameTextBox.TabIndex = 57;
            roomNameTextBox.UnderlinedStyle = false;
            // 
            // uploadCenterButton
            // 
            uploadCenterButton.Anchor = AnchorStyles.None;
            uploadCenterButton.BackColor = Color.MediumSlateBlue;
            uploadCenterButton.BackgroundColor = Color.MediumSlateBlue;
            uploadCenterButton.BorderColor = Color.MidnightBlue;
            uploadCenterButton.BorderRadius = 15;
            uploadCenterButton.BorderSize = 1;
            uploadCenterButton.FlatAppearance.BorderSize = 0;
            uploadCenterButton.FlatStyle = FlatStyle.Flat;
            uploadCenterButton.ForeColor = Color.White;
            uploadCenterButton.Location = new Point(157, 272);
            uploadCenterButton.Name = "uploadCenterButton";
            uploadCenterButton.Size = new Size(102, 40);
            uploadCenterButton.TabIndex = 56;
            uploadCenterButton.Text = "Save";
            uploadCenterButton.TextColor = Color.White;
            uploadCenterButton.UseVisualStyleBackColor = false;
            uploadCenterButton.Click += uploadCenterButton_Click;
            // 
            // centerLocationTextBox
            // 
            centerLocationTextBox.Anchor = AnchorStyles.None;
            centerLocationTextBox.BackColor = Color.FromArgb(224, 224, 224);
            centerLocationTextBox.BorderColor = Color.MidnightBlue;
            centerLocationTextBox.BorderFocusColor = Color.HotPink;
            centerLocationTextBox.BorderRadius = 15;
            centerLocationTextBox.BorderSize = 1;
            centerLocationTextBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            centerLocationTextBox.ForeColor = Color.DimGray;
            centerLocationTextBox.Location = new Point(134, 199);
            centerLocationTextBox.Margin = new Padding(4);
            centerLocationTextBox.Multiline = false;
            centerLocationTextBox.Name = "centerLocationTextBox";
            centerLocationTextBox.Padding = new Padding(7);
            centerLocationTextBox.PasswordChar = false;
            centerLocationTextBox.PlaceholderColor = Color.DarkGray;
            centerLocationTextBox.PlaceholderText = "Location";
            centerLocationTextBox.Size = new Size(200, 32);
            centerLocationTextBox.TabIndex = 55;
            centerLocationTextBox.UnderlinedStyle = false;
            // 
            // centerNameTextBox
            // 
            centerNameTextBox.Anchor = AnchorStyles.None;
            centerNameTextBox.BackColor = Color.FromArgb(224, 224, 224);
            centerNameTextBox.BorderColor = Color.MidnightBlue;
            centerNameTextBox.BorderFocusColor = Color.HotPink;
            centerNameTextBox.BorderRadius = 15;
            centerNameTextBox.BorderSize = 1;
            centerNameTextBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            centerNameTextBox.ForeColor = Color.DimGray;
            centerNameTextBox.Location = new Point(134, 139);
            centerNameTextBox.Margin = new Padding(4);
            centerNameTextBox.Multiline = false;
            centerNameTextBox.Name = "centerNameTextBox";
            centerNameTextBox.Padding = new Padding(7);
            centerNameTextBox.PasswordChar = false;
            centerNameTextBox.PlaceholderColor = Color.DarkGray;
            centerNameTextBox.PlaceholderText = "Evacuation Center Name";
            centerNameTextBox.Size = new Size(200, 32);
            centerNameTextBox.TabIndex = 54;
            centerNameTextBox.UnderlinedStyle = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(224, 224, 224);
            tabPage2.Controls.Add(lastNameText);
            tabPage2.Controls.Add(saveButton);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(roomNameDrop);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(purokDrop);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(genderDrop);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(numberFamilyText);
            tabPage2.Controls.Add(ageText);
            tabPage2.Controls.Add(middleNameText);
            tabPage2.Controls.Add(firstNameText);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(885, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Evacuees";
            tabPage2.Click += tabPage2_Click;
            // 
            // lastNameText
            // 
            lastNameText.BackColor = Color.FromArgb(224, 224, 224);
            lastNameText.BorderColor = Color.MidnightBlue;
            lastNameText.BorderFocusColor = Color.HotPink;
            lastNameText.BorderRadius = 15;
            lastNameText.BorderSize = 1;
            lastNameText.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameText.ForeColor = Color.DimGray;
            lastNameText.Location = new Point(28, 79);
            lastNameText.Margin = new Padding(4);
            lastNameText.Multiline = false;
            lastNameText.Name = "lastNameText";
            lastNameText.Padding = new Padding(7);
            lastNameText.PasswordChar = false;
            lastNameText.PlaceholderColor = Color.DarkGray;
            lastNameText.PlaceholderText = "Last Name";
            lastNameText.Size = new Size(214, 32);
            lastNameText.TabIndex = 84;
            lastNameText.UnderlinedStyle = false;
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
            saveButton.Location = new Point(617, 266);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(156, 40);
            saveButton.TabIndex = 83;
            saveButton.Text = "SAVE";
            saveButton.TextColor = Color.White;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(305, 257);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 82;
            label12.Text = "Room name";
            // 
            // roomNameDrop
            // 
            roomNameDrop.BackColor = Color.FromArgb(224, 224, 224);
            roomNameDrop.BorderColor = Color.MediumSlateBlue;
            roomNameDrop.BorderSize = 1;
            roomNameDrop.DropDownStyle = ComboBoxStyle.DropDown;
            roomNameDrop.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            roomNameDrop.ForeColor = Color.DimGray;
            roomNameDrop.IconColor = Color.MediumSlateBlue;
            roomNameDrop.Items.AddRange(new object[] { "Room1", "Room2", "Room3", "Room4", "Room5", "Room6", "Room7" });
            roomNameDrop.ListBackColor = Color.FromArgb(230, 228, 245);
            roomNameDrop.ListTextColor = Color.DimGray;
            roomNameDrop.Location = new Point(305, 276);
            roomNameDrop.MinimumSize = new Size(200, 30);
            roomNameDrop.Name = "roomNameDrop";
            roomNameDrop.Padding = new Padding(1);
            roomNameDrop.Size = new Size(200, 30);
            roomNameDrop.TabIndex = 81;
            roomNameDrop.Texts = "Room name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(28, 257);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 80;
            label11.Text = "No. of family*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(587, 152);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 79;
            label10.Text = "Purok*";
            // 
            // purokDrop
            // 
            purokDrop.BackColor = Color.FromArgb(224, 224, 224);
            purokDrop.BorderColor = Color.MediumSlateBlue;
            purokDrop.BorderSize = 1;
            purokDrop.DropDownStyle = ComboBoxStyle.DropDown;
            purokDrop.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            purokDrop.ForeColor = Color.DimGray;
            purokDrop.IconColor = Color.MediumSlateBlue;
            purokDrop.Items.AddRange(new object[] { "Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6" });
            purokDrop.ListBackColor = Color.FromArgb(230, 228, 245);
            purokDrop.ListTextColor = Color.DimGray;
            purokDrop.Location = new Point(587, 170);
            purokDrop.MinimumSize = new Size(200, 30);
            purokDrop.Name = "purokDrop";
            purokDrop.Padding = new Padding(1);
            purokDrop.Size = new Size(200, 30);
            purokDrop.TabIndex = 78;
            purokDrop.Texts = "Purok";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(305, 151);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 77;
            label9.Text = "Gender*";
            // 
            // genderDrop
            // 
            genderDrop.BackColor = Color.FromArgb(224, 224, 224);
            genderDrop.BorderColor = Color.MediumSlateBlue;
            genderDrop.BorderSize = 1;
            genderDrop.DropDownStyle = ComboBoxStyle.DropDown;
            genderDrop.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genderDrop.ForeColor = Color.DimGray;
            genderDrop.IconColor = Color.MediumSlateBlue;
            genderDrop.Items.AddRange(new object[] { "Male", "Female" });
            genderDrop.ListBackColor = Color.FromArgb(230, 228, 245);
            genderDrop.ListTextColor = Color.DimGray;
            genderDrop.Location = new Point(305, 172);
            genderDrop.MinimumSize = new Size(200, 30);
            genderDrop.Name = "genderDrop";
            genderDrop.Padding = new Padding(1);
            genderDrop.Size = new Size(200, 30);
            genderDrop.TabIndex = 76;
            genderDrop.Texts = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 151);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 75;
            label8.Text = "Age*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(587, 60);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 74;
            label7.Text = "Middle Name *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 60);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 73;
            label6.Text = "Last Name*";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(305, 60);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 72;
            label5.Text = "First Name*";
            // 
            // numberFamilyText
            // 
            numberFamilyText.BackColor = Color.FromArgb(224, 224, 224);
            numberFamilyText.BorderColor = Color.MidnightBlue;
            numberFamilyText.BorderFocusColor = Color.HotPink;
            numberFamilyText.BorderRadius = 15;
            numberFamilyText.BorderSize = 1;
            numberFamilyText.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            numberFamilyText.ForeColor = Color.DimGray;
            numberFamilyText.Location = new Point(28, 276);
            numberFamilyText.Margin = new Padding(4);
            numberFamilyText.Multiline = false;
            numberFamilyText.Name = "numberFamilyText";
            numberFamilyText.Padding = new Padding(7);
            numberFamilyText.PasswordChar = false;
            numberFamilyText.PlaceholderColor = Color.DarkGray;
            numberFamilyText.PlaceholderText = "Number of family";
            numberFamilyText.Size = new Size(218, 32);
            numberFamilyText.TabIndex = 70;
            numberFamilyText.UnderlinedStyle = false;
            numberFamilyText.TextChanged += myTextBox7_TextChanged;
            // 
            // ageText
            // 
            ageText.BackColor = Color.FromArgb(224, 224, 224);
            ageText.BorderColor = Color.MidnightBlue;
            ageText.BorderFocusColor = Color.HotPink;
            ageText.BorderRadius = 15;
            ageText.BorderSize = 1;
            ageText.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            ageText.ForeColor = Color.DimGray;
            ageText.Location = new Point(28, 170);
            ageText.Margin = new Padding(4);
            ageText.Multiline = false;
            ageText.Name = "ageText";
            ageText.Padding = new Padding(7);
            ageText.PasswordChar = false;
            ageText.PlaceholderColor = Color.DarkGray;
            ageText.PlaceholderText = "Age";
            ageText.Size = new Size(218, 32);
            ageText.TabIndex = 67;
            ageText.UnderlinedStyle = false;
            // 
            // middleNameText
            // 
            middleNameText.BackColor = Color.FromArgb(224, 224, 224);
            middleNameText.BorderColor = Color.MidnightBlue;
            middleNameText.BorderFocusColor = Color.HotPink;
            middleNameText.BorderRadius = 15;
            middleNameText.BorderSize = 1;
            middleNameText.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameText.ForeColor = Color.DimGray;
            middleNameText.Location = new Point(587, 79);
            middleNameText.Margin = new Padding(4);
            middleNameText.Multiline = false;
            middleNameText.Name = "middleNameText";
            middleNameText.Padding = new Padding(7);
            middleNameText.PasswordChar = false;
            middleNameText.PlaceholderColor = Color.DarkGray;
            middleNameText.PlaceholderText = "Middle Name";
            middleNameText.Size = new Size(210, 32);
            middleNameText.TabIndex = 66;
            middleNameText.UnderlinedStyle = false;
            // 
            // firstNameText
            // 
            firstNameText.BackColor = Color.FromArgb(224, 224, 224);
            firstNameText.BorderColor = Color.MidnightBlue;
            firstNameText.BorderFocusColor = Color.HotPink;
            firstNameText.BorderRadius = 15;
            firstNameText.BorderSize = 1;
            firstNameText.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameText.ForeColor = Color.DimGray;
            firstNameText.Location = new Point(305, 79);
            firstNameText.Margin = new Padding(4);
            firstNameText.Multiline = false;
            firstNameText.Name = "firstNameText";
            firstNameText.Padding = new Padding(7);
            firstNameText.PasswordChar = false;
            firstNameText.PlaceholderColor = Color.DarkGray;
            firstNameText.PlaceholderText = "First Name";
            firstNameText.Size = new Size(214, 32);
            firstNameText.TabIndex = 65;
            firstNameText.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 17);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 63;
            label4.Text = "Add Evacuees";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(webView21);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(885, 418);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(885, 418);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // AdminEvacuationCenterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 196, 228);
            ClientSize = new Size(893, 536);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Name = "AdminEvacuationCenterForm";
            Text = "a";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private MyControls.MyButton addRoomButton;
        private MyControls.MyTextBox roomCapacityTextBox;
        private MyControls.MyComboBox myComboBox1;
        private MyControls.MyTextBox roomNameTextBox;
        private MyControls.MyButton uploadCenterButton;
        private MyControls.MyTextBox centerLocationTextBox;
        private MyControls.MyTextBox centerNameTextBox;
        private Label label4;
        private MyControls.MyTextBox numberFamilyText;
        private MyControls.MyTextBox ageText;
        private MyControls.MyTextBox middleNameText;
        private MyControls.MyTextBox firstNameText;
        private Label label5;
        private Label label6;
        private MyControls.MyComboBox genderDrop;
        private Label label8;
        private Label label7;
        private Label label10;
        private MyControls.MyComboBox purokDrop;
        private Label label9;
        private MyControls.MyTextBox lastNameText;
        private MyControls.MyButton saveButton;
        private Label label12;
        private MyControls.MyComboBox roomNameDrop;
        private Label label11;
        private BarChartControl barChartControl1;
        private TabPage tabPage3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}