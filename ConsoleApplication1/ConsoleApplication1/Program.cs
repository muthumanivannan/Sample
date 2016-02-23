using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WritingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDocument document = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("users");
            xmlDoc.AppendChild(rootNode);

            //XmlNode userNode = xmlDoc.CreateElement("user");
            //XmlAttribute attribute = xmlDoc.CreateAttribute("age");
            //attribute.Value = "42";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "John Doe";
            //rootNode.AppendChild(userNode);

            //userNode = xmlDoc.CreateElement("user");
            //attribute = xmlDoc.CreateAttribute("age");
            //attribute.Value = "39";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "Jane Doe";s
            //rootNode.AppendChild(userNode);

            //userNode = xmlDoc.CreateElement("Muthu");
            //attribute = xmlDoc.CreateAttribute("age");
            //attribute.Value = "39";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "Jane Doe";
            //rootNode.AppendChild(userNode);

            XmlElement eventElement = document.CreateElement("extension");


            for (int i = 0; i <= 3; i++)
            {
                XmlElement element = document.CreateElement("eventTime");
                element.InnerText = "Ads";
                eventElement.AppendChild(element);
            }

            document.AppendChild(eventElement);

            //eventElement.(document, "eventTime", "Ads");

            document.Save("C:\\Users\\Srmri\\Documents\\New Text Document.txt");
        }
    }
}