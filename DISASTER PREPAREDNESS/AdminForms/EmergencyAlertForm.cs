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

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class EmergencyAlertForm : Form
    {
        

        public EmergencyAlertForm()
        {
            InitializeComponent();

        }

        private void buttonSendAlert_Click(object sender, EventArgs e)
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
                sp.WriteLine("AT+CMGS=\"" + txtPhoneNumber.Text + "\"" + Environment.NewLine);

                // Set message content
                sp.Write(message.Text + '\x1A'); // '\x1A' is the ASCII code for Ctrl+Z (End of message)

                // Read response
                var response = sp.ReadExisting();

                if (response.Contains("ERROR"))
                {
                    MessageBox.Show("Send Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Message has been sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
