using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AJEFD
{   /*  Creating a Type for the data service that we are using in this project
    *   Each DataService refferes to a way of receiving Test Images(For now either local or EarthNow)
    *   In case of EarthNow is launched, more Field for this type will be added. in that case local will have null value for those fields
    *   TODO : will change the type from String to enum in. purpose of doing that is to limitate any possible user mistake. invalid input
    *   or typo will be handled in proper way
    * 
    */
    
    [Serializable()]
    public class DataService
    {
        [System.Xml.Serialization.XmlElement("Status")]
        public string Status { get; set; }

        [System.Xml.Serialization.XmlElement("Type")]
        public string Type { get; set; }

        [System.Xml.Serialization.XmlElement("SourceFolder")]
        public string SourceFolder { get; set; }
        public DataService() { }
        public DataService(String status = "disable",
                String type = "Write Type Here", String sourceFolder = @"C:\Temp")
        {
            Status = status;
            Type = type;
            SourceFolder = sourceFolder;

        }

        public override string ToString()
        {
            return string.Format(" Status is {0}  for the Type {1}   SourseFolder{2}", Status, Type, SourceFolder);
        }
    }


}

