namespace DISASTER_PREPAREDNESS.ResidentForms.NewsEvents
{
    partial class ResidentNewsEventsDiscriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentNewsEventsDiscriptionForm));
            panel2 = new Panel();
            backButton = new MyControls.MyButton();
            label1 = new Label();
            buttonImage = new MyControls.MyButton();
            labelDate = new Label();
            labelBy = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            labelDescriptions = new RichTextBox();
            labelTitle = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 66);
            panel2.TabIndex = 9;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackColor = Color.FromArgb(82, 97, 184);
            backButton.BackgroundColor = Color.FromArgb(82, 97, 184);
            backButton.BackgroundImage = (Image)resources.GetObject("backButton.BackgroundImage");
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.BorderColor = Color.PaleVioletRed;
            backButton.BorderRadius = 20;
            backButton.BorderSize = 0;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(893, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(42, 42);
            backButton.TabIndex = 1;
            backButton.TextColor = Color.White;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sigmar One", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(363, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 0;
            label1.Text = "News Events";
            // 
            // buttonImage
            // 
            buttonImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonImage.BackColor = Color.MediumSlateBlue;
            buttonImage.BackgroundColor = Color.MediumSlateBlue;
            buttonImage.BorderColor = Color.Red;
            buttonImage.BorderRadius = 5;
            buttonImage.BorderSize = 2;
            buttonImage.FlatAppearance.BorderSize = 0;
            buttonImage.FlatStyle = FlatStyle.Flat;
            buttonImage.ForeColor = Color.White;
            buttonImage.Location = new Point(12, 222);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(420, 220);
            buttonImage.TabIndex = 15;
            buttonImage.TextColor = Color.White;
            buttonImage.UseVisualStyleBackColor = false;
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(12, 193);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(35, 17);
            labelDate.TabIndex = 14;
            labelDate.Text = "Date";
            // 
            // labelBy
            // 
            labelBy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelBy.AutoSize = true;
            labelBy.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBy.Location = new Point(12, 164);
            labelBy.Name = "labelBy";
            labelBy.Size = new Size(23, 17);
            labelBy.TabIndex = 13;
            labelBy.Text = "By";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 545);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 54);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(767, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 479);
            panel3.TabIndex = 19;
            panel3.Paint += panel3_Paint;
            // 
            // labelDescriptions
            // 
            labelDescriptions.BackColor = Color.FromArgb(224, 224, 224);
            labelDescriptions.BorderStyle = BorderStyle.None;
            labelDescriptions.Dock = DockStyle.Bottom;
            labelDescriptions.Font = new Font("Segoe UI", 13F);
            labelDescriptions.Location = new Point(0, 449);
            labelDescriptions.Name = "labelDescriptions";
            labelDescriptions.ReadOnly = true;
            labelDescriptions.Size = new Size(767, 96);
            labelDescriptions.TabIndex = 20;
            labelDescriptions.Text = "";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 84);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(37, 30);
            labelTitle.TabIndex = 21;
            labelTitle.Text = "By";
            // 
            // ResidentNewsEventsDiscriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(971, 599);
            Controls.Add(labelTitle);
            Controls.Add(labelDescriptions);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(buttonImage);
            Controls.Add(labelDate);
            Controls.Add(labelBy);
            Controls.Add(panel2);
            Name = "ResidentNewsEventsDiscriptionForm";
            Text = "NewsEventsDiscriptionForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private MyControls.MyButton buttonImage;
        private Label labelDate;
        private Label labelBy;
        private Label labelTitle;
        private Panel panel1;
        private MyControls.MyButton backButton;
        private Panel panel3;
        private RichTextBox labelDescriptions;
        private TextBox labelTitles;
    }
}