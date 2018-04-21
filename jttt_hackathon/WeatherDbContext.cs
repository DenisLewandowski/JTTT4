using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jttt_hackathon
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext()
            : base("JTTT_DB")
        {
            Database.SetInitializer(new WeatherDbInitializer());
        }

        public DbSet<WeatherClass> WeatherClass { get; set; }

    }
}
