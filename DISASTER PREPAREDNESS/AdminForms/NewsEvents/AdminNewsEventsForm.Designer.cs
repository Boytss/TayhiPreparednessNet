namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminNewsEventsForm
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
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            buttonImage = new MyControls.MyButton();
            authorName = new MyControls.MyTextBox();
            titleName = new MyControls.MyTextBox();
            buttonUpload = new MyControls.MyButton();
            label5 = new Label();
            descriptionName = new MyControls.MyTextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 90);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(323, 20);
            label3.Name = "label3";
            label3.Size = new Size(248, 47);
            label3.TabIndex = 4;
            label3.Text = "News and Events";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(buttonImage);
            panel1.Controls.Add(authorName);
            panel1.Controls.Add(titleName);
            panel1.Controls.Add(buttonUpload);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(descriptionName);
            panel1.Location = new Point(56, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 399);
            panel1.TabIndex = 9;
            // 
            // buttonImage
            // 
            buttonImage.Anchor = AnchorStyles.None;
            buttonImage.BackColor = Color.FromArgb(224, 224, 224);
            buttonImage.BackgroundColor = Color.FromArgb(224, 224, 224);
            buttonImage.BorderColor = Color.MidnightBlue;
            buttonImage.BorderRadius = 0;
            buttonImage.BorderSize = 1;
            buttonImage.FlatAppearance.BorderSize = 0;
            buttonImage.FlatStyle = FlatStyle.Flat;
            buttonImage.ForeColor = Color.Black;
            buttonImage.Location = new Point(514, 80);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(184, 141);
            buttonImage.TabIndex = 68;
            buttonImage.Text = "Choose Image";
            buttonImage.TextColor = Color.Black;
            buttonImage.UseVisualStyleBackColor = false;
            buttonImage.Click += buttonImage_Click;
            // 
            // authorName
            // 
            authorName.Anchor = AnchorStyles.None;
            authorName.BackColor = Color.FromArgb(224, 224, 224);
            authorName.BorderColor = Color.MidnightBlue;
            authorName.BorderFocusColor = SystemColors.MenuHighlight;
            authorName.BorderRadius = 15;
            authorName.BorderSize = 1;
            authorName.Font = new Font("Segoe UI", 9.5F);
            authorName.ForeColor = Color.DimGray;
            authorName.Location = new Point(249, 131);
            authorName.Margin = new Padding(4);
            authorName.Multiline = false;
            authorName.Name = "authorName";
            authorName.Padding = new Padding(7);
            authorName.PasswordChar = false;
            authorName.PlaceholderColor = Color.DarkGray;
            authorName.PlaceholderText = "Author";
            authorName.Size = new Size(232, 32);
            authorName.TabIndex = 67;
            authorName.UnderlinedStyle = false;
            // 
            // titleName
            // 
            titleName.Anchor = AnchorStyles.None;
            titleName.BackColor = Color.FromArgb(224, 224, 224);
            titleName.BorderColor = Color.MidnightBlue;
            titleName.BorderFocusColor = SystemColors.MenuHighlight;
            titleName.BorderRadius = 15;
            titleName.BorderSize = 1;
            titleName.Font = new Font("Segoe UI", 9.5F);
            titleName.ForeColor = Color.DimGray;
            titleName.Location = new Point(249, 80);
            titleName.Margin = new Padding(4);
            titleName.Multiline = false;
            titleName.Name = "titleName";
            titleName.Padding = new Padding(7);
            titleName.PasswordChar = false;
            titleName.PlaceholderColor = Color.DarkGray;
            titleName.PlaceholderText = "Title Name";
            titleName.Size = new Size(232, 32);
            titleName.TabIndex = 66;
            titleName.UnderlinedStyle = false;
            // 
            // buttonUpload
            // 
            buttonUpload.Anchor = AnchorStyles.None;
            buttonUpload.BackColor = Color.MediumSlateBlue;
            buttonUpload.BackgroundColor = Color.MediumSlateBlue;
            buttonUpload.BorderColor = Color.PaleVioletRed;
            buttonUpload.BorderRadius = 20;
            buttonUpload.BorderSize = 0;
            buttonUpload.FlatAppearance.BorderSize = 0;
            buttonUpload.FlatStyle = FlatStyle.Flat;
            buttonUpload.ForeColor = Color.White;
            buttonUpload.Location = new Point(295, 347);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(129, 40);
            buttonUpload.TabIndex = 65;
            buttonUpload.Text = "Upload";
            buttonUpload.TextColor = Color.White;
            buttonUpload.UseVisualStyleBackColor = false;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(253, 14);
            label5.Name = "label5";
            label5.Size = new Size(209, 25);
            label5.TabIndex = 63;
            label5.Text = "Upload News or Events";
            // 
            // descriptionName
            // 
            descriptionName.Anchor = AnchorStyles.None;
            descriptionName.BackColor = Color.FromArgb(224, 224, 224);
            descriptionName.BorderColor = Color.MidnightBlue;
            descriptionName.BorderFocusColor = SystemColors.MenuHighlight;
            descriptionName.BorderRadius = 15;
            descriptionName.BorderSize = 1;
            descriptionName.Font = new Font("Segoe UI", 9.5F);
            descriptionName.ForeColor = Color.DimGray;
            descriptionName.Location = new Point(249, 189);
            descriptionName.Margin = new Padding(4);
            descriptionName.Multiline = true;
            descriptionName.Name = "descriptionName";
            descriptionName.Padding = new Padding(7);
            descriptionName.PasswordChar = false;
            descriptionName.PlaceholderColor = Color.DarkGray;
            descriptionName.PlaceholderText = "Discription";
            descriptionName.Size = new Size(232, 128);
            descriptionName.TabIndex = 1;
            descriptionName.UnderlinedStyle = false;
            descriptionName.TextChanged += descriptionName_TextChanged;
            // 
            // AdminNewsEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 196, 228);
            ClientSize = new Size(906, 518);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminNewsEventsForm";
            Text = "NewsEventsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private MyControls.MyButton buttonUpload;
        private MyControls.MyTextBox imagePath;
        private Label label5;
        private MyControls.MyTextBox descriptionName;
        private MyControls.MyTextBox titleName;
        private MyControls.MyTextBox authorName;
        private MyControls.MyButton buttonImage;
        private Label label3;
    }
}