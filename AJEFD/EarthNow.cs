using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD
{
    public class EarthNow : IPathCreatorInterface
    {
        String path;
        String name;
        public EarthNow(String name)
        {

            this.name = name;

        }
        public String getPath()
        {
            return this.path;
        }
        public void createPath()
        {
            // logic of creating Path for a EarthNow image
            Console.Write(" Path of Type EarthNOw Created, name is {0} and  the path {1} \n", this.name, this.name);
           //this.path = earthApi.getPath(importedImage);
        }
    }
}
