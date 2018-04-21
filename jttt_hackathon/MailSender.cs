using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace jttt_hackathon
{
    class MailSender
    {
        MailMessage mm;
        SmtpClient client = new SmtpClient();

        public MailSender()
        {
        client.Port = 587;
        client.Host = "smtp.gmail.com";
        client.EnableSsl = true;
        client.Timeout = 10000;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.Credentials = new System.Net.NetworkCredential("AIRdeniskuba@gmail.com", "deniskuba");
        }

        public void AddAttachments(List<string> fileNames)
        {
            Attachment img;

            foreach (string file in fileNames)
            {
                img = new Attachment(file);
                mm.Attachments.Add(img);
            }
        }
        public void SendMessage(Task task)
        {
            HtmlEditor htmlEditor = new HtmlEditor(task.url);
            List<string> fileNames = htmlEditor.DownloadImages(task.keyWord);
            int howManyAttachments = fileNames.Count;

            if ( howManyAttachments == 0)
            {
                FileLogger.Log("Nie wysłano wiadomości, brak obrazków!");
                MessageBox.Show("Nie udało się wysłać wiadomości!");
            }
            else
            {
                mm = new MailMessage("airdeniskuba@gmail.com", task.mail, "JTTT - Zdjęcia z hasłem '" + task.keyWord + "'", "Wyszukano następujące zdjęcia: ");
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                AddAttachments(fileNames);
                client.Send(mm);
                FileLogger.Log("Wysłano wiadomość!");
                MessageBox.Show("Wysłano wiadomość!");

                mm.Attachments.Dispose();
                foreach (string file in fileNames)
                {
                    File.Delete(file);
                }
            }

            
        }
    }
}
