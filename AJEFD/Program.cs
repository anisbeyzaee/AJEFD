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
            
            IPathInterface obj = ObjectFactoryPath.Create(rc.Read());
            String myPath = obj.getPath();
            Console.Write("myPath in main is ....." + myPath);
            ExternalCom ec = new ExternalCom("myPath");
            Console.ReadLine();

        }
    }
}
