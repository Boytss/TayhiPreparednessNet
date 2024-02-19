namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class AdminHazardMapsControl
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
            labelHazardMaps = new Label();
            buttonHazardMaps = new Button();
            SuspendLayout();
            // 
            // labelHazardMaps
            // 
            labelHazardMaps.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelHazardMaps.AutoSize = true;
            labelHazardMaps.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic);
            labelHazardMaps.ForeColor = Color.FromArgb(32, 57, 131);
            labelHazardMaps.Location = new Point(66, 186);
            labelHazardMaps.Name = "labelHazardMaps";
            labelHazardMaps.Size = new Size(46, 18);
            labelHazardMaps.TabIndex = 11;
            labelHazardMaps.Text = "label1";
            // 
            // buttonHazardMaps
            // 
            buttonHazardMaps.FlatAppearance.BorderColor = Color.FromArgb(56, 170, 147);
            buttonHazardMaps.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 51, 76);
            buttonHazardMaps.ForeColor = Color.FromArgb(56, 170, 147);
            buttonHazardMaps.Location = new Point(15, 12);
            buttonHazardMaps.Name = "buttonHazardMaps";
            buttonHazardMaps.Size = new Size(180, 174);
            buttonHazardMaps.TabIndex = 10;
            buttonHazardMaps.Text = " ";
            buttonHazardMaps.UseVisualStyleBackColor = true;
            buttonHazardMaps.Click += buttonHazardMaps_Click;
            // 
            // AdminHazardMapsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHazardMaps);
            Controls.Add(buttonHazardMaps);
            Name = "AdminHazardMapsControl";
            Size = new Size(211, 217);
            Load += AdminHazardMapsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHazardMaps;
        private Button buttonHazardMaps;
    }
}
