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
            panel1 = new Panel();
            buttonUpload = new MyControls.MyButton();
            url = new MyControls.MyTextBox();
            label5 = new Label();
            Title = new MyControls.MyTextBox();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(buttonUpload);
            panel1.Controls.Add(url);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Title);
            panel1.Location = new Point(30, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 370);
            panel1.TabIndex = 8;
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
            buttonUpload.Location = new Point(324, 222);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(129, 40);
            buttonUpload.TabIndex = 65;
            buttonUpload.Text = "Upload";
            buttonUpload.TextColor = Color.White;
            buttonUpload.UseVisualStyleBackColor = false;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // url
            // 
            url.Anchor = AnchorStyles.None;
            url.BackColor = Color.FromArgb(224, 224, 224);
            url.BorderColor = Color.MidnightBlue;
            url.BorderFocusColor = SystemColors.MenuHighlight;
            url.BorderRadius = 15;
            url.BorderSize = 1;
            url.Font = new Font("Segoe UI", 9.5F);
            url.ForeColor = Color.DimGray;
            url.Location = new Point(302, 153);
            url.Margin = new Padding(4);
            url.Multiline = false;
            url.Name = "url";
            url.Padding = new Padding(7);
            url.PasswordChar = false;
            url.PlaceholderColor = Color.DarkGray;
            url.PlaceholderText = "Video URL";
            url.Size = new Size(184, 32);
            url.TabIndex = 64;
            url.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(270, 35);
            label5.Name = "label5";
            label5.Size = new Size(240, 25);
            label5.TabIndex = 63;
            label5.Text = "Upload Educational Videos";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.BackColor = Color.FromArgb(224, 224, 224);
            Title.BorderColor = Color.MidnightBlue;
            Title.BorderFocusColor = SystemColors.MenuHighlight;
            Title.BorderRadius = 15;
            Title.BorderSize = 1;
            Title.Font = new Font("Segoe UI", 9.5F);
            Title.ForeColor = Color.DimGray;
            Title.Location = new Point(302, 96);
            Title.Margin = new Padding(4);
            Title.Multiline = false;
            Title.Name = "Title";
            Title.Padding = new Padding(7);
            Title.PasswordChar = false;
            Title.PlaceholderColor = Color.DarkGray;
            Title.PlaceholderText = "Title Name";
            Title.Size = new Size(184, 32);
            Title.TabIndex = 1;
            Title.UnderlinedStyle = false;
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
            // AdminEducationalVideosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 196, 228);
            ClientSize = new Size(868, 516);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminEducationalVideosForm";
            Text = "EducationalVideosForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label5;
        private MyControls.MyTextBox Title;
        private MyControls.MyTextBox url;
        private Panel panel2;
        private MyControls.MyButton buttonUpload;
        private Label label3;
    }
}