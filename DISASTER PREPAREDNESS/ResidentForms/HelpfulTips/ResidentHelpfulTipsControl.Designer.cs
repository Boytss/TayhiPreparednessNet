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
            buttonPicture.BackColor = SystemColors.ActiveCaption;
            buttonPicture.FlatAppearance.BorderColor = Color.FromArgb(56, 170, 147);
            buttonPicture.FlatAppearance.BorderSize = 0;
            buttonPicture.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 76);
            buttonPicture.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonPicture.FlatStyle = FlatStyle.Flat;
            buttonPicture.ForeColor = Color.FromArgb(56, 170, 147);
            buttonPicture.Location = new Point(31, 23);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(132, 106);
            buttonPicture.TabIndex = 5;
            buttonPicture.Text = " ";
            buttonPicture.UseVisualStyleBackColor = false;
            buttonPicture.Click += buttonPicture_Click_1;
            // 
            // labelDisasters
            // 
            labelDisasters.Anchor = AnchorStyles.None;
            labelDisasters.AutoSize = true;
            labelDisasters.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDisasters.ForeColor = Color.Navy;
            labelDisasters.Location = new Point(22, 132);
            labelDisasters.Name = "labelDisasters";
            labelDisasters.Padding = new Padding(1);
            labelDisasters.Size = new Size(143, 22);
            labelDisasters.TabIndex = 8;
            labelDisasters.Text = "Volcanic Eruptions";
            labelDisasters.TextAlign = ContentAlignment.TopCenter;
            labelDisasters.Click += labelDisasters_Click;
            // 
            // ResidentHelpfulTipsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(labelDisasters);
            Controls.Add(buttonPicture);
            Name = "ResidentHelpfulTipsControl";
            Size = new Size(183, 184);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPicture;
        private Label labelDisasters;
    }
}
