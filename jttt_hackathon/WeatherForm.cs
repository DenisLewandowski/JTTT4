using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Text.RegularExpressions;

namespace jttt_hackathon
{
    public partial class WeatherForm : Form
    {
        public WeatherClass weathc;

        public WeatherForm(WeatherClass wc)
        {
            weathc = wc;
            InitializeComponent();
            CityNameTextBox.Text = weathc.city;
            WeatherListBox.Items.Clear();
            foreach (string s in Regex.Split(weathc.weatherDescription, "\n"))
                WeatherListBox.Items.Add(s);
            WeatherPictureBox.Load("http://openweathermap.org/img/w/" + weathc.weatherIcon + ".png");
        }
    }
}
