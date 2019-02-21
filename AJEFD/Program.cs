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
            //IPath obj = Class1.Create(list);
            String myPath = obj.getPath();
            ////Console.WriteLine("myPath in main is ....." + myPath);
            
            //Console.ReadLine();

        }
    }
}
