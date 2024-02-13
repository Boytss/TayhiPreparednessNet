namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class ResidentHelpfulTipsControl
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
            buttonPicture = new Button();
            labelDisasters = new Label();
            SuspendLayout();
            // 
            // buttonPicture
            // 
            buttonPicture.FlatAppearance.BorderColor = Color.FromArgb(56, 170, 147);
            buttonPicture.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 76);
            buttonPicture.ForeColor = Color.FromArgb(56, 170, 147);
            buttonPicture.Location = new Point(13, 14);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(122, 89);
            buttonPicture.TabIndex = 5;
            buttonPicture.Text = " ";
            buttonPicture.UseVisualStyleBackColor = true;
            buttonPicture.Click += buttonPicture_Click_1;
            // 
            // labelDisasters
            // 
            labelDisasters.Anchor = AnchorStyles.None;
            labelDisasters.AutoSize = true;
            labelDisasters.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic);
            labelDisasters.ForeColor = Color.FromArgb(32, 57, 131);
            labelDisasters.Location = new Point(46, 106);
            labelDisasters.Name = "labelDisasters";
            labelDisasters.Size = new Size(46, 18);
            labelDisasters.TabIndex = 7;
            labelDisasters.Text = "label1";
            // 
            // ResidentHelpfulTipsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(labelDisasters);
            Controls.Add(buttonPicture);
            Name = "ResidentHelpfulTipsControl";
            Size = new Size(155, 140);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPicture;
        private Label labelDisasters;
    }
}
