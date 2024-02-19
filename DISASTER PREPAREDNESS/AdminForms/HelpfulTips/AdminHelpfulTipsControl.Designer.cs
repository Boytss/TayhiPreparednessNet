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
            labelDisasters.AutoSize = true;
            labelDisasters.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDisasters.ForeColor = Color.Navy;
            labelDisasters.Location = new Point(20, 136);
            labelDisasters.Name = "labelDisasters";
            labelDisasters.Padding = new Padding(1);
            labelDisasters.Size = new Size(143, 22);
            labelDisasters.TabIndex = 10;
            labelDisasters.Text = "Volcanic Eruptions";
            labelDisasters.TextAlign = ContentAlignment.TopCenter;
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
            buttonPicture.Location = new Point(20, 27);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(132, 106);
            buttonPicture.TabIndex = 9;
            buttonPicture.Text = " ";
            buttonPicture.UseVisualStyleBackColor = false;
            buttonPicture.Click += buttonPicture_Click_1;
            // 
            // AdminHelpfulTipsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(labelDisasters);
            Controls.Add(buttonPicture);
            Name = "AdminHelpfulTipsControl";
            Size = new Size(183, 184);
            Load += AdminHelpfulTipsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDisasters;
        private Button buttonPicture;
    }
}
