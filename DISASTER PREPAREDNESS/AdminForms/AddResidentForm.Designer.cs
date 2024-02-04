namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class AddResidentForm
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
            buttonSave = new Button();
            buttonCancel = new Button();
            textMobileNumber = new TextBox();
            comboBoxPurokNumber = new ComboBox();
            textLastName = new TextBox();
            textFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textUsername = new TextBox();
            label5 = new Label();
            textPassword = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(232, 237);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 19;
            buttonSave.Text = "Add";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(232, 266);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textMobileNumber
            // 
            textMobileNumber.Location = new Point(249, 121);
            textMobileNumber.Name = "textMobileNumber";
            textMobileNumber.Size = new Size(146, 23);
            textMobileNumber.TabIndex = 17;
            // 
            // comboBoxPurokNumber
            // 
            comboBoxPurokNumber.FormattingEnabled = true;
            comboBoxPurokNumber.Items.AddRange(new object[] { "Purok 1", "Purok 2", "Purok 3", "Purok 4", "Purok 5", "Purok 6" });
            comboBoxPurokNumber.Location = new Point(249, 86);
            comboBoxPurokNumber.Name = "comboBoxPurokNumber";
            comboBoxPurokNumber.Size = new Size(146, 23);
            comboBoxPurokNumber.TabIndex = 16;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(249, 46);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(146, 23);
            textLastName.TabIndex = 15;
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(249, 12);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(146, 23);
            textFirstName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 124);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 13;
            label4.Text = "Mobile Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 86);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 12;
            label3.Text = "Purok Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 49);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 11;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 15);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 10;
            label1.Text = "First Name:";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(249, 159);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(146, 23);
            textUsername.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 162);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 20;
            label5.Text = "Username:";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(249, 198);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(146, 23);
            textPassword.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 201);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 22;
            label6.Text = "Password:";
            // 
            // AddResidentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 298);
            Controls.Add(textPassword);
            Controls.Add(label6);
            Controls.Add(textUsername);
            Controls.Add(label5);
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
            Name = "AddResidentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddResidentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textMobileNumber;
        private ComboBox comboBoxPurokNumber;
        private TextBox textLastName;
        private TextBox textFirstName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textUsername;
        private Label label5;
        private TextBox textPassword;
        private Label label6;
    }
}