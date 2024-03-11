namespace DISASTER_PREPAREDNESS.ResidentForms.EvacuationCenters
{
    partial class ResidentEvacuationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            labelAddress = new Label();
            buttonEvacuation = new MyControls.MyButton();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(labelAddress);
            panel2.Controls.Add(buttonEvacuation);
            panel2.Location = new Point(19, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 194);
            panel2.TabIndex = 0;
            // 
            // labelAddress
            // 
            labelAddress.Dock = DockStyle.Bottom;
            labelAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(0, 170);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(188, 24);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "label1";
            labelAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonEvacuation
            // 
            buttonEvacuation.BackColor = SystemColors.ActiveCaption;
            buttonEvacuation.BackgroundColor = SystemColors.ActiveCaption;
            buttonEvacuation.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEvacuation.BorderColor = Color.Blue;
            buttonEvacuation.BorderRadius = 0;
            buttonEvacuation.BorderSize = 1;
            buttonEvacuation.FlatAppearance.BorderSize = 0;
            buttonEvacuation.FlatStyle = FlatStyle.Flat;
            buttonEvacuation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEvacuation.ForeColor = Color.White;
            buttonEvacuation.Location = new Point(17, 17);
            buttonEvacuation.Name = "buttonEvacuation";
            buttonEvacuation.Size = new Size(150, 150);
            buttonEvacuation.TabIndex = 3;
            buttonEvacuation.Text = "myButton1";
            buttonEvacuation.TextColor = Color.White;
            buttonEvacuation.UseVisualStyleBackColor = false;
            buttonEvacuation.Click += buttonEvacuation_Click_2;
            // 
            // ResidentEvacuationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "ResidentEvacuationControl";
            Size = new Size(225, 244);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelAddress;
        private MyControls.MyButton buttonEvacuation;
    }
}
