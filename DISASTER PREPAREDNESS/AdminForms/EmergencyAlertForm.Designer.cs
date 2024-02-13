namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class EmergencyAlertForm
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
            txtPhoneNumber = new TextBox();
            txtPort = new TextBox();
            buttonSendAlert = new Button();
            label1 = new Label();
            label2 = new Label();
            message = new RichTextBox();
            SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(174, 91);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(187, 23);
            txtPhoneNumber.TabIndex = 0;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(393, 91);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(187, 23);
            txtPort.TabIndex = 1;
            // 
            // buttonSendAlert
            // 
            buttonSendAlert.Location = new Point(354, 321);
            buttonSendAlert.Name = "buttonSendAlert";
            buttonSendAlert.Size = new Size(75, 33);
            buttonSendAlert.TabIndex = 2;
            buttonSendAlert.Text = "SEND";
            buttonSendAlert.UseVisualStyleBackColor = true;
            buttonSendAlert.Click += buttonSendAlert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 73);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 3;
            label1.Text = "TO PHONE NUMBER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 73);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "PORT NUMBER";
            label2.Click += label2_Click;
            // 
            // message
            // 
            message.Location = new Point(174, 133);
            message.Name = "message";
            message.Size = new Size(406, 153);
            message.TabIndex = 5;
            message.Text = "";
            // 
            // EmergencyAlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(message);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSendAlert);
            Controls.Add(txtPort);
            Controls.Add(txtPhoneNumber);
            Name = "EmergencyAlertForm";
            Text = "EmergencyAlertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhoneNumber;
        private TextBox txtPort;
        private Button buttonSendAlert;
        private Label label1;
        private Label label2;
        private RichTextBox message;
    }
}