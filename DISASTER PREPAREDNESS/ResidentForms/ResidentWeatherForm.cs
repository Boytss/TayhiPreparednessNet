using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;

namespace DISASTER_PREPAREDNESS.ResidentForms
{
    public partial class ResidentWeatherForm : Form
    {
        private const string ApiKey = "3c1b42054e212a0088cda5f59832df02";
        private const string ApiUrl = "https://api.openweathermap.org/data/2.5/weather";
        private const string FolderPath = @"C:\Users\Admin\Desktop\DISASTER PREPAREDNESS SYSTEM OF BARANGAY TAYHI, TABACO\Conditions\";
        public ResidentWeatherForm()
        {
            InitializeComponent();
         

        }



        private async Task GetWeatherForecastAsync(string cityName)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q=Tayhi,Tabaco,Albay,Philippines&appid=3c1b42054e212a0088cda5f59832df02";

                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var weatherData = JsonConvert.DeserializeObject<WeatherData>(jsonString);

                        // Update UI with weather data
                        labeltTodayTemp.Text = $"{weatherData.Main.Temp}°C";
                        labelTodayConds.Text = weatherData.Weather[0].Description;
                        labelHumidity.Text = $"{weatherData.Main.Humidity}%";
                        labelWind.Text = $"{weatherData.Wind.Speed} m/s";

                        // Update picture box with custom weather icon
                        string customIconPath = GetCustomIconPath(weatherData.Weather[0].Description);
                        if (!string.IsNullOrEmpty(customIconPath))
                        {
                            // Remove previous background image
                            pictureBoxToday.BackgroundImage = null;
                            // Set new background image
                            pictureBoxToday.Image = Image.FromFile(customIconPath);
                            // Stretch background image
                            pictureBoxToday.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve weather forecast. Please try again later.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        // Method to get the custom icon path based on weather condition
        private string GetCustomIconPath(string weatherCondition)
        {
            // Example: Assuming your custom icons are named "cloudy.png", "rainy.png", etc. in the specified folder
            switch (weatherCondition.ToLower())
            {
                case "clouds":
                    return Path.Combine(FolderPath, "cloudy.png");
                case "scattered clouds":
                    return Path.Combine(FolderPath, "scattered-clouds.png");
                case "rain":
                    return Path.Combine(FolderPath, "rainy.png");
                case "broken clouds":
                    return Path.Combine(FolderPath, "broken-clouds.png");
                case "light rain":
                    return Path.Combine(FolderPath, "light-rain.png");
                // Add cases for other weather conditions as needed
                default:
                    return string.Empty; // Return empty string if no custom icon is found
            }
        }
        public class ForecastData
        {
            public List<ForecastEntry> List { get; set; }
        }
        public class WeatherData
        {
            public MainData Main { get; set; }
            public Weather[] Weather { get; set; }
            public Wind Wind { get; set; }
            // Add other properties as needed based on the API response
        }
        public class ForecastEntry
        {
            public long Dt { get; set; } // Unix timestamp representing the date and time
            public MainData Main { get; set; }
            public Weather[] Weather { get; set; }
            public Clouds Clouds { get; set; }  // Clouds data
            public Wind Wind { get; set; }  // Wind data
            public int Visibility { get; set; }  // Visibility data
            public double Pop { get; set; }  // Probability of precipitation
            public Rain Rain { get; set; }  // Rain data
            public Sys Sys { get; set; }  // Sys data
            public string DtTxt { get; set; } // Textual representation of date and time
        }

        public class MainData
        {
            public double Temp { get; set; }
            public double FeelsLike { get; set; }
            public double TempMin { get; set; }
            public double TempMax { get; set; }
            public int Pressure { get; set; }
            public int SeaLevel { get; set; }
            public int GrndLevel { get; set; }
            public int Humidity { get; set; }
            public double TempKf { get; set; }
        }

        public class Weather
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }
        }

        public class Clouds
        {
            public int All { get; set; }
        }

        public class Wind
        {
            public double Speed { get; set; }
            public int Deg { get; set; }
            public double Gust { get; set; }
        }

        public class Rain
        {
            [JsonProperty("3h")]
            public double Volume { get; set; }
        }

        public class Sys
        {
            public string Pod { get; set; }
        }
        private async void ResidentWeatherForm_Load(object sender, EventArgs e)
        {
            await GetWeatherForecastAsync("Tayhi, Tabaco, Albay, Philippines");
            await Get7DayWeatherForecastAsync("Tayhi, Tabaco, Albay, Philippines");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }
        private async Task Get7DayWeatherForecastAsync(string cityName)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"https://api.openweathermap.org/data/2.5/forecast?q=Tayhi,Tabaco,Albay,Philippines&appid=3c1b42054e212a0088cda5f59832df02";
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var forecastData = JsonConvert.DeserializeObject<ForecastData>(jsonString);

                        // Process forecast data and update UI
                        Update7DayForecastUI(forecastData);
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve weather forecast. Please try again later.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Update7DayForecastUI(ForecastData forecastData)
        {
            // Get the current day of the week
            DateTime today = DateTime.Today;


            for (int i = 0; i < 7; i++)
            {
                // Get forecast information for the current day
                var forecastEntry = forecastData.List[i];

                // Convert the forecast date to a DateTime object
                DateTime forecastDate = DateTimeOffset.FromUnixTimeSeconds(forecastEntry.Dt).DateTime;

                // Calculate the day of the week for the forecast date
                string dayName = forecastDate.ToString("dddd");

                double temperature = forecastEntry.Main.Temp;
                string weatherCondition = forecastEntry.Weather[0].Description;

                // Update labels with forecast information
                var dayLabel = Controls.Find($"dayLabels{i + 1}", true).FirstOrDefault() as Label;
                var temperatureLabel = Controls.Find($"temperatureLabels{i + 1}", true).FirstOrDefault() as Label;
                var conditionLabel = Controls.Find($"conditionLabels{i + 1}", true).FirstOrDefault() as Label;
                var pictureBox = Controls.Find($"pictureBoxes{i + 1}", true).FirstOrDefault() as PictureBox;




                if (dayLabel != null)
                    dayLabel.Text = dayName;

                if (temperatureLabel != null)
                    temperatureLabel.Text = $"{temperature}°C";

                if (conditionLabel != null)
                    conditionLabel.Text = weatherCondition;

                if (pictureBox != null)
                {
                    pictureBox.BackgroundImage = null;

                    // Set the image location based on weather condition
                    pictureBox.ImageLocation = GetCustomIconPath(weatherCondition);
                    // Stretch background image
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }



        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}