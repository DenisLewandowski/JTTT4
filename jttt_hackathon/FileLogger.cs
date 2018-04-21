using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jttt_hackathon
{
    abstract class FileLogger
    {
        public static string logFileName = "log_JTTT.log";
        public static void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(logFileName, true))
            {
                streamWriter.WriteLine( DateTime.Now.ToString() + "\t" +  message);
                streamWriter.Close();
            }
        }

    }
}
