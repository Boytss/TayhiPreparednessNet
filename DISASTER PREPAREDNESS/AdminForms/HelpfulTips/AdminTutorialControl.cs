using DISASTER_PREPAREDNESS.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class AdminTutorialControl : UserControl
    {
        private RichTextBox richTextBoxTutorial;
        private string originalText;
        private string disasterName;
        public AdminTutorialControl(string tutorialText, string disasterName)
        {
            InitializeComponent();
            SetTutorialText(tutorialText); // Set the initial text from the database
            originalText = tutorialText;
            this.disasterName = disasterName;
        }
        public void SetTutorialText(string text)
        {
            labelTutorialText.Text = text;
        }
        private void labelTutorialText_Click(object sender, EventArgs e)
        {
           
        }
        private void RichTextBoxTutorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                // Save changes when Ctrl + Enter key is pressed
                SaveTutorialText();
                // Prevent the TextBox from inserting a new line
                e.SuppressKeyPress = true;
            }
        }

       

        private void SaveTutorialText()
        {
            if (richTextBoxTutorial != null)
            {
                string newText = richTextBoxTutorial.Text;
                labelTutorialText.Text = newText;
                richTextBoxTutorial.Dispose();
                labelTutorialText.Visible = true;
                UpdateDatabase(newText);
            }
        }
        private void UpdateDatabase(string newText)
        {
            try
            {
                // Update the database with the new text
                // Update the database with the new text
                DisasterDataAccess.UpdateTutorialText(disasterName, newText); // Use the stored disaster name
                MessageBox.Show("Tutorial text updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating tutorial text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelTutorialText_Click_1(object sender, EventArgs e)
        {
            richTextBoxTutorial = new RichTextBox
            {
                Text = labelTutorialText.Text,
                Location = labelTutorialText.Location,
                Size = labelTutorialText.Size,
                Font = labelTutorialText.Font,
                BorderStyle = BorderStyle.None,
                ScrollBars = RichTextBoxScrollBars.None,
                BackColor = Color.FromArgb(190, 196, 228),
                ForeColor = Color.FromArgb(32, 57, 131),

                Multiline = true // Set Multiline property to true
                
                
            };
            richTextBoxTutorial.KeyDown += RichTextBoxTutorial_KeyDown;
           

            this.Controls.Add(richTextBoxTutorial);
            labelTutorialText.Visible = false;
            richTextBoxTutorial.Focus();
        }
    }
}
