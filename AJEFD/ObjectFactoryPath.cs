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

        public static IPathInterface Create(List<DataService> dataServices)
        {
            // Ask Alfred about this: Efficiency
            DataService myDataService = new DataService();
            String sourceFolder = null;
            Boolean localImage = false;
            Boolean earthNow = false;
            Console.WriteLine("HERE in ObjectFactoryPath");
                   

            

            foreach( DataService ds in dataServices)
            {
                if (ds.Status.ToLower().Equals("enable") && ds.Type.ToLower().Equals("local"))
                {
                    localImage = true;
                    myDataService = ds;
                }
                //return new LocalPath(ds.SourceFolder);
                if (ds.Status.ToLower().Equals("enable") && ds.Type.ToLower().Equals("earthnow"))
                {
                    earthNow = true;
                    myDataService = ds;

                }
            }

            if (localImage)
                return new LocalPath(myDataService);

            else
                return new EarthNow(myDataService);
            
            //TO DO
            // add error handling of any case:
            //
            // there is typo
            // none is selected
            // etc..
        }
    }
}
