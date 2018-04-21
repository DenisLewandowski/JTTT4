using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;

namespace jttt_hackathon
{
    public class TaskList
    {
        public BindingList<Task> taskList = new BindingList<Task>();

        public void AddTask(Task task)
        {
            taskList.Add(task);
        }

        public void removeTasks()
        {
            taskList.Clear();
        }

        public override string ToString()
        {
            return taskList.ToString();
        }
    }
}
