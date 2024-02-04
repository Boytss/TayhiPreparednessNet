﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DISASTER_PREPAREDNESS.ResidentForms;
namespace DISASTER_PREPAREDNESS
{
    public partial class ResidentDashboard : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public ResidentDashboard()
        {
            InitializeComponent();
            random = new Random();

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ModernUI.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ModernUI.ColorList.Count);
            }
            tempIndex = index;
            string color = ModernUI.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHome.Text = childForm.Text;
        }



        private void buttonWeather_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonHazardMaps_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonEducationalVideos_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonEvacuationCenter_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonNewsEvents_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonHelpfulTips_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with log out
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            // If the user clicks No, the log out action is canceled.
        }

        private void buttonWeather_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentWeatherForm(), sender);

        }

        private void buttonHazardMaps_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentHazardMapsForm(), sender);

        }

        private void buttonEducationalVideos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentEducationalVideosForm(), sender);

        }

        private void buttonEvacuationCenter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentAdminEvacuationCenterForm(), sender);

        }

        private void buttonNewsEvents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentNewsEventsForm(), sender);

        }

        private void buttonHelpfulTips_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ResidentHelpfulTipsForm(), sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with log out
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}