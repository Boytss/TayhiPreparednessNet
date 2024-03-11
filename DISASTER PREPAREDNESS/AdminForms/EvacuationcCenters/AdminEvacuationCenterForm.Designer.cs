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
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            addRoomButton = new MyControls.MyButton();
            roomCapacityTextBox = new MyControls.MyTextBox();
            myComboBox1 = new MyControls.MyComboBox();
            roomNameTextBox = new MyControls.MyTextBox();
            uploadCenterButton = new MyControls.MyButton();
            centerLocationTextBox = new MyControls.MyTextBox();
            centerNameTextBox = new MyControls.MyTextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(addRoomButton);
            panel1.Controls.Add(roomCapacityTextBox);
            panel1.Controls.Add(myComboBox1);
            panel1.Controls.Add(roomNameTextBox);
            panel1.Controls.Add(uploadCenterButton);
            panel1.Controls.Add(centerLocationTextBox);
            panel1.Controls.Add(centerNameTextBox);
            panel1.Location = new Point(40, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 364);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(504, 30);
            label3.Name = "label3";
            label3.Size = new Size(218, 25);
            label3.TabIndex = 63;
            label3.Text = "Add Room and Capacity";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 30);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 62;
            label2.Text = "Add Evacuation Center";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(373, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 361);
            panel3.TabIndex = 61;
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
            addRoomButton.Location = new Point(557, 261);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new Size(102, 40);
            addRoomButton.TabIndex = 60;
            addRoomButton.Text = "Upload";
            addRoomButton.TextColor = Color.White;
            addRoomButton.UseVisualStyleBackColor = false;
            // 
            // roomCapacityTextBox
            // 
            roomCapacityTextBox.Anchor = AnchorStyles.None;
            roomCapacityTextBox.BackColor = Color.FromArgb(224, 224, 224);
            roomCapacityTextBox.BorderColor = Color.MidnightBlue;
            roomCapacityTextBox.BorderFocusColor = Color.HotPink;
            roomCapacityTextBox.BorderRadius = 15;
            roomCapacityTextBox.BorderSize = 1;
            roomCapacityTextBox.Font = new Font("Segoe UI", 9.5F);
            roomCapacityTextBox.ForeColor = Color.DimGray;
            roomCapacityTextBox.Location = new Point(512, 145);
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
            myComboBox1.Font = new Font("Segoe UI", 10F);
            myComboBox1.ForeColor = Color.DimGray;
            myComboBox1.IconColor = Color.MediumSlateBlue;
            myComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            myComboBox1.ListTextColor = Color.DimGray;
            myComboBox1.Location = new Point(512, 202);
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
            roomNameTextBox.Font = new Font("Segoe UI", 9.5F);
            roomNameTextBox.ForeColor = Color.DimGray;
            roomNameTextBox.Location = new Point(512, 85);
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
            uploadCenterButton.Location = new Point(134, 261);
            uploadCenterButton.Name = "uploadCenterButton";
            uploadCenterButton.Size = new Size(102, 40);
            uploadCenterButton.TabIndex = 56;
            uploadCenterButton.Text = "Save";
            uploadCenterButton.TextColor = Color.White;
            uploadCenterButton.UseVisualStyleBackColor = false;
            // 
            // centerLocationTextBox
            // 
            centerLocationTextBox.Anchor = AnchorStyles.None;
            centerLocationTextBox.BackColor = Color.FromArgb(224, 224, 224);
            centerLocationTextBox.BorderColor = Color.MidnightBlue;
            centerLocationTextBox.BorderFocusColor = Color.HotPink;
            centerLocationTextBox.BorderRadius = 15;
            centerLocationTextBox.BorderSize = 1;
            centerLocationTextBox.Font = new Font("Segoe UI", 9.5F);
            centerLocationTextBox.ForeColor = Color.DimGray;
            centerLocationTextBox.Location = new Point(83, 145);
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
            centerNameTextBox.Font = new Font("Segoe UI", 9.5F);
            centerNameTextBox.ForeColor = Color.DimGray;
            centerNameTextBox.Location = new Point(83, 85);
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
            // AdminEvacuationCenterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 196, 228);
            ClientSize = new Size(893, 536);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminEvacuationCenterForm";
            Text = "EvacuationCenterForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private MyControls.MyButton addRoomButton;
        private MyControls.MyTextBox roomCapacityTextBox;
        private MyControls.MyComboBox myComboBox1;
        private MyControls.MyTextBox roomNameTextBox;
        private MyControls.MyButton uploadCenterButton;
        private MyControls.MyTextBox centerLocationTextBox;
        private MyControls.MyTextBox centerNameTextBox;
        private Panel panel3;
        private Label label2;
        private Label label3;
    }
}