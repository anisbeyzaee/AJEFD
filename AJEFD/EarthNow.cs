using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD
{
    public class EarthNow : IPathInterface
    {
        DataService myDataService;
        String path;
        String name;
        public EarthNow(DataService ds)
        {
           myDataService = ds;
            

        }
        public String getPath()
        {
            Console.Write(" Path of Type EarthNOw Created,   the path is +> {0} \n", myDataService.SourceFolder);
            return myDataService.SourceFolder;
        }
        public void createPath()
        {
            // logic of creating Path for a EarthNow image
            Console.Write(" Path of Type EarthNOw Created, name is {0} and  the path {1} \n", this.name, this.name);
           //this.path = earthApi.getPath(importedImage);
        }
    }
}
