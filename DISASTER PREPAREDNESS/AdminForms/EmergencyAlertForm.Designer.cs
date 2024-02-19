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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            message = new RichTextBox();
            txtPhoneNumber = new TextBox();
            label2 = new Label();
            txtPort = new TextBox();
            label1 = new Label();
            buttonSendAlert = new Button();
            dataGridViewResidents = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 90);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(250, 54);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 1;
            label3.Text = "Manage Tips";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Sigmar One", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(198, 9);
            label4.Name = "label4";
            label4.Size = new Size(197, 45);
            label4.TabIndex = 0;
            label4.Text = "SMS ALERT";
            // 
            // panel1
            // 
            panel1.Controls.Add(message);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPort);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonSendAlert);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 605);
            panel1.TabIndex = 34;
            // 
            // message
            // 
            message.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            message.Location = new Point(14, 226);
            message.Name = "message";
            message.Size = new Size(452, 153);
            message.TabIndex = 11;
            message.Text = "";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(14, 184);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(213, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(233, 166);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 10;
            label2.Text = "PORT NUMBER";
            // 
            // txtPort
            // 
            txtPort.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPort.Location = new Point(233, 184);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(233, 23);
            txtPort.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(14, 166);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 9;
            label1.Text = "TO PHONE NUMBER";
            // 
            // buttonSendAlert
            // 
            buttonSendAlert.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSendAlert.Location = new Point(162, 405);
            buttonSendAlert.Name = "buttonSendAlert";
            buttonSendAlert.Size = new Size(175, 33);
            buttonSendAlert.TabIndex = 8;
            buttonSendAlert.Text = "SEND";
            buttonSendAlert.UseVisualStyleBackColor = true;
            buttonSendAlert.Click += buttonSendAlert_Click_1;
            // 
            // dataGridViewResidents
            // 
            dataGridViewResidents.AllowUserToDeleteRows = false;
            dataGridViewResidents.AllowUserToResizeColumns = false;
            dataGridViewResidents.AllowUserToResizeRows = false;
            dataGridViewResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewResidents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewResidents.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewResidents.BorderStyle = BorderStyle.None;
            dataGridViewResidents.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewResidents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(106, 85, 218);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 218, 232);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(106, 85, 218);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 218, 232);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewResidents.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(32, 57, 131);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewResidents.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewResidents.Dock = DockStyle.Fill;
            dataGridViewResidents.EnableHeadersVisualStyles = false;
            dataGridViewResidents.Location = new Point(481, 90);
            dataGridViewResidents.Name = "dataGridViewResidents";
            dataGridViewResidents.ReadOnly = true;
            dataGridViewResidents.RowHeadersVisible = false;
            dataGridViewResidents.RowHeadersWidth = 25;
            dataGridViewResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResidents.Size = new Size(447, 605);
            dataGridViewResidents.TabIndex = 36;
            // 
            // EmergencyAlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 695);
            Controls.Add(dataGridViewResidents);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "EmergencyAlertForm";
            Text = "EmergencyAlertForm";
            Load += EmergencyAlertForm_Load;
            Resize += EmergencyAlertForm_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private RichTextBox message;
        private TextBox txtPhoneNumber;
        private Label label2;
        private TextBox txtPort;
        private Label label1;
        private Button buttonSendAlert;
        private DataGridView dataGridViewResidents;
    }
}