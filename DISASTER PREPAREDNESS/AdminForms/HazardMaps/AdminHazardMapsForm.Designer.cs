namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminHazardMapsForm
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
            buttonMapName = new MyControls.MyTextBox();
            Upload = new MyControls.MyButton();
            buttoChoose = new MyControls.MyButton();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 90);
            panel2.TabIndex = 6;
            // 
            // buttonMapName
            // 
            buttonMapName.Anchor = AnchorStyles.None;
            buttonMapName.BackColor = Color.FromArgb(224, 224, 224);
            buttonMapName.BorderColor = Color.MidnightBlue;
            buttonMapName.BorderFocusColor = SystemColors.MenuHighlight;
            buttonMapName.BorderRadius = 15;
            buttonMapName.BorderSize = 1;
            buttonMapName.Font = new Font("Segoe UI", 9.5F);
            buttonMapName.ForeColor = Color.DimGray;
            buttonMapName.Location = new Point(286, 196);
            buttonMapName.Margin = new Padding(4);
            buttonMapName.Multiline = false;
            buttonMapName.Name = "buttonMapName";
            buttonMapName.Padding = new Padding(7);
            buttonMapName.PasswordChar = false;
            buttonMapName.PlaceholderColor = Color.DarkGray;
            buttonMapName.PlaceholderText = "Map Name";
            buttonMapName.Size = new Size(184, 32);
            buttonMapName.TabIndex = 1;
            buttonMapName.UnderlinedStyle = false;
            // 
            // Upload
            // 
            Upload.Anchor = AnchorStyles.None;
            Upload.BackColor = Color.MediumSlateBlue;
            Upload.BackgroundColor = Color.MediumSlateBlue;
            Upload.BorderColor = Color.PaleVioletRed;
            Upload.BorderRadius = 20;
            Upload.BorderSize = 0;
            Upload.FlatAppearance.BorderSize = 0;
            Upload.FlatStyle = FlatStyle.Flat;
            Upload.ForeColor = Color.White;
            Upload.Location = new Point(320, 251);
            Upload.Name = "Upload";
            Upload.Size = new Size(129, 40);
            Upload.TabIndex = 2;
            Upload.Text = "Upload";
            Upload.TextColor = Color.White;
            Upload.UseVisualStyleBackColor = false;
            Upload.Click += Upload_Click;
            // 
            // buttoChoose
            // 
            buttoChoose.Anchor = AnchorStyles.None;
            buttoChoose.BackColor = Color.FromArgb(224, 224, 224);
            buttoChoose.BackgroundColor = Color.FromArgb(224, 224, 224);
            buttoChoose.BorderColor = Color.MidnightBlue;
            buttoChoose.BorderRadius = 0;
            buttoChoose.BorderSize = 1;
            buttoChoose.FlatAppearance.BorderSize = 0;
            buttoChoose.FlatStyle = FlatStyle.Flat;
            buttoChoose.ForeColor = Color.Black;
            buttoChoose.Location = new Point(286, 48);
            buttoChoose.Name = "buttoChoose";
            buttoChoose.Size = new Size(184, 141);
            buttoChoose.TabIndex = 3;
            buttoChoose.Text = "Choose Image";
            buttoChoose.TextColor = Color.Black;
            buttoChoose.UseVisualStyleBackColor = false;
            buttoChoose.Click += buttoChoose_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttoChoose);
            panel1.Controls.Add(Upload);
            panel1.Controls.Add(buttonMapName);
            panel1.Location = new Point(23, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 304);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(287, 0);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 63;
            label5.Text = "Upload Hazard Map";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(289, 18);
            label1.Name = "label1";
            label1.Size = new Size(195, 47);
            label1.TabIndex = 1;
            label1.Text = "Hazard Maps";
            // 
            // AdminHazardMapsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 196, 228);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminHazardMapsForm";
            Text = "HazardMapsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Panel panel2;
        private MyControls.MyTextBox buttonMapName;
        private MyControls.MyButton Upload;
        private MyControls.MyButton buttoChoose;
        private Panel panel1;
        private Label label5;
        private Label label1;
    }
}