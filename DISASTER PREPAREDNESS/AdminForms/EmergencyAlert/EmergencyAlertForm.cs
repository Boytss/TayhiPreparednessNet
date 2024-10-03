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
using Newtonsoft.Json;
using DISASTER_PREPAREDNESS.AdminForms.EmergencyAlert;
using static DISASTER_PREPAREDNESS.AdminForms.EmergencyAlert.AlertResponse;
using Newtonsoft.Json.Linq;
using RestSharp;
using static DISASTER_PREPAREDNESS.ResidentForms.ResidentWeatherForm;

namespace DISASTER_PREPAREDNESS.AdminForms
{
    public partial class EmergencyAlertForm : Form
    {
        private const string LocationId = "6644d1a729f448327f1641dd"; // Your location ID
        private const string ApiKey = "FgQuEGbzfpdpIMvWiKhfAZUvnieC0FGe"; // Your Tomorrow.io API key

        public EmergencyAlertForm()
        {
            InitializeComponent();
            ConfigureDataGridView();

            // Attach the Resize event handler
            this.Resize += EmergencyAlertForm_Resize;
      

            // Scroll Bars
            dataGridViewResidents.ScrollBars = ScrollBars.Both;
        }
        //
        #region Load Data
        private void LoadResidentsData()
        {
            try
            {
                // Fetch resident data from the database
                DataTable residentsContactDataTable = ResidentDataAccess.GetAllResidentContacts();

                // Display the data in the DataGridView
                dataGridViewResidents.DataSource = residentsContactDataTable;
                // Set column header text
                dataGridViewResidents.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewResidents.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewResidents.Columns["PurokNumber"].HeaderText = "Purok Number";
                dataGridViewResidents.Columns["MobileNumber"].HeaderText = "Mobile Number";
                dataGridViewResidents.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading residents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        //
        ///
        #region SMS Functionality
        private void SendSMS(string phoneNumber, string message)
        {
            SerialPort sp = new SerialPort();
            try
            {
                // Configure serial port
                //sp.PortName = txtPort.Texts;
                sp.PortName = "COM6";
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
        #endregion
        ///
        private void label2_Click(object sender, EventArgs e)
        {


        }

       
        //
        #region Signal Details
        public enum PSWSSignalNumber
        {
            NoSignal,
            SignalNo1,
            SignalNo2,
            SignalNo3,
            SignalNo4
        }
        public enum TCWSSignalNumber
        {
            NoSignal,
            SignalNo1,
            SignalNo2,
            SignalNo3,
            SignalNo4,
            SignalNo5
        }
        public enum TemperatureWarningLevel
        {
            NoWarning,
            CautionWarning,
            ExtremeWarning,
            DangerWarning
        }
        #endregion
        //
        //
        #region Weather Conditions
        private PSWSSignalNumber PreciptionLevel(double precipitationIntensity)
        {
            // Define the criteria for each PSWS signal number based on the precipitation intensity
            if (precipitationIntensity >= 30.0 && precipitationIntensity < 60.0)
            {
                return PSWSSignalNumber.SignalNo1;
            }
            else if (precipitationIntensity >= 60.0 && precipitationIntensity < 100.0)
            {
                return PSWSSignalNumber.SignalNo2;
            }
            else if (precipitationIntensity >= 100.0 && precipitationIntensity < 150.0)
            {
                return PSWSSignalNumber.SignalNo3;
            }
            else if (precipitationIntensity >= 150.0)
            {
                return PSWSSignalNumber.SignalNo4;
            }
            else
            {
                return PSWSSignalNumber.NoSignal; // No significant rainfall
            }
        }
        private TCWSSignalNumber DetermineWindConditionLevel(double windSpeed)
        {
            // Define the criteria for each TCWS signal number based on the wind speed
            if (windSpeed >= 22.0 && windSpeed < 34.0) // 39-61 km/h (22-33 kt, 10.8-17.1 m/s)
            {
                return TCWSSignalNumber.SignalNo1;
            }
            else if (windSpeed >= 34.0 && windSpeed < 48.0) // 62-88 km/h (34-47 kt, 17.2-24.4 m/s)
            {
                return TCWSSignalNumber.SignalNo2;
            }
            else if (windSpeed >= 48.0 && windSpeed < 64.0) // 89-117 km/h (48-63 kt, 24.5-32.6 m/s)
            {
                return TCWSSignalNumber.SignalNo3;
            }
            else if (windSpeed >= 64.0 && windSpeed < 100.0) // 118-184 km/h (64-99 kt, 32.7-51.2 m/s)
            {
                return TCWSSignalNumber.SignalNo4;
            }
            else if (windSpeed >= 100.0) // 185 km/h or higher (100 kt or higher, 51.3 m/s or higher)
            {
                return TCWSSignalNumber.SignalNo5;
            }
            else
            {
                return TCWSSignalNumber.NoSignal; // No significant wind threat
            }
        }
        private TemperatureWarningLevel DetermineTemperatureWarningLevel(double temperature)
        {
            // Define the criteria for each temperature warning level based on the temperature value
            if (temperature >= 35.0 && temperature < 38.0)
            //if (temperature >= 28.0 && temperature < 38.0)
            {
                return TemperatureWarningLevel.CautionWarning;
            }
            else if (temperature >= 38.0 && temperature < 41.0)
            {
                return TemperatureWarningLevel.ExtremeWarning;
            }
            else if (temperature >= 41.0)
            {
                return TemperatureWarningLevel.DangerWarning;
            }
            else
            {
                return TemperatureWarningLevel.NoWarning;
            }
        }
        #endregion
        //
        #region Weather Alerts 
        private async void EmergencyAlertForm_Load(object sender, EventArgs e)
        {
            LoadResidentsData();
        }
        private async Task<WeatherData> FetchWeatherData(string locationId, string apiKey)
        {
            using (var client = new HttpClient())
            {
                string apiUrl = $"https://api.tomorrow.io/v4/timelines?location={locationId}&fields=precipitationIntensity,windSpeed,temperature&apikey={apiKey}";
                var response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
                    return weatherData;
                }
                else
                {
                    // Handle error
                    return null;
                }
            }
        }
        private WeatherData GetDummyWeatherData(double precipitationIntensity, double windSpeed, double temperature)
        {
            var weatherData = new WeatherData
            {
                Data = new WeatherDataResponse
                {
                    Timelines = new[]
                    {
                new WeatherTimeline
                {
                    Intervals = new[]
                    {
                        new WeatherInterval
                        {
                            Values = new WeatherValues
                            {
                                PrecipitationIntensity = precipitationIntensity,
                                WindSpeed = windSpeed,
                                Temperature = temperature
                            }
                        }
                    }
                }
            }
                }
            };

            return weatherData;
        }
        public async Task CheckAndTriggerAlert()
        {
            var weatherData = await FetchWeatherData(LocationId, ApiKey);
            //double precipitationIntensity = 120.0; // Simulate heavy rainfall
            //double windSpeed = 0; // Simulate moderate wind speed
            //double temperature = 0; // Simulate extreme temperature
            //var weatherData = GetDummyWeatherData(precipitationIntensity, windSpeed, temperature);

            if (weatherData != null)
            {
                // Extract relevant weather parameters
                var precipitationIntensity = weatherData.Data.Timelines[0].Intervals[0].Values.PrecipitationIntensity;
                var windSpeed = weatherData.Data.Timelines[0].Intervals[0].Values.WindSpeed;
                var temperature = weatherData.Data.Timelines[0].Intervals[0].Values.Temperature;

                // Determine the PSWS signal number based on the precipitation intensity
                PSWSSignalNumber currentPSWSSignalNumber = PreciptionLevel(precipitationIntensity);

                // Determine the TCWS signal number based on the wind speed
                TCWSSignalNumber currentTCWSSignalNumber = DetermineWindConditionLevel(windSpeed);
                // Determine the temperature warning level based on the tempex  rature value

                TemperatureWarningLevel currentTemperatureWarningLevel = DetermineTemperatureWarningLevel(temperature);

                switch (currentPSWSSignalNumber)
                {
                    case PSWSSignalNumber.SignalNo1:
                        // Send alerts for Signal No. 1 to relevant puroks or residents
                        SendAlertsForSignalNo1();
                        break;
                    case PSWSSignalNumber.SignalNo2:
                        // Send alerts for Signal No. 2 to relevant puroks or residents
                        SendAlertsForSignalNo2();
                        break;
                    case PSWSSignalNumber.SignalNo3:
                        // Send alerts for Signal No. 3 to relevant puroks or residents
                        //SampleSendAlertsForSignalNo3();
                        SendAlertsForSignalNo3();
                        break;
                    case PSWSSignalNumber.SignalNo4:
                        // Send alerts for Signal No. 4 to relevant puroks or residents
                        SendAlertsForSignalNo4();
                        break;
                    case PSWSSignalNumber.NoSignal:
                        MessageBox.Show("No significant warning detected.");
                        break;
                    default:
                        MessageBox.Show("Error determining signal number.");
                        break;
                }
                // Handle TCWS alerts
                switch (currentTCWSSignalNumber)
                {
                    case TCWSSignalNumber.SignalNo1:
                        SendAlertsForTCWSSignalNo1();
                        break;
                    case TCWSSignalNumber.SignalNo2:
                        SendAlertsForTCWSSignalNo2();
                        break;
                    case TCWSSignalNumber.SignalNo3:
                        SendAlertsForTCWSSignalNo3();
                        break;
                    case TCWSSignalNumber.SignalNo4:
                        SendAlertsForTCWSSignalNo4();
                        break;
                    case TCWSSignalNumber.SignalNo5:
                        SendAlertsForTCWSSignalNo5();
                        break;
                    case TCWSSignalNumber.NoSignal:
                        // No action needed
                        break;
                    default:
                        MessageBox.Show("Error determining TCWS signal number.");
                        break;
                }
                switch (currentTemperatureWarningLevel)
                {
                    case TemperatureWarningLevel.CautionWarning:
                        SendTemperatureCautionWarning();
                        break;
                    case TemperatureWarningLevel.ExtremeWarning:
                        SendTemperatureExtremeWarning();
                        break;
                    case TemperatureWarningLevel.DangerWarning:
                        SendTemperatureDangerWarning();
                        break;
                    case TemperatureWarningLevel.NoWarning:
                        // No action needed
                        break;
                    default:
                        MessageBox.Show("Error determining temperature warning level.");
                        break;
                }
            }
        }
        #endregion
        //THIS THE SAMPLE FUNCTION FOR THE TEST OF sms
        private void SampleSendAlertsForSignalNo3()
        {
            // Fetch residents or puroks to receive Signal No. 1 alerts
                SendSMS("09318842733", "EMERGENCY ALERT!: PSWS Signal No. 3 for Rainfall/Flooding. Intense rainfall. Evacuate to higher ground immediately.");
            MessageBox.Show("EMERGENCY ALERT!: PSWS Signal No. 3 for Rainfall/Flooding. Intense rainfall. Evacuate to higher ground immediately.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //
        #region Alert Sending Methods
        private void SendAlertsForSignalNo1()
        {
            // Fetch residents or puroks to receive Signal No. 1 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "ALERT!: PSWS Signal No. 1 for Rainfall/Flooding. Light to moderate rainfall. Stay vigilant.");
                MessageBox.Show("ALERT!: PSWS Signal No. 1 for Rainfall/Flooding. Light to moderate rainfall. Stay vigilant.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendAlertsForSignalNo2()
        {
            // Fetch residents or puroks to receive Signal No. 2 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "ALERT!: PSWS Signal No. 2 for Rainfall/Flooding. Heavy rainfall. Be prepared for possible flooding.");
                MessageBox.Show("ALERT!: PSWS Signal No. 2 for Rainfall/Flooding. Heavy rainfall. Be prepared for possible flooding.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendAlertsForSignalNo3()
        {
            // Fetch residents or puroks to receive Signal No. 3 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "EMERGENCY ALERT!: PSWS Signal No. 3 for Rainfall/Flooding. Intense rainfall. Evacuate to higher ground immediately.");
                MessageBox.Show("EMERGENCY ALERT!: PSWS Signal No. 3 for Rainfall/Flooding. Intense rainfall. Evacuate to higher ground immediately.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendAlertsForSignalNo4()
        {
            // Fetch residents or puroks to receive Signal No. 4 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "EMERGENCY ALERT!: PSWS Signal No. 4 for Rainfall/Flooding. Torrential rainfall. Seek immediate shelter and evacuate if necessary.");
                MessageBox.Show("EMERGENCY ALERT!: PSWS Signal No. 4 for Rainfall/Flooding. Torrential rainfall. Seek immediate shelter and evacuate if necessary.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SendAlertsForTCWSSignalNo1()
        {
            // Fetch residents or puroks to receive TCWS Signal No. 1 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "ALERT!: TCWS Signal No. 1. Wind Threat: 39-61 km/h (22-33 kt, 10.8-17.1 m/s). Potential impacts: Minimal to minor damage to light structures. Stay vigilant.");
                MessageBox.Show("ALERT!: TCWS Signal No. 1. Wind Threat: 39-61 km/h (22-33 kt, 10.8-17.1 m/s). Potential impacts: Minimal to minor damage to light structures. Stay vigilant.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendAlertsForTCWSSignalNo2()
        {
            // Fetch residents or puroks to receive TCWS Signal No. 2 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "ALERT!: TCWS Signal No. 2. Wind Threat: 62-88 km/h (34-47 kt, 17.2-24.4 m/s). Potential impacts: Minor to moderate damage to light structures. Prepare for possible flooding.");
                MessageBox.Show("ALERT!: TCWS Signal No. 2. Wind Threat: 62-88 km/h (34-47 kt, 17.2-24.4 m/s). Potential impacts: Minor to moderate damage to light structures. Prepare for possible flooding.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendAlertsForTCWSSignalNo3()
        {
            // Fetch residents or puroks to receive TCWS Signal No. 3 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "EMERGENCY ALERT!: TCWS Signal No. 3. Wind Threat: 89-117 km/h (48-63 kt, 24.5-32.6 m/s). Potential impacts: Substantial damage to light structures. Evacuate to higher ground immediately.");
                MessageBox.Show("EMERGENCY ALERT!: TCWS Signal No. 3. Wind Threat: 89-117 km/h (48-63 kt, 24.5-32.6 m/s). Potential impacts: Substantial damage to light structures. Evacuate to higher ground immediately.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendAlertsForTCWSSignalNo4()
        {
            // Fetch residents or puroks to receive TCWS Signal No. 4 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "EMERGENCY ALERT!: TCWS Signal No. 4. Wind Threat: 118-184 km/h (64-99 kt, 32.7-51.2 m/s). Potential impacts: Severe damage to structures. Seek immediate shelter and evacuate if necessary.");
                MessageBox.Show("EMERGENCY ALERT!: TCWS Signal No. 4. Wind Threat: 118-184 km/h (64-99 kt, 32.7-51.2 m/s). Potential impacts: Severe damage to structures. Seek immediate shelter and evacuate if necessary.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendAlertsForTCWSSignalNo5()
        {
            // Fetch residents or puroks to receive TCWS Signal No. 5 alerts
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "EMERGENCY ALERT!: TCWS Signal No. 5. Wind Threat: 185 km/h or higher (100 kt or higher, 51.3 m/s or higher). Potential impacts: Catastrophic damage to structures. Seek immediate shelter and evacuate if necessary.");
                MessageBox.Show("EMERGENCY ALERT!: TCWS Signal No. 5. Wind Threat: 185 km/h or higher (100 kt or higher, 51.3 m/s or higher). Potential impacts: Catastrophic damage to structures. Seek immediate shelter and evacuate if necessary.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void SendTemperatureCautionWarning()
        {
            // Fetch residents or puroks to receive temperature caution warning
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "TEMPERATURE ADVISORY: Caution - Temperature between 35°C and 38°C. Take precautions against heat-related illnesses.");
                MessageBox.Show("TEMPERATURE ADVISORY: Caution - Temperature between 35°C and 38°C. Take precautions against heat-related illnesses.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendTemperatureExtremeWarning()
        {
            // Fetch residents or puroks to receive temperature extreme warning
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "TEMPERATURE WARNING: Extreme - Temperature between 38°C and 41°C. Limit outdoor activities and stay hydrated.");
                MessageBox.Show("TEMPERATURE WARNING: Extreme - Temperature between 38°C and 41°C. Limit outdoor activities and stay hydrated.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendTemperatureDangerWarning()
        {
            // Fetch residents or puroks to receive temperature danger warning
            DataTable residentsToAlert = ResidentDataAccess.GetAllResidentContacts();

            // Send SMS alerts to the fetched residents
            foreach (DataRow row in residentsToAlert.Rows)
            {
                string phoneNumber = row["MobileNumber"].ToString();
                SendSMS(phoneNumber, "TEMPERATURE EMERGENCY: Danger - Temperature above 41°C. Avoid outdoor activities and seek cool shelter.");
                MessageBox.Show("TEMPERATURE EMERGENCY: Danger - Temperature above 41°C. Avoid outdoor activities and seek cool shelter.", "Alert Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion
        //
        //
        #region Weather Classes 
        public class WeatherData
        {
            public WeatherDataResponse Data { get; set; }
        }

        public class WeatherDataResponse
        {
            public WeatherTimeline[] Timelines { get; set; }
        }

        public class WeatherTimeline
        {
            public WeatherInterval[] Intervals { get; set; }
        }

        public class WeatherInterval
        {
            public WeatherValues Values { get; set; }
        }

        public class WeatherValues
        {
            [JsonProperty("windSpeed")]
            public double WindSpeed { get; set; }

            [JsonProperty("precipitationIntensity")]
            public double PrecipitationIntensity { get; set; }
            [JsonProperty("temperature")]
            public double Temperature { get; set; }
        }
        #endregion
        //
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
        private void SendSMSMessagesToPurok(string purok, string messageContent)
        {
            DataTable dataTable = (DataTable)dataGridViewResidents.DataSource;
            if (dataTable == null) return;

            var rowsToSendSMS = dataTable.AsEnumerable()
                                          .Where(row => row.Field<string>("PurokNumber") == purok)
                                          .ToList();
            DialogResult result = MessageBox.Show($"Are you sure you want to send SMS alerts to {purok}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataRow row in rowsToSendSMS)
                {
                    string phoneNumber = row["MobileNumber"].ToString();
                    SendSMS(phoneNumber, messageContent);
                }

                if (rowsToSendSMS.Count > 0)
                {
                    MessageBox.Show($"SMS messages have been sent to all residents in {purok}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No residents found in Purok {purok} to send SMS.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void searchNameTextbox_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = searchNameTextbox.Text.Trim();

            // If search term is empty, show all rows
            if (string.IsNullOrEmpty(searchTerm))
            {
                dataGridViewResidents.DataSource = ResidentDataAccess.GetAllResidentContacts();
                return;
            }

            // Split the search term into individual words
            string[] keywords = searchTerm.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Construct the filter expression dynamically
            StringBuilder filterExpression = new StringBuilder();
            filterExpression.Append("(");
            foreach (string keyword in keywords)
            {
                if (filterExpression.Length > 1)
                    filterExpression.Append(" AND ");

                filterExpression.Append("(");
                filterExpression.AppendFormat("FirstName LIKE '%{0}%'", keyword);
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("LastName LIKE '%{0}%'", keyword);
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("PurokNumber LIKE '%{0}%'", keyword);
                filterExpression.Append(" OR ");
                filterExpression.AppendFormat("MobileNumber LIKE '%{0}%'", keyword);

                filterExpression.Append(")");
            }
            filterExpression.Append(")");

            // Apply the filter to the DataGridView's DataSource
            ((DataTable)dataGridViewResidents.DataSource).DefaultView.RowFilter = filterExpression.ToString();

        }

        private void searchByPurokDropdown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Purok from the dropdown
            string selectedPurok = searchByPurokDropdown.SelectedItem.ToString();

            // Perform the search operation based on the selected Purok
            SearchResidentsByPurok(selectedPurok);
        }
        private void SearchResidentsByPurok(string purok)
        {
            try
            {
                DataTable searchResults;

                if (purok == "All Residents")
                {
                    // Fetch all residents
                    searchResults = ResidentDataAccess.GetAllResidentContacts();
                }
                else
                {
                    // Fetch residents by the selected purok
                    searchResults = ResidentDataAccess.SearchResidentsByPurok(purok);
                }

                // Update the DataGridView with search results
                dataGridViewResidents.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching residents by Purok: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            if (searchByPurokDropdown.SelectedItem != null && searchByPurokDropdown.SelectedItem.ToString() == "All Residents")
            {
                // Retrieve all residents' mobile numbers
                DataTable allResidentsDataTable = ResidentDataAccess.GetAllResidentContacts();

                // Check if any residents are found
                if (allResidentsDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No residents found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Confirmation before sending SMS to all residents
                DialogResult result = MessageBox.Show("Are you sure you want to send SMS alerts to all residents?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Iterate through each resident and send SMS
                    foreach (DataRow row in allResidentsDataTable.Rows)
                    {
                        string phoneNumber = row["MobileNumber"].ToString();
                        SendSMS(phoneNumber, message.Text);
                    }

                    MessageBox.Show("SMS alerts have been sent to all residents!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (dataGridViewResidents.SelectedRows.Count == 0)
            {
                string selectedPurok = searchByPurokDropdown.SelectedItem.ToString();
                SendSMSMessagesToPurok(selectedPurok, message.Text);
            }
            else
            {
                // Existing code to send SMS to selected rows
                List<string> selectedPhoneNumbers = new List<string>();
                foreach (DataGridViewRow row in dataGridViewResidents.SelectedRows)
                {
                    string phoneNumber = row.Cells["MobileNumber"].Value.ToString();
                    selectedPhoneNumbers.Add(phoneNumber);
                }

                foreach (string phoneNumber in selectedPhoneNumbers)
                {
                    SendSMS(phoneNumber, message.Text);
                }

                MessageBox.Show("SMS alerts have been sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPort_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the selection in the DataGridView
            dataGridViewResidents.ClearSelection();
        }
    }
}