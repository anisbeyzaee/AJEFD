using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD
{
    class ObjectFactoryPath
    {

        public static IPathCreatorInterface Create(String type, String name)
        {


            if (type == "EarthNow")
            {
                return new EarthNow(name);
            }
            else
            {
                return new LocalPath(name);
            } 

            //var check = ConfigurationManager.AppSettings[type];
            //switch (check)
            //{

            //    case "EarthNow":
            //        return new Local(type);
            //        break;
            //    case "Local":
            //        return new Local(type);
            //        break;
            //}
        }
    }
}
