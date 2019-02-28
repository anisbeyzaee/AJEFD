using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;  //writing to a file
using System.Xml.Serialization;  //to serialize xml


namespace AJEFD
{
    
    class  ReadConfig
    {
        readonly string configurationFile = @"C:\Users\anisb\source\repos\AJEFD\AJEFD\bin\Debug\Config.xml";
        XmlDocument doc;
        String[] objTypeContainer= new string[5];
        public ReadConfig()
        {
            
        }
        public String[] ReadObjType()
        {
            doc = new XmlDocument();
            doc.Load(configurationFile);
           
            XmlNodeList TypeNodeList = doc.GetElementsByTagName("Type");
            XmlNodeList DllNameList = doc.GetElementsByTagName("dllFileName");
            XmlNodeList NameSpaceList = doc.GetElementsByTagName("NameSpace");
            XmlNodeList ClassNameList = doc.GetElementsByTagName("ClassName");
            XmlNodeList ClassConfigList = doc.GetElementsByTagName("ClassConfigurationFile");
            // Console.WriteLine("Type is " + TypeNodeList[0].InnerText);
            // Console.WriteLine("dllFile  is  " + DllNameList[0].InnerText);
            // Console.WriteLine("NameSpace is   " + NameSpaceList[0].InnerText);

            objTypeContainer[0] = TypeNodeList[0].InnerText;
            objTypeContainer[1] = DllNameList[0].InnerText;
            objTypeContainer[2] = NameSpaceList[0].InnerText;
            objTypeContainer[3] = ClassNameList[0].InnerText;
            objTypeContainer[4] = ClassConfigList[0].InnerText;


            return objTypeContainer;
        } 
 
    }

}
    
   
