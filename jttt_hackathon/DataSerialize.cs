using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;


namespace jttt_hackathon
{
    public class DataSerialize
    {
        public void SerializeData(TaskList tl)
        {
            if (tl.taskList.Count > 0)
            {
                string fileName = "dane.xml";
                StreamWriter wr = new StreamWriter(fileName);
                XmlSerializer xs = new XmlSerializer(typeof(TaskList));
                xs.Serialize(wr, tl);
                FileLogger.Log("Nastąpiła serializacja danych do pliku " + fileName);
                MessageBox.Show("Serializacja udana!");
                wr.Flush();
                wr.Close();
            }
            else
            {
                MessageBox.Show("Nie można serializować! Brak danych");
            }
        }

        public TaskList DeserializeData()
        {
            string fileName = "dane.xml";
            StreamReader sr = new StreamReader(fileName);
            XmlSerializer xs = new XmlSerializer(typeof(TaskList));
            TaskList tl = (TaskList)xs.Deserialize(sr);
            FileLogger.Log("Nastąpiła deserializacja danych z pliku" + fileName);
            return tl;
        }
    }
}
