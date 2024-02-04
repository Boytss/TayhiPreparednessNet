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
            labelDescription = new Label();
            labelMapName = new Label();
            pictureBoxMap = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(97, 227);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(43, 17);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "label1";
            labelDescription.Click += labelMapName_Click;
            // 
            // labelMapName
            // 
            labelMapName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMapName.AutoSize = true;
            labelMapName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMapName.Location = new Point(84, 9);
            labelMapName.Name = "labelMapName";
            labelMapName.Size = new Size(65, 25);
            labelMapName.TabIndex = 1;
            labelMapName.Text = "label1";
            // 
            // pictureBoxMap
            // 
            pictureBoxMap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxMap.Location = new Point(11, 11);
            pictureBoxMap.Name = "pictureBoxMap";
            pictureBoxMap.Size = new Size(162, 166);
            pictureBoxMap.TabIndex = 2;
            pictureBoxMap.TabStop = false;
            pictureBoxMap.Click += pictureBoxMap_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBoxMap);
            panel1.Location = new Point(30, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 187);
            panel1.TabIndex = 3;
            // 
            // AdminHazardMapControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(labelDescription);
            Controls.Add(labelMapName);
            Name = "AdminHazardMapControl";
            Size = new Size(244, 245);
            Load += HazardMapControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDescription;
        private Label labelMapName;
        private PictureBox pictureBoxMap;
        private Panel panel1;
    }
}
