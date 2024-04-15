namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class ResidentTutorialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentTutorialForm));
            panel2 = new Panel();
            labelTips = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanelDisasters = new FlowLayoutPanel();
            backButton = new MyControls.MyButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(labelTips);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 60);
            panel2.TabIndex = 3;
            // 
            // labelTips
            // 
            labelTips.Anchor = AnchorStyles.None;
            labelTips.AutoSize = true;
            labelTips.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTips.ForeColor = Color.White;
            labelTips.Location = new Point(304, 6);
            labelTips.Name = "labelTips";
            labelTips.Size = new Size(383, 47);
            labelTips.TabIndex = 60;
            labelTips.Text = "Disaster Preparedness Tips";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 379);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(866, 107);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelDisasters);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(866, 319);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanelDisasters
            // 
            flowLayoutPanelDisasters.AutoScroll = true;
            flowLayoutPanelDisasters.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelDisasters.Dock = DockStyle.Fill;
            flowLayoutPanelDisasters.Location = new Point(3, 3);
            flowLayoutPanelDisasters.Name = "flowLayoutPanelDisasters";
            flowLayoutPanelDisasters.Size = new Size(800, 0);
            flowLayoutPanelDisasters.TabIndex = 59;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backButton.BackColor = Color.FromArgb(82, 97, 184);
            backButton.BackgroundColor = Color.FromArgb(82, 97, 184);
            backButton.BackgroundImage = (Image)resources.GetObject("backButton.BackgroundImage");
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.BorderColor = Color.PaleVioletRed;
            backButton.BorderRadius = 20;
            backButton.BorderSize = 0;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(812, 9);
            backButton.Name = "backButton";
            backButton.Size = new Size(42, 42);
            backButton.TabIndex = 61;
            backButton.TextColor = Color.White;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // ResidentTutorialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(866, 486);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name = "ResidentTutorialForm";
            Text = "ResidentTutorialForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label labelTips;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanelDisasters;
        private MyControls.MyButton backButton;
    }
}