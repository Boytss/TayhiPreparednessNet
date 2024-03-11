namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class ResidentHazardMapsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentHazardMapsForm));
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            flowLayoutPanelHazardMaps = new FlowLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 90);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(166, 4);
            label3.Name = "label3";
            label3.Size = new Size(505, 47);
            label3.TabIndex = 58;
            label3.Text = "Hazard Maps for Safer Communities";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(23, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 59);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(163, 53);
            label2.Name = "label2";
            label2.Size = new Size(534, 21);
            label2.TabIndex = 1;
            label2.Text = "Understanding and Mitigating Environmental Risks through Visualized Data";
            // 
            // flowLayoutPanelHazardMaps
            // 
            flowLayoutPanelHazardMaps.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelHazardMaps.Dock = DockStyle.Fill;
            flowLayoutPanelHazardMaps.Location = new Point(0, 90);
            flowLayoutPanelHazardMaps.Name = "flowLayoutPanelHazardMaps";
            flowLayoutPanelHazardMaps.Size = new Size(800, 360);
            flowLayoutPanelHazardMaps.TabIndex = 5;
            // 
            // ResidentHazardMapsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelHazardMaps);
            Controls.Add(panel2);
            Name = "ResidentHazardMapsForm";
            Text = "ResidentHazardMapsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelHazardMaps;
        private PictureBox pictureBox1;
        private Label label3;
    }
}