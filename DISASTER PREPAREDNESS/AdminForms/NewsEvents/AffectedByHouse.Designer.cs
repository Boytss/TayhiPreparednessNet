namespace DISASTER_PREPAREDNESS.AdminForms.NewsEvents
{
    partial class AffectedByHouse
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label1 = new Label();
            affectedByHouseDataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showLocationToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)affectedByHouseDataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 97, 184);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 67);
            panel2.TabIndex = 58;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 11);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 0;
            label1.Text = "Affected House";
            // 
            // affectedByHouseDataGridView
            // 
            affectedByHouseDataGridView.AllowUserToDeleteRows = false;
            affectedByHouseDataGridView.AllowUserToResizeColumns = false;
            affectedByHouseDataGridView.AllowUserToResizeRows = false;
            affectedByHouseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            affectedByHouseDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            affectedByHouseDataGridView.BackgroundColor = Color.White;
            affectedByHouseDataGridView.BorderStyle = BorderStyle.None;
            affectedByHouseDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            affectedByHouseDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 218, 232);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            affectedByHouseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            affectedByHouseDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            affectedByHouseDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            affectedByHouseDataGridView.Dock = DockStyle.Fill;
            affectedByHouseDataGridView.EnableHeadersVisualStyles = false;
            affectedByHouseDataGridView.Location = new Point(0, 67);
            affectedByHouseDataGridView.Name = "affectedByHouseDataGridView";
            affectedByHouseDataGridView.RowHeadersVisible = false;
            affectedByHouseDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            affectedByHouseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            affectedByHouseDataGridView.Size = new Size(800, 383);
            affectedByHouseDataGridView.TabIndex = 59;
            affectedByHouseDataGridView.CellContentClick += affectedByHouseDataGridView_CellContentClick_1;
            affectedByHouseDataGridView.CellMouseClick += affectedByHouseDataGridView_CellMouseClick_1;
            affectedByHouseDataGridView.MouseClick += affectedByHouseDataGridView_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(153, 26);
            // 
            // showLocationToolStripMenuItem
            // 
            showLocationToolStripMenuItem.Name = "showLocationToolStripMenuItem";
            showLocationToolStripMenuItem.Size = new Size(152, 22);
            showLocationToolStripMenuItem.Text = "Show Location";
            // 
            // AffectedByHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(affectedByHouseDataGridView);
            Controls.Add(panel2);
            Name = "AffectedByHouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AffectedByHouse";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)affectedByHouseDataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private DataGridView affectedByHouseDataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showLocationToolStripMenuItem;
    }
}