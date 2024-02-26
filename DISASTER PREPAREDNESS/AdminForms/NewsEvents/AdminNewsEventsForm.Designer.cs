namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminNewsEventsForm
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
            flowLayoutPanelDisasters = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelDisasters
            // 
            flowLayoutPanelDisasters.AutoScroll = true;
            flowLayoutPanelDisasters.BackColor = Color.FromArgb(190, 196, 228);
            flowLayoutPanelDisasters.Dock = DockStyle.Fill;
            flowLayoutPanelDisasters.Location = new Point(0, 90);
            flowLayoutPanelDisasters.Name = "flowLayoutPanelDisasters";
            flowLayoutPanelDisasters.Size = new Size(820, 372);
            flowLayoutPanelDisasters.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 90);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sigmar One", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 12);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 0;
            label1.Text = "News Events";
            label1.Click += label1_Click;
            // 
            // AdminNewsEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 462);
            Controls.Add(flowLayoutPanelDisasters);
            Controls.Add(panel2);
            Name = "AdminNewsEventsForm";
            Text = "NewsEventsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelDisasters;
        private Panel panel2;
        private Label label1;
    }
}