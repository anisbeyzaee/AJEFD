using System;
using System.xml;

public class ReadConfig
{
	public ReadConfig()
	{
        XmlDocument doc = new XmlDocument();
        doc.Load("Config.xml");

        foreach(XmlNode node in doc.DocumentElement)
        {
            if(node.Attributes[1].InnerText == True)
            {
                Console.Write(" Active DataService %d  Path to Images %d", node.Attributes[1].InnerText, node.Text);

            }
        }
        Console.ReadLine();

    }

}
