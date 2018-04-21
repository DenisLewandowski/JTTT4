using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace jttt_hackathon
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext()
            : base("JTTT_DB")
        {
            Database.SetInitializer(new TaskDbInitializer());
        }

        public DbSet<Task> Task { get; set; }

    }
}
