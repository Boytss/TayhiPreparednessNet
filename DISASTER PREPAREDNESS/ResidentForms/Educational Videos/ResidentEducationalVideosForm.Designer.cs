namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class ResidentEducationalVideosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentEducationalVideosForm));
            panel3 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(82, 97, 184);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 88);
            panel3.TabIndex = 42;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(254, 0);
            label3.Name = "label3";
            label3.Size = new Size(273, 47);
            label3.TabIndex = 55;
            label3.Text = "Educational Videos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 59);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 54);
            label2.Name = "label2";
            label2.Size = new Size(482, 21);
            label2.TabIndex = 1;
            label2.Text = "Videos Covering Disaster Preparedness, Response, and Recovery";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(190, 196, 228);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(81, 417);
            panel1.TabIndex = 44;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(190, 196, 228);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(736, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(81, 417);
            panel4.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(190, 196, 228);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(81, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 42);
            panel2.TabIndex = 47;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(190, 196, 228);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(81, 463);
            panel5.Name = "panel5";
            panel5.Size = new Size(655, 42);
            panel5.TabIndex = 48;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(81, 130);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(655, 333);
            flowLayoutPanel.TabIndex = 49;
            // 
            // ResidentEducationalVideosForm
            // 
            ClientSize = new Size(817, 505);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "ResidentEducationalVideosForm";
            Load += ResidentEducationalVideosForm_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel;
    }
}