using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;

namespace jttt_hackathon
{
    public class HtmlEditor
    {
        private readonly string _url;

        public HtmlEditor(string url)
        {
            this._url = url;
        }

        public string GetPageHtml()
        {
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = System.Net.WebUtility.HtmlDecode(wc.DownloadString(_url));

                return html;
            }
        }

        public List<string> DownloadImages(string text1)
        {
            var doc = new HtmlDocument();

            var pageHtml = GetPageHtml();
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");

            WebClient wc = new WebClient();
            List<string> fileNames = new List<string>();

            foreach (var node in nodes)
            {
                if (node.GetAttributeValue("alt", "").Contains(text1) && node.GetAttributeValue("src", "").Contains("http"))
                {
                    string time = DateTime.Now.TimeOfDay.ToString().Replace(".", "").Replace(":", "");
                    fileNames.Add(time + ".jpg");
                    wc.DownloadFile(node.GetAttributeValue("src", ""), time + ".jpg");  // Pobieranie obrazu
                    FileLogger.Log("Pobrano " + node.GetAttributeValue("src", ""));
                }
            }

            wc.Dispose();
            return fileNames;
        }
    }
}
