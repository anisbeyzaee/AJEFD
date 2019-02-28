using ClassLibrary1;
using System;



namespace AJEFD
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ReadConfig rc = new ReadConfig();
            rc.ReadObjType();
            String[] list = rc.ReadObjType();
            IPath obj = ObjectFactoryPath.Create(list);
            Console.WriteLine(obj);
            Console.Read();

        }
    }
}
