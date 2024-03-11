namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class ResidentEvacuationCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentEvacuationCenterForm));
            flowLayoutPanelEvacuation = new FlowLayoutPanel();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelEvacuation
            // 
            flowLayoutPanelEvacuation.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelEvacuation.Dock = DockStyle.Fill;
            flowLayoutPanelEvacuation.Location = new Point(0, 90);
            flowLayoutPanelEvacuation.Name = "flowLayoutPanelEvacuation";
            flowLayoutPanelEvacuation.Size = new Size(800, 360);
            flowLayoutPanelEvacuation.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 90);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(262, 12);
            label3.Name = "label3";
            label3.Size = new Size(277, 47);
            label3.TabIndex = 56;
            label3.Text = "Evacuation Centers";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(41, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 59);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ResidentEvacuationCenterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelEvacuation);
            Controls.Add(panel2);
            Name = "ResidentEvacuationCenterForm";
            Text = "ResidentAdminEvacuationCenterForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelEvacuation;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}