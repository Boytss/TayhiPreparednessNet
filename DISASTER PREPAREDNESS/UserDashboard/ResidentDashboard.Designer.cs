namespace DISASTER_PREPAREDNESS
{
    partial class ResidentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentDashboard));
            panelMenu = new Panel();
            button1 = new Button();
            label3 = new Label();
            userLabel = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            labelDate = new Label();
            labelTime = new Label();
            buttonHelpfulTips = new Button();
            buttonNewsEvents = new Button();
            buttonEvacuationCenter = new Button();
            buttonEducationalVideos = new Button();
            buttonHazardMaps = new Button();
            buttonWeatherForecast = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            panelBrgyLogo = new FlowLayoutPanel();
            panelDesktopPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoSize = true;
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(buttonNewsEvents);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(userLabel);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(buttonHelpfulTips);
            panelMenu.Controls.Add(buttonEvacuationCenter);
            panelMenu.Controls.Add(buttonEducationalVideos);
            panelMenu.Controls.Add(buttonHazardMaps);
            panelMenu.Controls.Add(buttonWeatherForecast);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 20);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(223, 559);
            panelMenu.TabIndex = 10;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(5, 520);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(214, 39);
            button1.TabIndex = 18;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(167, 182, 243);
            label3.Location = new Point(20, 161);
            label3.Name = "label3";
            label3.Size = new Size(183, 13);
            label3.TabIndex = 17;
            label3.Text = "______________________";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.FromArgb(167, 182, 243);
            userLabel.Location = new Point(72, 86);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(71, 13);
            userLabel.TabIndex = 16;
            userLabel.Text = "RESIDENT";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(75, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(70, 70);
            panel4.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelDate);
            panel2.Controls.Add(labelTime);
            panel2.Location = new Point(27, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 40);
            panel2.TabIndex = 15;
            // 
            // labelDate
            // 
            labelDate.BackColor = Color.Transparent;
            labelDate.Dock = DockStyle.Top;
            labelDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.ForeColor = Color.FromArgb(167, 182, 243);
            labelDate.Location = new Point(0, 15);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(167, 17);
            labelDate.TabIndex = 1;
            labelDate.Text = "date";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            labelTime.BackColor = Color.Transparent;
            labelTime.Dock = DockStyle.Top;
            labelTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(0, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(167, 15);
            labelTime.TabIndex = 0;
            labelTime.Text = "date";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonHelpfulTips
            // 
            buttonHelpfulTips.FlatAppearance.BorderSize = 0;
            buttonHelpfulTips.FlatStyle = FlatStyle.Flat;
            buttonHelpfulTips.Font = new Font("Microsoft Sans Serif", 9F);
            buttonHelpfulTips.ForeColor = Color.White;
            buttonHelpfulTips.Image = (Image)resources.GetObject("buttonHelpfulTips.Image");
            buttonHelpfulTips.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelpfulTips.Location = new Point(6, 236);
            buttonHelpfulTips.Name = "buttonHelpfulTips";
            buttonHelpfulTips.Padding = new Padding(12, 0, 0, 0);
            buttonHelpfulTips.Size = new Size(214, 50);
            buttonHelpfulTips.TabIndex = 5;
            buttonHelpfulTips.Text = "  Helpful Tips";
            buttonHelpfulTips.TextAlign = ContentAlignment.MiddleLeft;
            buttonHelpfulTips.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHelpfulTips.UseVisualStyleBackColor = true;
            buttonHelpfulTips.Click += buttonHelpfulTips_Click_2;
            // 
            // buttonNewsEvents
            // 
            buttonNewsEvents.FlatAppearance.BorderSize = 0;
            buttonNewsEvents.FlatStyle = FlatStyle.Flat;
            buttonNewsEvents.Font = new Font("Microsoft Sans Serif", 9F);
            buttonNewsEvents.ForeColor = Color.White;
            buttonNewsEvents.Image = (Image)resources.GetObject("buttonNewsEvents.Image");
            buttonNewsEvents.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNewsEvents.Location = new Point(3, 348);
            buttonNewsEvents.Name = "buttonNewsEvents";
            buttonNewsEvents.Padding = new Padding(12, 0, 0, 0);
            buttonNewsEvents.Size = new Size(214, 50);
            buttonNewsEvents.TabIndex = 4;
            buttonNewsEvents.Text = "  News/Events";
            buttonNewsEvents.TextAlign = ContentAlignment.MiddleLeft;
            buttonNewsEvents.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonNewsEvents.UseVisualStyleBackColor = true;
            buttonNewsEvents.Click += buttonNewsEvents_Click_2;
            // 
            // buttonEvacuationCenter
            // 
            buttonEvacuationCenter.FlatAppearance.BorderSize = 0;
            buttonEvacuationCenter.FlatStyle = FlatStyle.Flat;
            buttonEvacuationCenter.Font = new Font("Microsoft Sans Serif", 9F);
            buttonEvacuationCenter.ForeColor = Color.White;
            buttonEvacuationCenter.Image = (Image)resources.GetObject("buttonEvacuationCenter.Image");
            buttonEvacuationCenter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEvacuationCenter.Location = new Point(2, 404);
            buttonEvacuationCenter.Name = "buttonEvacuationCenter";
            buttonEvacuationCenter.Padding = new Padding(12, 0, 0, 0);
            buttonEvacuationCenter.Size = new Size(214, 50);
            buttonEvacuationCenter.TabIndex = 3;
            buttonEvacuationCenter.Text = "  Evacuation Center";
            buttonEvacuationCenter.TextAlign = ContentAlignment.MiddleLeft;
            buttonEvacuationCenter.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEvacuationCenter.UseVisualStyleBackColor = true;
            buttonEvacuationCenter.Click += buttonEvacuationCenter_Click_2;
            // 
            // buttonEducationalVideos
            // 
            buttonEducationalVideos.FlatAppearance.BorderSize = 0;
            buttonEducationalVideos.FlatStyle = FlatStyle.Flat;
            buttonEducationalVideos.Font = new Font("Microsoft Sans Serif", 9F);
            buttonEducationalVideos.ForeColor = Color.White;
            buttonEducationalVideos.Image = (Image)resources.GetObject("buttonEducationalVideos.Image");
            buttonEducationalVideos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEducationalVideos.Location = new Point(6, 460);
            buttonEducationalVideos.Name = "buttonEducationalVideos";
            buttonEducationalVideos.Padding = new Padding(12, 0, 0, 0);
            buttonEducationalVideos.Size = new Size(214, 50);
            buttonEducationalVideos.TabIndex = 2;
            buttonEducationalVideos.Text = "  Educational Videos";
            buttonEducationalVideos.TextAlign = ContentAlignment.MiddleLeft;
            buttonEducationalVideos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEducationalVideos.UseVisualStyleBackColor = true;
            buttonEducationalVideos.Click += buttonEducationalVideos_Click_2;
            // 
            // buttonHazardMaps
            // 
            buttonHazardMaps.FlatAppearance.BorderSize = 0;
            buttonHazardMaps.FlatStyle = FlatStyle.Flat;
            buttonHazardMaps.Font = new Font("Microsoft Sans Serif", 9F);
            buttonHazardMaps.ForeColor = Color.White;
            buttonHazardMaps.Image = (Image)resources.GetObject("buttonHazardMaps.Image");
            buttonHazardMaps.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHazardMaps.Location = new Point(5, 292);
            buttonHazardMaps.Name = "buttonHazardMaps";
            buttonHazardMaps.Padding = new Padding(12, 0, 0, 0);
            buttonHazardMaps.Size = new Size(214, 50);
            buttonHazardMaps.TabIndex = 1;
            buttonHazardMaps.Text = "  Hazard Maps";
            buttonHazardMaps.TextAlign = ContentAlignment.MiddleLeft;
            buttonHazardMaps.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHazardMaps.UseVisualStyleBackColor = true;
            buttonHazardMaps.Click += buttonHazardMaps_Click_2;
            // 
            // buttonWeatherForecast
            // 
            buttonWeatherForecast.FlatAppearance.BorderSize = 0;
            buttonWeatherForecast.FlatStyle = FlatStyle.Flat;
            buttonWeatherForecast.Font = new Font("Microsoft Sans Serif", 9F);
            buttonWeatherForecast.ForeColor = Color.White;
            buttonWeatherForecast.Image = (Image)resources.GetObject("buttonWeatherForecast.Image");
            buttonWeatherForecast.ImageAlign = ContentAlignment.MiddleLeft;
            buttonWeatherForecast.Location = new Point(4, 180);
            buttonWeatherForecast.Name = "buttonWeatherForecast";
            buttonWeatherForecast.Padding = new Padding(12, 0, 0, 0);
            buttonWeatherForecast.Size = new Size(214, 50);
            buttonWeatherForecast.TabIndex = 0;
            buttonWeatherForecast.Text = "  Weather Forecast";
            buttonWeatherForecast.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonWeatherForecast.UseVisualStyleBackColor = true;
            buttonWeatherForecast.Click += buttonWeatherForecast_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(124, 146, 237);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(panelBrgyLogo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1051, 20);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(5, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 51, 76);
            label1.Location = new Point(29, 2);
            label1.Name = "label1";
            label1.Size = new Size(407, 15);
            label1.TabIndex = 17;
            label1.Text = "DISASTER PREPAREDNESS SYSTEM OF BARANGAY TAYHI, TABACO";
            // 
            // button4
            // 
            button4.Dock = DockStyle.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(991, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(20, 20);
            button4.TabIndex = 15;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1011, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 14;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1031, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(20, 20);
            button3.TabIndex = 13;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panelBrgyLogo
            // 
            panelBrgyLogo.BackColor = Color.FromArgb(51, 51, 76);
            panelBrgyLogo.BackgroundImage = (Image)resources.GetObject("panelBrgyLogo.BackgroundImage");
            panelBrgyLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelBrgyLogo.Location = new Point(0, 20);
            panelBrgyLogo.Name = "panelBrgyLogo";
            panelBrgyLogo.Size = new Size(53, 50);
            panelBrgyLogo.TabIndex = 7;
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.BorderStyle = BorderStyle.FixedSingle;
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(223, 20);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(828, 559);
            panelDesktopPanel.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ResidentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 579);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelMenu);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResidentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResidentDashboard";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button buttonHelpfulTips;
        private Button buttonNewsEvents;
        private Button buttonEvacuationCenter;
        private Button buttonEducationalVideos;
        private Button buttonHazardMaps;
        private Button buttonWeatherForecast;
        private Panel panel3;
        private FlowLayoutPanel panelBrgyLogo;
        private Panel panelDesktopPanel;
        private Button button4;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label userLabel;
        private Panel panel4;
        private Panel panel2;
        private Label labelDate;
        private Label labelTime;
        private PictureBox pictureBox2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}