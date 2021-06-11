using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsMedia_with_List
{
    class xmlhelper
    {
        public void insert_ToDocument(int a , string [] item)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(Application.StartupPath + "\\day2.xml");
            XmlNode xmlnode = xmldoc.DocumentElement.ChildNodes.Item(a);
            XmlElement eMusic, eten, eid, edd, eTG;
            eMusic = xmldoc.CreateElement("ten");
            eMusic.InnerText = "Music"; 
            xmldoc.DocumentElement.AppendChild(eMusic);
            //xmlnode["ten"].InnerText = item[0].ToString();
            //xmlnode["id"].InnerText = item[1].ToString();
            //xmlnode["dd"].InnerText = item[2].ToString();
            //xmlnode["TG"].InnerText = item[3].ToString();
            xmldoc.Save(Application.StartupPath + "\\day2.xml");
        }

        public static void insertToDocument(string fileName, Dictionary<string, string> newFilm)

        {
            try
            {
                var xmlDoc = XDocument.Load(@fileName);
                // var time = DateTime.Now.ToUniversalTime();
                Random rd = new Random();
                var time = rd.Next(1,100000);
                //  var currentTimeStamp = ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
                xmlDoc.Element("Musics").Add(new XElement("Music",
                    new XAttribute("id", time),
                    new XElement("ten", newFilm["ten"]),
                    new XElement("TG", newFilm["TG"]),
                    new XElement("dd", newFilm["dd"]),
                     new XElement("TGKT", newFilm["TGKT"])
                    ));
                xmlDoc.Save(@fileName);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception)
            { 
            }
        }

        public static void updateAnElement(string fileName, string id, Dictionary<string, string> updateMusic)
        {
            try
            {
                var xmlDoc = XDocument.Load(@fileName);
                var existingElement = xmlDoc.Element("Musics").Elements("Music")
                    .Where(element => element.Attribute("id").Value == id)
                    .FirstOrDefault();
                if (updateMusic.ContainsKey("ten") && updateMusic["ten"] != null)
                {
                    existingElement.SetElementValue("ten", updateMusic["ten"]);
                }
                if (updateMusic.ContainsKey("TG") && updateMusic["TG"] != null)
                {
                    existingElement.SetElementValue("TG", updateMusic["TG"]);
                }
                if (updateMusic.ContainsKey("dd") && updateMusic["dd"] != null)
                {
                    existingElement.SetElementValue("dd", updateMusic["dd"]);
                }
                if (updateMusic.ContainsKey("TGKT") && updateMusic["TGKT"] != null)
                {
                    existingElement.SetElementValue("TGKT", updateMusic["TGKT"]);
                }
                xmlDoc.Save(@fileName);
                MessageBox.Show("Sửa thành công !");
            }
            catch (Exception)
            {
            }
            
        }
        public static void deleteAnElement(string fileName, string id)
        {
            try
            {
                var xmlDoc = XDocument.Load(@fileName);
                var existingElement = xmlDoc.Element("Musics").Elements("Music")
                    .Where(element => element.Attribute("id").Value == id)
                    .FirstOrDefault();
                if (existingElement != null)
                {
                    existingElement.Remove();
                    xmlDoc.Save(@fileName);
                    MessageBox.Show("Xóa thành công !");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy để xóa !");
                }
            }
            catch (Exception)
            {
            }
            

        }
    }
}
