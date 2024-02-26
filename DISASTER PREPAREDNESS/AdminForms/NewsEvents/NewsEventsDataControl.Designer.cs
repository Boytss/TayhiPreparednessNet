namespace DISASTER_PREPAREDNESS.AdminForms.NewsEvents
{
    partial class NewsEventsDataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelTitle = new LinkLabel();
            buttonImage = new MyControls.MyButton();
            labelDate = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(buttonImage);
            panel1.Controls.Add(labelDate);
            panel1.Location = new Point(151, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 338);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.MenuHighlight;
            labelTitle.LinkBehavior = LinkBehavior.HoverUnderline;
            labelTitle.LinkColor = Color.Blue;
            labelTitle.Location = new Point(39, 251);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(96, 25);
            labelTitle.TabIndex = 4;
            labelTitle.TabStop = true;
            labelTitle.Text = "linkLabel1";
            labelTitle.LinkClicked += labelTitle_LinkClicked;
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
            buttonImage.Location = new Point(39, 23);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(420, 220);
            buttonImage.TabIndex = 3;
            buttonImage.TextColor = Color.White;
            buttonImage.UseVisualStyleBackColor = false;
            buttonImage.Click += buttonImage_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(39, 310);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(38, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "label2";
            // 
            // NewsEventsDataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "NewsEventsDataControl";
            Size = new Size(1021, 369);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelDate;
        private MyControls.MyButton buttonImage;
        private LinkLabel labelTitle;
    }
}
