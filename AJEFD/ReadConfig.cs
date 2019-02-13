using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;  //writing to a file
using System.Runtime.Serialization.Formatters.Binary;  //toBinary
using System.Xml.Serialization;  //to serialize xml
using System.Runtime.Serialization;

namespace AJEFD
{
    class  ReadConfig
    {

         
         public List<DataService> Read()
         {
            
            
            List<DataService> dataServiceList = new List<DataService>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<DataService>));
            using (Stream fileStream = File.OpenRead(@"C:\Users\anisb\source\repos\AJEFD\AJEFD\bin\Debug\Config.xml"))
            {
                dataServiceList = (List<DataService>)serializer.Deserialize(fileStream);
            }
           
            foreach (DataService ds in dataServiceList)
            {
               /// Console.WriteLine(ds);
            }
            return dataServiceList;
         }



        //  this method can reconstruct the XML configuration file
        //  in case of loosing the file or if the format is corrupted somehow, Admin can run this method
        //  A clean Config file will be written with the right format 
        public void configRebuild()
        {
            List<DataService> dataServiceList = new List<DataService>
            {
                new DataService("Active", "type will be  'Local'   for now ", @"C:\Users\anisb\source\repos\AJEFD\LocalTestImages"),
                new DataService("Active", "type will be 'EarthNow'", @"C:\Users\anisb\source\repos\AJEFD\EartnowTestImages"),

            };

            using (Stream fs = new FileStream(@"C:\Users\anisb\source\repos\AJEFD\AJEFD\bin\Debug\Config.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<DataService>));
                serializer.Serialize(fs, dataServiceList);
            }
        }
    }

}
    
   
