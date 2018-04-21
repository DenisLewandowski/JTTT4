using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Text;

namespace jttt_hackathon
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileLogger.Log("Otwarcie aplikacji!");
            FileLogger.Log("Użytkownik: " + Dns.GetHostName());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.Read();
            FileLogger.Log("Zamkniecie aplikacji!");
        }
    }
}
