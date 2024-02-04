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
            flowLayoutPanelHazardMaps = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelHazardMaps
            // 
            flowLayoutPanelHazardMaps.AutoScroll = true;
            flowLayoutPanelHazardMaps.BackColor = Color.FromArgb(205, 205, 205);
            flowLayoutPanelHazardMaps.Dock = DockStyle.Fill;
            flowLayoutPanelHazardMaps.Location = new Point(0, 0);
            flowLayoutPanelHazardMaps.Name = "flowLayoutPanelHazardMaps";
            flowLayoutPanelHazardMaps.Size = new Size(800, 450);
            flowLayoutPanelHazardMaps.TabIndex = 0;
            // 
            // ResidentHazardMapsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelHazardMaps);
            Name = "ResidentHazardMapsForm";
            Text = "ResidentHazardMapsForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelHazardMaps;
    }
}