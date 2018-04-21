using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jttt_hackathon
{
    class TaskDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TaskDbContext>
    {

        protected override void Seed(TaskDbContext context)
        {
            context.Task.Add(new Task() { keyWord = "kot", mail = "airdeniskuba2@gmail.com", taskName = "KotZadanie", url = "https://demotywatory.pl" });
            context.Task.Add(new Task() { keyWord = "to", mail = "airdeniskuba2@gmail.com", taskName = "ToZadanie", url = "https://demotywatory.pl" });
            context.Task.Add(new Task() { keyWord = "szybko", mail = "airdeniskuba2@gmail.com", taskName = "SzybkoZadanie", url = "https://demotywatory.pl" });
            context.Task.Add(new Task() { keyWord = "się", mail = "airdeniskuba2@gmail.com", taskName = "KwejkZadanie", url = "https://kwejk.pl" });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
