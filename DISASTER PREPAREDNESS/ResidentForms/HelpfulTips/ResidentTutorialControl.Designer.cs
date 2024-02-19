namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class ResidentTutorialControl
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
            labelTutorialText = new Label();
            SuspendLayout();
            // 
            // labelTutorialText
            // 
            labelTutorialText.AutoEllipsis = true;
            labelTutorialText.AutoSize = true;
            labelTutorialText.Dock = DockStyle.Fill;
            labelTutorialText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTutorialText.ForeColor = Color.FromArgb(32, 57, 131);
            labelTutorialText.ImageAlign = ContentAlignment.TopCenter;
            labelTutorialText.Location = new Point(0, 0);
            labelTutorialText.Name = "labelTutorialText";
            labelTutorialText.Size = new Size(51, 20);
            labelTutorialText.TabIndex = 1;
            labelTutorialText.Text = "label1";
            // 
            // ResidentTutorialControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(labelTutorialText);
            Name = "ResidentTutorialControl";
            Size = new Size(425, 252);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTutorialText;
    }
}
