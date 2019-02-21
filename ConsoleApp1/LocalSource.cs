using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using AJEFD;

namespace ConsoleApp1
{
    class LocalSource : IPath
    {
        readonly String SourcePath= @"C:\Users\anisb\source\repos\AJEFD\LocalTestImages";
        public LocalSource()
        {

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
            Console.WriteLine("file full name is ..." + file);
            return file;
        }

    }
}
