﻿namespace DISASTER_PREPAREDNESS.ResidentForms
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
            panel2 = new Panel();
            flowLayoutPanelHazardMaps = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 60);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanelHazardMaps
            // 
            flowLayoutPanelHazardMaps.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelHazardMaps.Dock = DockStyle.Fill;
            flowLayoutPanelHazardMaps.Location = new Point(0, 60);
            flowLayoutPanelHazardMaps.Name = "flowLayoutPanelHazardMaps";
            flowLayoutPanelHazardMaps.Size = new Size(800, 390);
            flowLayoutPanelHazardMaps.TabIndex = 3;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelHazardMaps;
    }
}