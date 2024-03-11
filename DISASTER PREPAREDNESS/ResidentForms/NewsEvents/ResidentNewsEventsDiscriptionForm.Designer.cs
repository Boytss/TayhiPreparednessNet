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
            panel2 = new Panel();
            label1 = new Label();
            labelDescription = new Label();
            buttonImage = new MyControls.MyButton();
            labelDate = new Label();
            labelBy = new Label();
            labelTitle = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 66);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sigmar One", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(371, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 0;
            label1.Text = "News Events";
            // 
            // labelDescription
            // 
            labelDescription.AutoEllipsis = true;
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(12, 456);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(42, 21);
            labelDescription.TabIndex = 16;
            labelDescription.Text = "Date";
            labelDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonImage
            // 
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
            labelBy.AutoSize = true;
            labelBy.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBy.Location = new Point(12, 162);
            labelBy.Name = "labelBy";
            labelBy.Size = new Size(23, 17);
            labelBy.TabIndex = 13;
            labelBy.Text = "By";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Blue;
            labelTitle.Location = new Point(12, 103);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(49, 25);
            labelTitle.TabIndex = 12;
            labelTitle.Text = "Title";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 545);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 54);
            panel1.TabIndex = 17;
            // 
            // ResidentNewsEventsDiscriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(971, 599);
            Controls.Add(panel1);
            Controls.Add(labelDescription);
            Controls.Add(buttonImage);
            Controls.Add(labelDate);
            Controls.Add(labelBy);
            Controls.Add(labelTitle);
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
        private Label labelDescription;
        private MyControls.MyButton buttonImage;
        private Label labelDate;
        private Label labelBy;
        private Label labelTitle;
        private Panel panel1;
    }
}