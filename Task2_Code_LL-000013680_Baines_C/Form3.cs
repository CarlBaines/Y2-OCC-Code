using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Task2_Code_LL_000013680_Baines_C
{
    public partial class Form3 : Form
    {
        AccessibilityHelper accessibilityHelper = new AccessibilityHelper();
        public string location { get; set; }
        public HttpClient httpClient { get; set; }
        //API key for OpenWeather APIs
        public string APIKey = "b1fe4659e300363e368f4ce2cf007fac";

        public Form3(AccessibilityHelper accessibilityHelper, string location)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            txtForecastLocation.Text = location.ToString().ToUpper();

            //Creates a new form of the http client class.
            httpClient = new HttpClient();
            this.location = location;

            this.accessibilityHelper = accessibilityHelper;
            accessibilityHelper.UpdateFontSize(this.Controls);

        }

        

        public async Task<List<float>> GetCoordinates(string region)
        {
            //Pulls data from the geolocation API to get the coordinates of the user-inputted location.
            HttpResponseMessage response = await httpClient.GetAsync($"http://api.openweathermap.org/geo/1.0/direct?q={region}&limit=5&appid={APIKey}");
            string payload = await response.Content.ReadAsStringAsync();

            JArray payloadObject = JArray.Parse(payload);

            
            return new List<float>()
            {
                (float)payloadObject[0]["lat"],
                (float)payloadObject[0]["lon"]
            };

            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<float> coordinates = await GetCoordinates(this.location);

            HttpResponseMessage response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat={coordinates[0]}&lon={coordinates[1]}&appid={APIKey}");
            string payload = await response.Content.ReadAsStringAsync();

            JObject payloadObject = JObject.Parse(payload);

            //Gets main weather type from API dictionary and outputs it e.g. sunny, clouds.
            txtWeather.Text = (string)payloadObject["weather"][0]["description"];
            MessageBox.Show((string)payloadObject["weather"][0]["description"]);

        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {
            
        }

 
        private void slidersIcon_Click(object sender, EventArgs e)
        {

        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(accessibilityHelper);
            f1.ShowDialog();
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(accessibilityHelper);
            f2.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<float> coordinates = await GetCoordinates(this.location);

            HttpResponseMessage response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat={coordinates[0]}&lon={coordinates[1]}&appid={APIKey}&units=metric");
            string payload = await response.Content.ReadAsStringAsync();

            JObject payloadObject = JObject.Parse(payload);

            //Gets temperature in celcius from API dictionary.
            txtDisplayTemp.Text = (string)payloadObject["main"]["temp"] + "°c";
            txtDisplayTemperature.Text = (string)payloadObject["main"]["temp"] + "°c" + "\tFeels like: " + (string)payloadObject["main"]["feels_like"] + "°c";
            txtTemperature.Text = (string)payloadObject["main"]["temp"] + "°c";
            MessageBox.Show((string)payloadObject["main"]["temp"] + "°c");
        }

        private async void btnAirQuality_Click(object sender, EventArgs e)
        {
            List<float> coordinates = await GetCoordinates(this.location);

            HttpResponseMessage response = await httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/air_pollution?lat={coordinates[0]}&lon={coordinates[1]}&appid={APIKey}&units=metric");
            string payload = await response.Content.ReadAsStringAsync();

            string payload2 = await response.Content.ReadAsStringAsync();

            JObject payloadObject = JObject.Parse(payload);

            JObject payloadObject2 = JObject.Parse(payload2);

            //Gets air quality index from API dictionary.
            txtDisplayAirQuality.Text = ("AQI: " + (string)payloadObject["list"][0]["main"]["aqi"]);
            txtAirQuality.Text = ("Air Quality Index: " + (string)payloadObject["list"][0]["main"]["aqi"] + "\t" + "Carbon Monoxide: " + (string)payloadObject2["list"][0]["components"]["co"]);
            MessageBox.Show("AQI: " + (string)payloadObject["list"][0]["main"]["aqi"] + "\n" + "CO: " + (string)payloadObject2["list"][0]["components"]["co"]);
        }

        private void txtDisplayAirQuality_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
