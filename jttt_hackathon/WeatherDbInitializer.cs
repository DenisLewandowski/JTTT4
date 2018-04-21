using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jttt_hackathon
{
    class WeatherDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WeatherDbContext>
    {
        protected override void Seed(WeatherDbContext context)
        {
            context.WeatherClass.Add(new WeatherClass() { city = "Kraków", temperatureFromServer = 19, pressure = 1010, wind = 110, sky="Sunny" });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
