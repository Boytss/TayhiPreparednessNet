namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class AdminHazardMapControl
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
            labelHazardMaps = new Label();
            buttonHazardMaps = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHazardMaps);
            panel1.Controls.Add(labelHazardMaps);
            panel1.Location = new Point(16, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 259);
            panel1.TabIndex = 0;
            // 
            // labelHazardMaps
            // 
            labelHazardMaps.Dock = DockStyle.Bottom;
            labelHazardMaps.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic);
            labelHazardMaps.ForeColor = Color.FromArgb(32, 57, 131);
            labelHazardMaps.Location = new Point(0, 213);
            labelHazardMaps.Name = "labelHazardMaps";
            labelHazardMaps.Size = new Size(277, 46);
            labelHazardMaps.TabIndex = 11;
            labelHazardMaps.Text = "label1";
            labelHazardMaps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonHazardMaps
            // 
            buttonHazardMaps.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            buttonHazardMaps.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonHazardMaps.Location = new Point(14, 16);
            buttonHazardMaps.Name = "buttonHazardMaps";
            buttonHazardMaps.Size = new Size(250, 194);
            buttonHazardMaps.TabIndex = 12;
            buttonHazardMaps.UseVisualStyleBackColor = true;
            buttonHazardMaps.Click += buttonHazardMaps_Click_2;
            // 
            // AdminHazardMapControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AdminHazardMapControl";
            Size = new Size(318, 325);
            Load += HazardMapControl_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelHazardMaps;
        private Button buttonHazardMaps;
    }
}
