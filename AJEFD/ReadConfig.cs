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
            doc = new XmlDocument();
        }
        public String[] ReadObjType()
        {
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
        
        // public List<DataService> Read()
        // {
            
            
        //    List<DataService> dataServiceList = new List<DataService>();
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<DataService>));
        //    using (Stream fileStream = File.OpenRead(@"C:\Users\anisb\source\repos\AJEFD\AJEFD\bin\Debug\Config.xml"))
        //    {
        //        dataServiceList = (List<DataService>)serializer.Deserialize(fileStream);
        //    }
           
        //    foreach (DataService ds in dataServiceList)
        //    {
        //       /// Console.WriteLine(ds);
        //    }
        //    return dataServiceList;
        // }



        ////  this method can reconstruct the XML configuration file
        ////  in case of loosing the file or if the format is corrupted somehow, Admin can run this method
        ////  A clean Config file will be written with the right format 
        //public void configRebuild()
        //{
        //    List<DataService> dataServiceList = new List<DataService>
        //    {
        //        new DataService("Active", "type will be  'Local'   for now ", @"C:\Users\anisb\source\repos\AJEFD\LocalTestImages"),
        //        new DataService("Active", "type will be 'EarthNow'", @"C:\Users\anisb\source\repos\AJEFD\EartnowTestImages"),

        //    };

        //    using (Stream fs = new FileStream(@"C:\Users\anisb\source\repos\AJEFD\AJEFD\bin\Debug\Config.xml", FileMode.Create, FileAccess.Write, FileShare.None))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(List<DataService>));
        //        serializer.Serialize(fs, dataServiceList);
        //    }
        //}
    }

}
    
   
