namespace DISASTER_PREPAREDNESS.AdminForms.EvacuationcCenters
{
    partial class EvacueeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvacueeListForm));
            panel2 = new Panel();
            label1 = new Label();
            evacueeDataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showLocationToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)evacueeDataGridView).BeginInit();
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
            panel2.TabIndex = 57;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(252, 16);
            label1.Name = "label1";
            label1.Size = new Size(259, 39);
            label1.TabIndex = 0;
            label1.Text = "Evacuees Information";
            // 
            // evacueeDataGridView
            // 
            evacueeDataGridView.AllowUserToDeleteRows = false;
            evacueeDataGridView.AllowUserToResizeColumns = false;
            evacueeDataGridView.AllowUserToResizeRows = false;
            evacueeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            evacueeDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            evacueeDataGridView.BackgroundColor = Color.White;
            evacueeDataGridView.BorderStyle = BorderStyle.None;
            evacueeDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            evacueeDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(224, 218, 232);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            evacueeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            evacueeDataGridView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            evacueeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            evacueeDataGridView.Dock = DockStyle.Fill;
            evacueeDataGridView.EnableHeadersVisualStyles = false;
            evacueeDataGridView.GridColor = Color.White;
            evacueeDataGridView.Location = new Point(0, 67);
            evacueeDataGridView.Name = "evacueeDataGridView";
            evacueeDataGridView.RowHeadersVisible = false;
            evacueeDataGridView.RowHeadersWidth = 40;
            evacueeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            evacueeDataGridView.Size = new Size(800, 383);
            evacueeDataGridView.TabIndex = 58;
            evacueeDataGridView.CellMouseClick += evacueeDataGridView_CellMouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip1.Size = new Size(108, 26);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // showLocationToolStripMenuItem
            // 
            showLocationToolStripMenuItem.Name = "showLocationToolStripMenuItem";
            showLocationToolStripMenuItem.Size = new Size(107, 22);
            showLocationToolStripMenuItem.Text = "Delete";
            showLocationToolStripMenuItem.Click += showLocationToolStripMenuItem_Click;
            // 
            // EvacueeListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(evacueeDataGridView);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EvacueeListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EvacueeListForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)evacueeDataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private DataGridView evacueeDataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showLocationToolStripMenuItem;
    }
}