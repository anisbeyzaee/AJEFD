using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJEFD
{
    public class LocalPath : IPathInterface
    {   
        String path;
        String name;
        public LocalPath(DataService ds)
        {
            path = ds.SourceFolder;
           // this.name = type;
            print();
        }

        //TO DO
        // select a random file here and add the name to the folder
        public String getPath()
        {
            Console.Write(" Path of Type Local Created, name is {0} and  the path {1} \n", this.name, this.name);
            return path+ getrandomfile(path);
        }



        private string getrandomfile(string path)
        {
            string file = null;
            if (!string.IsNullOrEmpty(path))
            {
                var extensions = new string[] { ".png", ".jpg", ".gif" };
                try
                {
                    var di = new DirectoryInfo(path);
                    var rgFiles = di.GetFiles("*.*").Where(f => extensions.Contains(f.Extension.ToLower()));
                    Random R = new Random();
                    file = rgFiles.ElementAt(R.Next(0, rgFiles.Count())).FullName;
                }
                // probably should only catch specific exceptions
                // throwable by the above methods.
                catch { }
            }
            return file;
        }


        public void print()
        {
            // logic of creating Path for a local image
            this.path = path + "/" + name;
            Console.Write(" Path of Type Local Created, name is {0} and  the path {1} \n", this.name, this.name);
            //Console.WriteLine();
                  // Console.ReadLine();

        }


    }
}
