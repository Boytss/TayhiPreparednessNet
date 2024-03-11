namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class EmergencyAlertForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            clearButton = new MyControls.MyButton();
            label9 = new Label();
            searchNameTextbox = new MyControls.MyTextBox();
            searchByPurokDropdown = new MyControls.MyComboBox();
            panel3 = new Panel();
            dataGridViewResidents = new DataGridView();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            myButton1 = new MyControls.MyButton();
            txtPort = new MyControls.MyComboBox();
            label1 = new Label();
            message = new MyControls.MyTextBox();
            buttonSendAlert = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 60);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(377, 4);
            label3.Name = "label3";
            label3.Size = new Size(151, 47);
            label3.TabIndex = 54;
            label3.Text = "SMS Alert";
            // 
            // panel1
            // 
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(searchNameTextbox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 102);
            panel1.TabIndex = 8;
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
            clearButton.Location = new Point(668, 60);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 35);
            clearButton.TabIndex = 53;
            clearButton.Text = "Clear Selection";
            clearButton.TextColor = Color.White;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 3);
            label9.Name = "label9";
            label9.Size = new Size(287, 37);
            label9.TabIndex = 10;
            label9.Text = "Resident Contact List";
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
            searchNameTextbox.Location = new Point(106, 60);
            searchNameTextbox.Margin = new Padding(4);
            searchNameTextbox.Multiline = false;
            searchNameTextbox.Name = "searchNameTextbox";
            searchNameTextbox.Padding = new Padding(7);
            searchNameTextbox.PasswordChar = false;
            searchNameTextbox.PlaceholderColor = Color.Gray;
            searchNameTextbox.PlaceholderText = "Search by Name";
            searchNameTextbox.Size = new Size(347, 35);
            searchNameTextbox.TabIndex = 8;
            searchNameTextbox.UnderlinedStyle = false;
            searchNameTextbox.TextChanged += searchNameTextbox_TextChanged;
            // 
            // searchByPurokDropdown
            // 
            searchByPurokDropdown.BackColor = Color.FromArgb(190, 196, 228);
            searchByPurokDropdown.BorderColor = Color.MediumSlateBlue;
            searchByPurokDropdown.BorderSize = 2;
            searchByPurokDropdown.DropDownStyle = ComboBoxStyle.DropDown;
            searchByPurokDropdown.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchByPurokDropdown.ForeColor = Color.Black;
            searchByPurokDropdown.IconColor = Color.MediumSlateBlue;
            searchByPurokDropdown.Items.AddRange(new object[] { "Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6", "All Residents" });
            searchByPurokDropdown.ListBackColor = Color.White;
            searchByPurokDropdown.ListTextColor = Color.Black;
            searchByPurokDropdown.Location = new Point(188, 12);
            searchByPurokDropdown.MinimumSize = new Size(200, 30);
            searchByPurokDropdown.Name = "searchByPurokDropdown";
            searchByPurokDropdown.Padding = new Padding(2);
            searchByPurokDropdown.Size = new Size(206, 33);
            searchByPurokDropdown.TabIndex = 9;
            searchByPurokDropdown.Texts = "Select Purok";
            searchByPurokDropdown.OnSelectedIndexChanged += searchByPurokDropdown_OnSelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewResidents);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(928, 177);
            panel3.TabIndex = 37;
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
            dataGridViewResidents.Dock = DockStyle.Fill;
            dataGridViewResidents.EnableHeadersVisualStyles = false;
            dataGridViewResidents.Location = new Point(106, 0);
            dataGridViewResidents.Name = "dataGridViewResidents";
            dataGridViewResidents.RowHeadersVisible = false;
            dataGridViewResidents.RowHeadersWidth = 40;
            dataGridViewResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResidents.Size = new Size(674, 177);
            dataGridViewResidents.TabIndex = 54;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(780, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(148, 177);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(106, 177);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(myButton1);
            panel4.Controls.Add(txtPort);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(searchByPurokDropdown);
            panel4.Controls.Add(message);
            panel4.Controls.Add(buttonSendAlert);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 339);
            panel4.Name = "panel4";
            panel4.Size = new Size(928, 356);
            panel4.TabIndex = 38;
            // 
            // myButton1
            // 
            myButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            myButton1.BackColor = Color.Red;
            myButton1.BackgroundColor = Color.Red;
            myButton1.BorderColor = Color.Yellow;
            myButton1.BorderRadius = 20;
            myButton1.BorderSize = 2;
            myButton1.FlatAppearance.BorderSize = 0;
            myButton1.FlatStyle = FlatStyle.Flat;
            myButton1.ForeColor = Color.White;
            myButton1.Location = new Point(784, 279);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(132, 40);
            myButton1.TabIndex = 20;
            myButton1.Text = "Send";
            myButton1.TextColor = Color.White;
            myButton1.UseVisualStyleBackColor = false;
            myButton1.Click += myButton1_Click;
            // 
            // txtPort
            // 
            txtPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPort.BackColor = Color.FromArgb(190, 196, 228);
            txtPort.BorderColor = Color.MediumSlateBlue;
            txtPort.BorderSize = 2;
            txtPort.DropDownStyle = ComboBoxStyle.DropDown;
            txtPort.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPort.ForeColor = Color.Black;
            txtPort.IconColor = Color.MediumSlateBlue;
            txtPort.Items.AddRange(new object[] { "COM5", "COM10" });
            txtPort.ListBackColor = Color.White;
            txtPort.ListTextColor = Color.Black;
            txtPort.Location = new Point(577, 12);
            txtPort.MinimumSize = new Size(200, 30);
            txtPort.Name = "txtPort";
            txtPort.Padding = new Padding(2);
            txtPort.Size = new Size(200, 33);
            txtPort.TabIndex = 19;
            txtPort.Texts = "Select Port";
            txtPort.OnSelectedIndexChanged += txtPort_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(117, 21);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 17;
            label1.Text = "Send to:";
            // 
            // message
            // 
            message.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            message.BackColor = SystemColors.Window;
            message.BorderColor = Color.MediumSlateBlue;
            message.BorderFocusColor = Color.Red;
            message.BorderRadius = 20;
            message.BorderSize = 2;
            message.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message.ForeColor = Color.Black;
            message.Location = new Point(106, 52);
            message.Margin = new Padding(4);
            message.Multiline = true;
            message.Name = "message";
            message.Padding = new Padding(7);
            message.PasswordChar = false;
            message.PlaceholderColor = Color.DarkGray;
            message.PlaceholderText = "";
            message.Size = new Size(671, 276);
            message.TabIndex = 12;
            message.UnderlinedStyle = false;
            // 
            // buttonSendAlert
            // 
            buttonSendAlert.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSendAlert.Location = new Point(85, 987);
            buttonSendAlert.Name = "buttonSendAlert";
            buttonSendAlert.Size = new Size(1104, 33);
            buttonSendAlert.TabIndex = 8;
            buttonSendAlert.Text = "SEND";
            buttonSendAlert.UseVisualStyleBackColor = true;
            // 
            // EmergencyAlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 196, 228);
            ClientSize = new Size(928, 695);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "EmergencyAlertForm";
            Text = "EmergencyAlertForm";
            Load += EmergencyAlertForm_Load;
            Resize += EmergencyAlertForm_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private MyControls.MyTextBox message;
        private Button buttonSendAlert;
        private DataGridView dataGridViewResidents;
        private Panel panel6;
        private Panel panel5;
        private MyControls.MyComboBox searchByPurokDropdown;
        private MyControls.MyTextBox searchNameTextbox;
        private Label label9;
        private Label label1;
        private MyControls.MyComboBox txtPort;
        private MyControls.MyButton myButton1;
        private MyControls.MyButton clearButton;
        private Label label3;
    }
}