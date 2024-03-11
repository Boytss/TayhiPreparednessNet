﻿namespace DISASTER_PREPAREDNESS.ResidentForms
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanelDisasters = new FlowLayoutPanel();
            panel2 = new Panel();
            labelTips = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelDisasters);
            flowLayoutPanel1.Location = new Point(0, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 390);
            flowLayoutPanel1.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(labelTips);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 60);
            panel2.TabIndex = 3;
            // 
            // labelTips
            // 
            labelTips.Anchor = AnchorStyles.None;
            labelTips.AutoSize = true;
            labelTips.Font = new Font("Sitka Heading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTips.ForeColor = Color.White;
            labelTips.Location = new Point(205, 4);
            labelTips.Name = "labelTips";
            labelTips.Size = new Size(383, 47);
            labelTips.TabIndex = 60;
            labelTips.Text = "Disaster Preparedness Tips";
            // 
            // ResidentTutorialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "ResidentTutorialForm";
            Text = "ResidentTutorialForm";
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelDisasters;
        private Label labelTips;
    }
}