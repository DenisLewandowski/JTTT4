using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jttt_hackathon
{
    public class Task
    {
        public int Id { get; set; }
        public string url { get; set; }
        public string keyWord { get; set; }
        public string mail { get; set; }
        public string taskName { get; set; }

        public override string ToString()
        {
            return string.Format("Tsk Id={0}, Name={1}, Key Word={2}, Mail={3}, Url={4}", Id, taskName, keyWord, mail, url);
        }
    }
}



/* 
 
     public class Task
    {
        public int Id { get; set; }
        public string url;
        public string keyWord;
        public string mail;
        public string taskName;

        public Task()
        {
            this.url = "";
            this.keyWord = "";
            this.mail = "";
            this.taskName = "";
        }

        public Task(string url, string keyWord, string mail, string taskName)
        {
            this.url = url;
            this.keyWord = keyWord;
            this.mail = mail;
            this.taskName = taskName;
        }
        
                public override string ToString()
                {
                    return taskName+" Link:" + url + " Hasło:" + keyWord + " Adres:" + mail;
                }

    }
    */