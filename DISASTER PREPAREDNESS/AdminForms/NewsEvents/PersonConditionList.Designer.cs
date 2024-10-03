namespace DISASTER_PREPAREDNESS.AdminForms.NewsEvents
{
    partial class PersonConditionList
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
            personByConditionDataGridView = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)personByConditionDataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // personByConditionDataGridView
            // 
            personByConditionDataGridView.AllowUserToDeleteRows = false;
            personByConditionDataGridView.AllowUserToResizeColumns = false;
            personByConditionDataGridView.AllowUserToResizeRows = false;
            personByConditionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            personByConditionDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            personByConditionDataGridView.BackgroundColor = Color.White;
            personByConditionDataGridView.BorderStyle = BorderStyle.None;
            personByConditionDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            personByConditionDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 218, 232);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            personByConditionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            personByConditionDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            personByConditionDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            personByConditionDataGridView.Dock = DockStyle.Fill;
            personByConditionDataGridView.EnableHeadersVisualStyles = false;
            personByConditionDataGridView.Location = new Point(0, 67);
            personByConditionDataGridView.Name = "personByConditionDataGridView";
            personByConditionDataGridView.RowHeadersVisible = false;
            personByConditionDataGridView.RowHeadersWidth = 40;
            personByConditionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personByConditionDataGridView.Size = new Size(800, 383);
            personByConditionDataGridView.TabIndex = 61;
            personByConditionDataGridView.CellContentClick += personByConditionDataGridView_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 67);
            panel2.TabIndex = 60;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 39);
            label1.TabIndex = 0;
            label1.Text = "Affected Person";
            // 
            // PersonConditionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(personByConditionDataGridView);
            Controls.Add(panel2);
            Name = "PersonConditionList";
            Text = "PersonConditionList";
            ((System.ComponentModel.ISupportInitialize)personByConditionDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView personByConditionDataGridView;
        private Panel panel2;
        private Label label1;
    }
}