using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AJEFD
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadConfig rc = new ReadConfig();
            IPathCreatorInterface obj = ObjectFactoryPath.Create(rc.getTheType(), rc.getName());
            String myPath = obj.getPath();
            ExternalCom ec = new ExternalCom(myPath);

        }
    }
}
