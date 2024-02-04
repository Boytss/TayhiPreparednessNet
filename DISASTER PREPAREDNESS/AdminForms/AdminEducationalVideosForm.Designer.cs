namespace DISASTER_PREPAREDNESS.Forms
{
    partial class AdminEducationalVideosForm
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
            txtTitle = new TextBox();
            labelTitle = new Label();
            label5 = new Label();
            txtVideoLink = new TextBox();
            buttonUpload = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(356, 47);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(178, 23);
            txtTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(297, 49);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(39, 21);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(264, 125);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 8;
            label5.Text = "Video Link";
            // 
            // txtVideoLink
            // 
            txtVideoLink.Location = new Point(356, 123);
            txtVideoLink.Name = "txtVideoLink";
            txtVideoLink.Size = new Size(178, 23);
            txtVideoLink.TabIndex = 7;
            // 
            // buttonUpload
            // 
            buttonUpload.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpload.Location = new Point(366, 165);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(81, 30);
            buttonUpload.TabIndex = 9;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // AdminEducationalVideosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpload);
            Controls.Add(label5);
            Controls.Add(txtVideoLink);
            Controls.Add(labelTitle);
            Controls.Add(txtTitle);
            Name = "AdminEducationalVideosForm";
            Text = "EducationalVideosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label labelTitle;
        private Label label5;
        private TextBox txtVideoLink;
        private Button buttonUpload;
    }
}