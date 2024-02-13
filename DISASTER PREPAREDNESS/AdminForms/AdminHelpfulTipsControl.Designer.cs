namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class AdminHelpfulTipsControl
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
            labelDisasters = new Label();
            buttonPicture = new Button();
            SuspendLayout();
            // 
            // labelDisasters
            // 
            labelDisasters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDisasters.AutoSize = true;
            labelDisasters.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic);
            labelDisasters.ForeColor = Color.FromArgb(32, 57, 131);
            labelDisasters.Location = new Point(34, 101);
            labelDisasters.Name = "labelDisasters";
            labelDisasters.Size = new Size(46, 18);
            labelDisasters.TabIndex = 4;
            labelDisasters.Text = "label1";
            // 
            // buttonPicture
            // 
            buttonPicture.FlatAppearance.BorderColor = Color.FromArgb(56, 170, 147);
            buttonPicture.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 76);
            buttonPicture.ForeColor = Color.FromArgb(56, 170, 147);
            buttonPicture.Location = new Point(12, 9);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(122, 89);
            buttonPicture.TabIndex = 3;
            buttonPicture.Text = " ";
            buttonPicture.UseVisualStyleBackColor = true;
            buttonPicture.Click += buttonPicture_Click;
            // 
            // AdminHelpfulTipsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(labelDisasters);
            Controls.Add(buttonPicture);
            Name = "AdminHelpfulTipsControl";
            Size = new Size(146, 134);
            Load += AdminHelpfulTipsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDisasters;
        private Button buttonPicture;
    }
}
