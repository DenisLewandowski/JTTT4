using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jttt_hackathon
{
    [Table("WeatherStates")]
    public class WeatherClass
    {
        [Key]
        public int IdW {get; set;}
        public string city {get; set;}
        public string temperatureFromUser {get; set;}
        public double temperatureFromServer {get; set;}
        public double pressure { get; set; }
        public double wind { get; set; }
        public string sky { get; set; }
        public string weatherDescription { get; set; }
        public string weatherIcon { get; set; }

        public override string ToString()
        {
            return string.Format("Tsk IdW={0}, City={1}, Temperature={2}, Pressure={3}, Wind={4}, Sky={5}", IdW, city, temperatureFromServer, pressure, wind, sky);
        }

        public bool getFromServer(string city, string tempFU)
        {
            if (city == "") { 
                MessageBox.Show("Nie wpisano nazwy miasta!");
                return false;
            }
            else
            {
                this.city = city;
                var wc = new WebClient();
                RootObject root;
                try
                {
                    var json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q="
                        + this.city + ",pl&APPID=0df190ef8fa57ffe46df143c7cb89cee");
                    root = JsonConvert.DeserializeObject<RootObject>(json);
                    if ( (root.main.temp - 273.15) > double.Parse(tempFU) )
                    {
                        this.temperatureFromServer = (root.main.temp - 273.15);
                        String tempFull = "Dzisiaj jest\t" + this.temperatureFromServer + "    °C\n";
                        this.pressure = root.main.pressure;
                        String pressureFull = "Ciśnienie:\t\t" + this.pressure + " hPa\n";
                        this.wind = root.wind.speed;
                        String windFull = "Wiatr:\t\t" + this.wind + "    km/h\n";
                        this.sky = root.weather.Last().description;
                        String skyFull = "A co na niebie?\t" + this.sky;
                        String weatherDescription = tempFull + pressureFull + windFull + skyFull;
                        this.weatherDescription = weatherDescription;
                        this.weatherIcon = root.weather.Last().icon;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Temperatura musi byc niższa od panującej!");
                        return false;
                    }

                }
                catch (System.Net.WebException ex)
                {
                    MessageBox.Show("Wpisz poprawną nazwę miasta!");
                    return false;
                }
            }
        }
    }
}
