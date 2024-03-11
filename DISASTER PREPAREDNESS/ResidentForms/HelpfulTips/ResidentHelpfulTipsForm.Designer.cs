﻿namespace DISASTER_PREPAREDNESS.ResidentForms
{
    partial class ResidentHelpfulTipsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentHelpfulTipsForm));
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            flowLayoutPanelDisasters = new FlowLayoutPanel();
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
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(211, 5);
            label3.Name = "label3";
            label3.Size = new Size(383, 47);
            label3.TabIndex = 58;
            label3.Text = "Disaster Preparedness Tips";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(36, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 59);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(199, 54);
            label2.Name = "label2";
            label2.Size = new Size(423, 21);
            label2.TabIndex = 1;
            label2.Text = "Essential Steps to Keep You Safe During or Before a Disaster";
            // 
            // flowLayoutPanelDisasters
            // 
            flowLayoutPanelDisasters.AutoScroll = true;
            flowLayoutPanelDisasters.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelDisasters.Dock = DockStyle.Fill;
            flowLayoutPanelDisasters.Location = new Point(0, 90);
            flowLayoutPanelDisasters.Name = "flowLayoutPanelDisasters";
            flowLayoutPanelDisasters.Size = new Size(800, 360);
            flowLayoutPanelDisasters.TabIndex = 2;
            // 
            // ResidentHelpfulTipsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelDisasters);
            Controls.Add(panel2);
            Name = "ResidentHelpfulTipsForm";
            Text = "ResidentHelpfulTipsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelDisasters;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}