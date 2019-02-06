using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD
{
    public class LocalPath : IPathCreatorInterface
    {
        String path;
        String name;
        public LocalPath(String type)
        {

            this.name = type;

        }
        public String getPath()
        {
            return this.path;
        }
        public void createPath()
        {
            // logic of creating Path for a local image
            this.path = path + "/" + name;
            Console.Write(" Path of Type Local Created, name is {0} and  the path {1} \n", this.name, this.name);
            
            
        }

       
    }
}
