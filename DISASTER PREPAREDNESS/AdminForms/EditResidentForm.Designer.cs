namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class EditResidentForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textFirstName = new TextBox();
            textLastName = new TextBox();
            comboBoxPurokNumber = new ComboBox();
            textMobileNumber = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 94);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Purok Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 132);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 3;
            label4.Text = "Mobile Number:";
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(228, 20);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(146, 23);
            textFirstName.TabIndex = 4;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(228, 54);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(146, 23);
            textLastName.TabIndex = 5;
            // 
            // comboBoxPurokNumber
            // 
            comboBoxPurokNumber.FormattingEnabled = true;
            comboBoxPurokNumber.Items.AddRange(new object[] { "Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6" });
            comboBoxPurokNumber.Location = new Point(228, 94);
            comboBoxPurokNumber.Name = "comboBoxPurokNumber";
            comboBoxPurokNumber.Size = new Size(146, 23);
            comboBoxPurokNumber.TabIndex = 6;
            // 
            // textMobileNumber
            // 
            textMobileNumber.Location = new Point(228, 129);
            textMobileNumber.Name = "textMobileNumber";
            textMobileNumber.Size = new Size(146, 23);
            textMobileNumber.TabIndex = 7;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(213, 224);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(213, 172);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // EditResidentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 275);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textMobileNumber);
            Controls.Add(comboBoxPurokNumber);
            Controls.Add(textLastName);
            Controls.Add(textFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditResidentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditResidentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textFirstName;
        private TextBox textLastName;
        private ComboBox comboBoxPurokNumber;
        private TextBox textMobileNumber;
        private Button buttonCancel;
        private Button buttonSave;
    }
}