namespace DISASTER_PREPAREDNESS.ResidentForms.EvacuationCenters
{
    partial class ResidentEvacuationDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentEvacuationDetailsForm));
            flowLayoutPanelEvacuation = new FlowLayoutPanel();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            viewLoation = new MyControls.MyButton();
            label1 = new Label();
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
            flowLayoutPanelEvacuation.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(viewLoation);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 90);
            panel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(198, 18);
            label3.Name = "label3";
            label3.Size = new Size(438, 47);
            label3.TabIndex = 57;
            label3.Text = "Available Rooms and Capacities";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(28, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 55);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // viewLoation
            // 
            viewLoation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewLoation.BackColor = Color.MediumSlateBlue;
            viewLoation.BackgroundColor = Color.MediumSlateBlue;
            viewLoation.BackgroundImage = (Image)resources.GetObject("viewLoation.BackgroundImage");
            viewLoation.BackgroundImageLayout = ImageLayout.Stretch;
            viewLoation.BorderColor = Color.Black;
            viewLoation.BorderRadius = 0;
            viewLoation.BorderSize = 1;
            viewLoation.FlatAppearance.BorderSize = 0;
            viewLoation.FlatStyle = FlatStyle.Flat;
            viewLoation.ForeColor = Color.White;
            viewLoation.Location = new Point(702, 12);
            viewLoation.Name = "viewLoation";
            viewLoation.Size = new Size(72, 40);
            viewLoation.TabIndex = 10;
            viewLoation.TextColor = Color.White;
            viewLoation.UseVisualStyleBackColor = false;
            viewLoation.Click += viewLoation_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(698, 58);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 58;
            label1.Text = "View Location";
            // 
            // ResidentEvacuationDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelEvacuation);
            Controls.Add(panel2);
            Name = "ResidentEvacuationDetailsForm";
            Text = "ResidentEvacuationDetailsForm";
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
        private MyControls.MyButton viewLoation;
        private Label label1;
    }
}