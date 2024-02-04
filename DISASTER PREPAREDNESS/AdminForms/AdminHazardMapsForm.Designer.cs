namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminHazardMapsForm
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
            label1 = new Label();
            textMapName = new TextBox();
            textDescription = new TextBox();
            label2 = new Label();
            btnBrowse = new Button();
            btnUpload = new Button();
            textBoxFilePath = new TextBox();
            flowLayoutPanelHazardMaps = new FlowLayoutPanel();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(521, 15);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Map Name";
            // 
            // textMapName
            // 
            textMapName.Location = new Point(593, 12);
            textMapName.Name = "textMapName";
            textMapName.Size = new Size(157, 23);
            textMapName.TabIndex = 1;
            // 
            // textDescription
            // 
            textDescription.Location = new Point(593, 53);
            textDescription.Name = "textDescription";
            textDescription.Size = new Size(157, 23);
            textDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(521, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(512, 93);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(609, 136);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 5;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(593, 93);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(157, 23);
            textBoxFilePath.TabIndex = 7;
            // 
            // flowLayoutPanelHazardMaps
            // 
            flowLayoutPanelHazardMaps.AutoScroll = true;
            flowLayoutPanelHazardMaps.Dock = DockStyle.Left;
            flowLayoutPanelHazardMaps.Location = new Point(0, 0);
            flowLayoutPanelHazardMaps.Name = "flowLayoutPanelHazardMaps";
            flowLayoutPanelHazardMaps.Size = new Size(506, 424);
            flowLayoutPanelHazardMaps.TabIndex = 8;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(593, 221);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // AdminHazardMapsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 424);
            Controls.Add(buttonDelete);
            Controls.Add(flowLayoutPanelHazardMaps);
            Controls.Add(textBoxFilePath);
            Controls.Add(btnUpload);
            Controls.Add(btnBrowse);
            Controls.Add(textDescription);
            Controls.Add(label2);
            Controls.Add(textMapName);
            Controls.Add(label1);
            Name = "AdminHazardMapsForm";
            Text = "HazardMapsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textMapName;
        private TextBox textDescription;
        private Label label2;
        private Button btnBrowse;
        private Button btnUpload;
        private TextBox textBoxFilePath;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanelHazardMaps;
        private Button buttonDelete;
    }
}