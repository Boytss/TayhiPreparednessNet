namespace DISASTER_PREPAREDNESS.AdminForms
{
    partial class AdminManageResidenceForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageResidenceForm));
            dataGridViewResidents = new DataGridView();
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            panel2 = new Panel();
            buttonSearch = new Button();
            textSearch = new TextBox();
            labelSearch = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewResidents
            // 
            dataGridViewResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewResidents.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewResidents.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewResidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewResidents.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewResidents.Dock = DockStyle.Fill;
            dataGridViewResidents.Location = new Point(0, 0);
            dataGridViewResidents.Name = "dataGridViewResidents";
            dataGridViewResidents.Size = new Size(458, 236);
            dataGridViewResidents.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonAdd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(458, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(112, 331);
            panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(51, 51, 76);
            buttonDelete.Dock = DockStyle.Top;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.TopLeft;
            buttonDelete.Location = new Point(0, 120);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(6, 0, 0, 0);
            buttonDelete.Size = new Size(112, 60);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "  Delete";
            buttonDelete.TextAlign = ContentAlignment.MiddleLeft;
            buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(51, 51, 76);
            buttonEdit.Dock = DockStyle.Top;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageAlign = ContentAlignment.TopLeft;
            buttonEdit.Location = new Point(0, 60);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(6, 0, 0, 0);
            buttonEdit.Size = new Size(112, 60);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "  Edit";
            buttonEdit.TextAlign = ContentAlignment.MiddleLeft;
            buttonEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click_1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(51, 51, 76);
            buttonAdd.Dock = DockStyle.Top;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.ImageAlign = ContentAlignment.TopLeft;
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(6, 0, 0, 0);
            buttonAdd.Size = new Size(112, 60);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "  Add";
            buttonAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(buttonSearch);
            panel2.Controls.Add(textSearch);
            panel2.Controls.Add(labelSearch);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 95);
            panel2.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.ForeColor = SystemColors.ButtonHighlight;
            buttonSearch.Location = new Point(230, 11);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textSearch
            // 
            textSearch.BackColor = SystemColors.InactiveBorder;
            textSearch.BorderStyle = BorderStyle.FixedSingle;
            textSearch.Location = new Point(47, 11);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(177, 23);
            textSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.ForeColor = SystemColors.ButtonHighlight;
            labelSearch.Location = new Point(0, 14);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(41, 15);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "search";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewResidents);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 236);
            panel3.TabIndex = 3;
            // 
            // AdminManageResidenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 331);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminManageResidenceForm";
            Text = "ManageResidenceForm";
            Load += ManageResidenceForm_Load_1;
            Resize += ManageResidenceForm_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidents).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewResidents;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textSearch;
        private Label labelSearch;
        private Button buttonSearch;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}