namespace DISASTER_PREPAREDNESS.ResidentForms.HelpfulTips
{
    partial class ResidentEvacuationRoomControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentEvacuationRoomControl));
            labelCapacity = new Label();
            labelRoomName = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCapacity
            // 
            labelCapacity.Dock = DockStyle.Bottom;
            labelCapacity.ForeColor = Color.Red;
            labelCapacity.Location = new Point(0, 113);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(150, 15);
            labelCapacity.TabIndex = 1;
            labelCapacity.Text = "label1";
            labelCapacity.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelRoomName
            // 
            labelRoomName.Dock = DockStyle.Top;
            labelRoomName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomName.Location = new Point(0, 0);
            labelRoomName.Name = "labelRoomName";
            labelRoomName.Size = new Size(150, 28);
            labelRoomName.TabIndex = 0;
            labelRoomName.Text = "label1";
            labelRoomName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(36, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(70, 70);
            panel4.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(labelCapacity);
            panel1.Controls.Add(labelRoomName);
            panel1.Location = new Point(23, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 128);
            panel1.TabIndex = 16;
            // 
            // ResidentEvacuationRoomControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ResidentEvacuationRoomControl";
            Size = new Size(202, 174);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelRoomName;
        private Label labelCapacity;
        private Panel panel4;
        private Panel panel1;
    }
}
