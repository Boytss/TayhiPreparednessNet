namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class AdminTutorialControl
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
            labelTutorialText.AutoSize = true;
            labelTutorialText.Dock = DockStyle.Fill;
            labelTutorialText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic);
            labelTutorialText.ForeColor = Color.FromArgb(32, 57, 131);
            labelTutorialText.Location = new Point(0, 0);
            labelTutorialText.Name = "labelTutorialText";
            labelTutorialText.Size = new Size(46, 18);
            labelTutorialText.TabIndex = 0;
            labelTutorialText.Text = "label1";
            labelTutorialText.Click += labelTutorialText_Click;
            // 
            // AdminTutorialControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(labelTutorialText);
            Name = "AdminTutorialControl";
            Size = new Size(216, 196);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTutorialText;
    }
}
