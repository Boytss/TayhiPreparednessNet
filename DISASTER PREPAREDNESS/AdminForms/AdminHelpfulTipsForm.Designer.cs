namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminHelpfulTipsForm
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
            flowLayoutPanelDisasters = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 60);
            panel2.TabIndex = 0;
            // 
            // flowLayoutPanelDisasters
            // 
            flowLayoutPanelDisasters.AutoScroll = true;
            flowLayoutPanelDisasters.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelDisasters.Dock = DockStyle.Fill;
            flowLayoutPanelDisasters.Location = new Point(0, 60);
            flowLayoutPanelDisasters.Name = "flowLayoutPanelDisasters";
            flowLayoutPanelDisasters.Size = new Size(779, 369);
            flowLayoutPanelDisasters.TabIndex = 1;
            // 
            // AdminHelpfulTipsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(779, 429);
            Controls.Add(flowLayoutPanelDisasters);
            Controls.Add(panel2);
            Name = "AdminHelpfulTipsForm";
            Text = "HelpfulTipsForm";
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelDisasters;
    }
}