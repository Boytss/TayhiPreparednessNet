namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminHazardMapsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelHazardMaps = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelHazardMaps
            // 
            flowLayoutPanelHazardMaps.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelHazardMaps.Dock = DockStyle.Fill;
            flowLayoutPanelHazardMaps.Location = new Point(0, 90);
            flowLayoutPanelHazardMaps.Name = "flowLayoutPanelHazardMaps";
            flowLayoutPanelHazardMaps.Size = new Size(800, 360);
            flowLayoutPanelHazardMaps.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 90);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(309, 45);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 1;
            label2.Text = "Manage Hazard Maps";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sigmar One", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 0);
            label1.Name = "label1";
            label1.Size = new Size(613, 45);
            label1.TabIndex = 0;
            label1.Text = "Hazard Maps for Safer Communities";
            // 
            // AdminHazardMapsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelHazardMaps);
            Controls.Add(panel2);
            Name = "AdminHazardMapsForm";
            Text = "HazardMapsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private FlowLayoutPanel flowLayoutPanelHazardMaps;
        private Panel panel2;
        private Label label2;
        private Label label1;
    }
}