using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AJEFD
{
    class ReadConfig
    {
        String type;
        String path;
        String name;
        public ReadConfig() { 
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");


            foreach(XmlNode node in doc.DocumentElement)
            {
                if (node.Attributes[1].InnerText == "True")
                {
                    Console.Write(" Active DataService :  {0}  Path to Images is :  {1} \n  ", node.Attributes[1].InnerText, node.InnerText);
                    this.type = node.Attributes[1].InnerText;
                }
            }
            Console.ReadLine();
        }

        public String getTheType()
        {
            return type;
        }
        public String getName()
        {
            return name;
        }
    }

    
}
