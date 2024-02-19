using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using DISASTER_PREPAREDNESS.DataAccess;

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class EmergencyAlertForm : Form
    {


        public EmergencyAlertForm()
        {
            InitializeComponent();
            ConfigureDataGridView();

            // Attach the Resize event handler
            this.Resize += EmergencyAlertForm_Resize;


            AddShadow(panel2);
            // Scroll Bars
            dataGridViewResidents.ScrollBars = ScrollBars.Both;
        }
        private void AddShadow(Panel panel)
        {
            // Create a new label to act as the shadow
            Label shadowLabel = new Label();
            shadowLabel.BackColor = Color.FromArgb(30, Color.Black); // Semi-transparent black
            shadowLabel.AutoSize = false;
            shadowLabel.Size = new Size(panel.Width, panel.Height);
            shadowLabel.Location = new Point(panel.Location.X + 5, panel.Location.Y + 5); // Adjust shadow position
            shadowLabel.SendToBack(); // Send shadow to back so it appears behind the panel

            // Add the shadow label to the form's controls
            this.Controls.Add(shadowLabel);
        }
        private void LoadResidentsData()
        {
            try
            {
                // Fetch resident data from the database
                DataTable residentsContactDataTable = ResidentDataAccess.GetAllResidentContacts();

                // Display the data in the DataGridView
                dataGridViewResidents.DataSource = residentsContactDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading residents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSendAlert_Click(object sender, EventArgs e)
        {
            //SerialPort sp = new SerialPort();
            //try
            //{
            //    // Configure serial port
            //    sp.PortName = txtPort.Text;
            //    sp.Open();

            //    // Set write timeout to 1000 milliseconds (1 second)
            //    sp.WriteTimeout = 1000;

            //    // Set SMS text mode
            //    sp.WriteLine("AT+CMGF=1" + Environment.NewLine);

            //    // Set recipient phone number
            //    sp.WriteLine("AT+CMGS=\"" + txtPhoneNumber.Text + "\"" + Environment.NewLine);

            //    // Set message content
            //    sp.Write(message.Text + '\x1A'); // '\x1A' is the ASCII code for Ctrl+Z (End of message)

            //    // Read response
            //    var response = sp.ReadExisting();

            //    if (response.Contains("ERROR"))
            //    {
            //        MessageBox.Show("Send Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Message has been sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    // Close the serial port when done
            //    if (sp.IsOpen)
            //        sp.Close();
            //}
            // Create a list to store selected phone numbers

        }
        private void SendSMS(string phoneNumber, string message)
        {
            SerialPort sp = new SerialPort();
            try
            {
                // Configure serial port
                sp.PortName = txtPort.Text;
                sp.Open();

                // Set write timeout to 1000 milliseconds (1 second)
                sp.WriteTimeout = 1000;

                // Set SMS text mode
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);

                // Set recipient phone number
                sp.WriteLine("AT+CMGS=\"" + phoneNumber + "\"" + Environment.NewLine);

                // Set message content
                sp.Write(message + '\x1A'); // '\x1A' is the ASCII code for Ctrl+Z (End of message)

                // Read response
                var response = sp.ReadExisting();

                if (response.Contains("ERROR"))
                {
                    MessageBox.Show("Send Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Message has been sent to " + phoneNumber, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the serial port when done
                if (sp.IsOpen)
                    sp.Close();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void EmergencyAlertForm_Load(object sender, EventArgs e)
        {
            LoadResidentsData();

        }

        private void EmergencyAlertForm_Resize(object sender, EventArgs e)
        {
            AdjustColumnSizes();
        }
        private void ConfigureDataGridView()
        {


            // Set AutoSizeMode for columns
            foreach (DataGridViewColumn column in dataGridViewResidents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // If binding to a data source, reload it
            // Example: dataGridViewResidents.DataSource = yourDataSource;

            // Adjust column sizes initially
            AdjustColumnSizes();
        }
        private void AdjustColumnSizes()
        {
            // Manually adjust column sizes based on form size
            foreach (DataGridViewColumn column in dataGridViewResidents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void buttonSendAlert_Click_1(object sender, EventArgs e)
        {
            List<string> selectedPhoneNumbers = new List<string>();

            try
            {
                // Iterate through selected DataGridView rows
                foreach (DataGridViewRow row in dataGridViewResidents.SelectedRows)
                {
                    // Retrieve the phone number
                    string phoneNumber = row.Cells["MobileNumber"].Value.ToString();
                    selectedPhoneNumbers.Add(phoneNumber);
                }

                // Iterate through selected phone numbers and send SMS alerts
                foreach (string phoneNumber in selectedPhoneNumbers)
                {
                    SendSMS(phoneNumber, message.Text);
                }

                MessageBox.Show("SMS alerts have been sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending SMS alerts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
