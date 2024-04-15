namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminEducationalVideosForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEducationalVideosForm));
            panel2 = new Panel();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            clearButton = new MyControls.MyButton();
            dataGridViewResidents = new DataGridView();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            myComboBox1 = new MyControls.MyComboBox();
            label1 = new Label();
            myTextBox1 = new MyControls.MyTextBox();
            panel3 = new Panel();
            panel1 = new Panel();
            editBtn = new MyControls.MyButton();
            buttonAddnew = new MyControls.MyButton();
            buttonDelete = new MyControls.MyButton();
            tabPage2 = new TabPage();
            label4 = new Label();
            videoUrlTextBox = new MyControls.MyTextBox();
            label8 = new Label();
            cancelButton = new MyControls.MyButton();
            buttonSave = new MyControls.MyButton();
            videoTitleTextBox = new MyControls.MyTextBox();
            labelDetails = new Label();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(868, 73);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(268, 9);
            label3.Name = "label3";
            label3.Size = new Size(325, 47);
            label3.TabIndex = 66;
            label3.Text = "Videos About Disasters";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 73);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(868, 443);
            tabControl1.TabIndex = 39;
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
            tabPage1.Size = new Size(860, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Video List";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 218, 232);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewResidents.ColumnHeadersHeight = 25;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(223, 228, 231);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewResidents.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewResidents.Dock = DockStyle.Top;
            dataGridViewResidents.EnableHeadersVisualStyles = false;
            dataGridViewResidents.Location = new Point(25, 110);
            dataGridViewResidents.Name = "dataGridViewResidents";
            dataGridViewResidents.RowHeadersVisible = false;
            dataGridViewResidents.RowHeadersWidth = 40;
            dataGridViewResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResidents.Size = new Size(707, 134);
            dataGridViewResidents.TabIndex = 51;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(myComboBox1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(myTextBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(25, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(707, 107);
            panel4.TabIndex = 50;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(344, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 23);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 8;
            label2.Text = "Of Barangay Tayhi";
            // 
            // myComboBox1
            // 
            myComboBox1.Anchor = AnchorStyles.Right;
            myComboBox1.BackColor = Color.FromArgb(190, 196, 228);
            myComboBox1.BorderColor = Color.MediumSlateBlue;
            myComboBox1.BorderSize = 2;
            myComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            myComboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myComboBox1.ForeColor = Color.Gray;
            myComboBox1.IconColor = Color.MediumSlateBlue;
            myComboBox1.Items.AddRange(new object[] { "Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6" });
            myComboBox1.ListBackColor = Color.White;
            myComboBox1.ListTextColor = Color.Black;
            myComboBox1.Location = new Point(1624, 105);
            myComboBox1.MinimumSize = new Size(200, 30);
            myComboBox1.Name = "myComboBox1";
            myComboBox1.Padding = new Padding(2);
            myComboBox1.Size = new Size(211, 33);
            myComboBox1.TabIndex = 7;
            myComboBox1.Texts = "Search by purok";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 6;
            label1.Text = "List of videos";
            // 
            // myTextBox1
            // 
            myTextBox1.BackColor = Color.FromArgb(190, 196, 228);
            myTextBox1.BorderColor = Color.MediumSlateBlue;
            myTextBox1.BorderFocusColor = Color.Blue;
            myTextBox1.BorderRadius = 15;
            myTextBox1.BorderSize = 2;
            myTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myTextBox1.ForeColor = Color.Black;
            myTextBox1.Location = new Point(3, 62);
            myTextBox1.Margin = new Padding(4);
            myTextBox1.Multiline = false;
            myTextBox1.Name = "myTextBox1";
            myTextBox1.Padding = new Padding(7);
            myTextBox1.PasswordChar = false;
            myTextBox1.PlaceholderColor = Color.Gray;
            myTextBox1.PlaceholderText = "Search by Map Name";
            myTextBox1.Size = new Size(380, 35);
            myTextBox1.TabIndex = 4;
            myTextBox1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(190, 196, 228);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(22, 409);
            panel3.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.Controls.Add(editBtn);
            panel1.Controls.Add(buttonAddnew);
            panel1.Controls.Add(buttonDelete);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(732, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 409);
            panel1.TabIndex = 46;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.MediumSlateBlue;
            editBtn.BackgroundColor = Color.MediumSlateBlue;
            editBtn.BorderColor = Color.PaleVioletRed;
            editBtn.BorderRadius = 15;
            editBtn.BorderSize = 0;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(13, 206);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(88, 35);
            editBtn.TabIndex = 7;
            editBtn.Text = "Edit";
            editBtn.TextColor = Color.White;
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // buttonAddnew
            // 
            buttonAddnew.BackColor = Color.MediumSlateBlue;
            buttonAddnew.BackgroundColor = Color.MediumSlateBlue;
            buttonAddnew.BorderColor = Color.PaleVioletRed;
            buttonAddnew.BorderRadius = 15;
            buttonAddnew.BorderSize = 0;
            buttonAddnew.FlatAppearance.BorderSize = 0;
            buttonAddnew.FlatStyle = FlatStyle.Flat;
            buttonAddnew.ForeColor = Color.White;
            buttonAddnew.Location = new Point(13, 138);
            buttonAddnew.Name = "buttonAddnew";
            buttonAddnew.Size = new Size(88, 35);
            buttonAddnew.TabIndex = 6;
            buttonAddnew.Text = "Add new";
            buttonAddnew.TextColor = Color.White;
            buttonAddnew.UseVisualStyleBackColor = false;
            buttonAddnew.Click += buttonAddnew_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.MediumSlateBlue;
            buttonDelete.BackgroundColor = Color.MediumSlateBlue;
            buttonDelete.BorderColor = Color.PaleVioletRed;
            buttonDelete.BorderRadius = 15;
            buttonDelete.BorderSize = 0;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(13, 272);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(88, 35);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.TextColor = Color.White;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(190, 196, 228);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(videoUrlTextBox);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(cancelButton);
            tabPage2.Controls.Add(buttonSave);
            tabPage2.Controls.Add(videoTitleTextBox);
            tabPage2.Controls.Add(labelDetails);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(860, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Video Details";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(283, 155);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 83;
            label4.Text = "Video URL";
            // 
            // videoUrlTextBox
            // 
            videoUrlTextBox.Anchor = AnchorStyles.None;
            videoUrlTextBox.BackColor = Color.FromArgb(224, 224, 224);
            videoUrlTextBox.BorderColor = Color.MidnightBlue;
            videoUrlTextBox.BorderFocusColor = SystemColors.MenuHighlight;
            videoUrlTextBox.BorderRadius = 15;
            videoUrlTextBox.BorderSize = 1;
            videoUrlTextBox.Font = new Font("Segoe UI", 9.5F);
            videoUrlTextBox.ForeColor = Color.Black;
            videoUrlTextBox.Location = new Point(277, 174);
            videoUrlTextBox.Margin = new Padding(4);
            videoUrlTextBox.Multiline = false;
            videoUrlTextBox.Name = "videoUrlTextBox";
            videoUrlTextBox.Padding = new Padding(7);
            videoUrlTextBox.PasswordChar = false;
            videoUrlTextBox.PlaceholderColor = Color.DarkGray;
            videoUrlTextBox.PlaceholderText = "";
            videoUrlTextBox.Size = new Size(259, 32);
            videoUrlTextBox.TabIndex = 82;
            videoUrlTextBox.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(283, 95);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 81;
            label8.Text = "Video Title";
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
            cancelButton.Location = new Point(417, 227);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(119, 40);
            cancelButton.TabIndex = 80;
            cancelButton.Text = "Cancel";
            cancelButton.TextColor = Color.White;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.None;
            buttonSave.BackColor = Color.MediumSlateBlue;
            buttonSave.BackgroundColor = Color.MediumSlateBlue;
            buttonSave.BorderColor = Color.PaleVioletRed;
            buttonSave.BorderRadius = 20;
            buttonSave.BorderSize = 0;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(277, 227);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(118, 40);
            buttonSave.TabIndex = 79;
            buttonSave.Text = "Save";
            buttonSave.TextColor = Color.White;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // videoTitleTextBox
            // 
            videoTitleTextBox.Anchor = AnchorStyles.None;
            videoTitleTextBox.BackColor = Color.FromArgb(224, 224, 224);
            videoTitleTextBox.BorderColor = Color.MidnightBlue;
            videoTitleTextBox.BorderFocusColor = SystemColors.MenuHighlight;
            videoTitleTextBox.BorderRadius = 15;
            videoTitleTextBox.BorderSize = 1;
            videoTitleTextBox.Font = new Font("Segoe UI", 9.5F);
            videoTitleTextBox.ForeColor = Color.Black;
            videoTitleTextBox.Location = new Point(277, 114);
            videoTitleTextBox.Margin = new Padding(4);
            videoTitleTextBox.Multiline = false;
            videoTitleTextBox.Name = "videoTitleTextBox";
            videoTitleTextBox.Padding = new Padding(7);
            videoTitleTextBox.PasswordChar = false;
            videoTitleTextBox.PlaceholderColor = Color.DarkGray;
            videoTitleTextBox.PlaceholderText = "";
            videoTitleTextBox.Size = new Size(259, 32);
            videoTitleTextBox.TabIndex = 78;
            videoTitleTextBox.UnderlinedStyle = false;
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDetails.Location = new Point(3, 0);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(224, 37);
            labelDetails.TabIndex = 77;
            labelDetails.Text = "Resident Details";
            // 
            // AdminEducationalVideosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 196, 228);
            ClientSize = new Size(868, 516);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Name = "AdminEducationalVideosForm";
            Text = "EducationalVideosForm";
            Load += AdminEducationalVideosForm_Load;
            Resize += AdminEducationalVideosForm_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MyControls.MyButton clearButton;
        private DataGridView dataGridViewResidents;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private MyControls.MyComboBox myComboBox1;
        private Label label1;
        private MyControls.MyTextBox myTextBox1;
        private Panel panel3;
        private Panel panel1;
        private MyControls.MyButton editBtn;
        private MyControls.MyButton buttonAddnew;
        private MyControls.MyButton buttonDelete;
        private TabPage tabPage2;
        private Label labelDetails;
        private Label label4;
        private MyControls.MyTextBox videoUrlTextBox;
        private Label label8;
        private MyControls.MyButton cancelButton;
        private MyControls.MyButton buttonSave;
        private MyControls.MyTextBox videoTitleTextBox;
    }
}