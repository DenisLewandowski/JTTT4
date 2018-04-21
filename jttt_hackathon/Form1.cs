using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace jttt_hackathon
{
    public partial class Form1 : Form
    {
        TaskList taskList = new TaskList();
        public Form1()
        {
            InitializeComponent();
            TaskListBox.DataSource = taskList.taskList;
           
            // Wczytywanie z bazy danych do listy zadan
            using (var ctx = new TaskDbContext())
            {
                foreach (var t in ctx.Task)
                {
                    taskList.AddTask(t);
                    Console.WriteLine(t);
                }
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void DoTaskButton_Click(object sender, EventArgs e)
        {
            MailSender ms = new MailSender();
            int howManyTasks = taskList.taskList.Count;
            if (howManyTasks > 0)
            {
                for (int i = 0; i < howManyTasks; i++)
                    ms.SendMessage(taskList.taskList[i]);
            }
            else
            {
                MessageBox.Show("Nie można wysłac mail'a, brak zadań!");
            }
                //Task task = new Task(UrlBox.Text.ToString(), KeyBox.Text.ToString(), MailBox.Text.ToString(), TasknameBox.Text.ToString());
            //ms.SendMessage(task);
        }

  
        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            Task task = new Task() { url = UrlBox.Text.ToString(), keyWord = KeyBox.Text.ToString(), mail = MailBox.Text.ToString(), taskName = TaskNameBox.Text.ToString() };
            taskList.AddTask(task);
            using (var ctx = new TaskDbContext())
            {
                ctx.Task.Add(task);
                ctx.SaveChanges();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            taskList.removeTasks();
            using (var ctx = new TaskDbContext())
            {
                ctx.SaveChanges();
            }
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            DataSerialize ds = new DataSerialize();
            ds.SerializeData(taskList);
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            DataSerialize ds = new DataSerialize();
            taskList = ds.DeserializeData();
            TaskListBox.DataSource = taskList.taskList;
        }

        WeatherClass weathClass = new WeatherClass();
        private void WeatherButton_Click(object sender, EventArgs e)
        {
            if ( weathClass.getFromServer(MiastoBox.Text.ToString(), TemperaturyList.Value.ToString()) == true )
            {
                using (var ctx = new WeatherDbContext())
                {
                    ctx.WeatherClass.Add(weathClass);
                    ctx.SaveChanges();
                }
                FileLogger.Log("Dodano zapis o pogodzie do bazy!");
                Form weatherForm = new WeatherForm(weathClass);
                weatherForm.Show();
            }
        }
    }
}