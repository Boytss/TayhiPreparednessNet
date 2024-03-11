namespace DISASTER_PREPAREDNESS.ResidentForms.NewsEvents
{
    partial class ResidentNewsEventsDataControl
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
            buttonImage = new MyControls.MyButton();
            panel1 = new Panel();
            linkTitle = new LinkLabel();
            labelDate = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(linkTitle);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(buttonImage);
            panel1.Location = new Point(180, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 338);
            panel1.TabIndex = 1;
            // 
            // linkTitle
            // 
            linkTitle.AutoSize = true;
            linkTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkTitle.LinkBehavior = LinkBehavior.HoverUnderline;
            linkTitle.LinkColor = Color.Blue;
            linkTitle.Location = new Point(39, 246);
            linkTitle.Name = "linkTitle";
            linkTitle.Size = new Size(80, 21);
            linkTitle.TabIndex = 9;
            linkTitle.TabStop = true;
            linkTitle.Text = "linkLabel1";
            linkTitle.TextAlign = ContentAlignment.MiddleLeft;
            linkTitle.LinkClicked += linkTitle_LinkClicked_3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(39, 314);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(38, 15);
            labelDate.TabIndex = 8;
            labelDate.Text = "label2";
            labelDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ResidentNewsEventsDataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "ResidentNewsEventsDataControl";
            Size = new Size(860, 369);
            Load += ResidentNewsEventsDataControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MyControls.MyButton buttonImage;
        private Panel panel1;
        private LinkLabel linkTitle;
        private Label labelDate;
        private Panel panel2;
    }
}
