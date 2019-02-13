using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
namespace AJEFD
{
    class ExternalCom
    {
        public ExternalCom(String path)
        {
            connect(path);

        }

        private void connect(String path)
        {
            ProcessStartInfo s = new ProcessStartInfo();
            s.FileName = @"C:\Program Files\Java\jdk-11.0.2\bin\java.exe";

            s.WorkingDirectory = @"C:\Temp";


            s.Arguments = @"H " + path; // C:\Temp\ForestImage.png";

            s.UseShellExecute = false;

            s.RedirectStandardOutput = true;

            s.RedirectStandardError = true;

            s.CreateNoWindow = true;
            Process process = new Process();

            process.StartInfo = s;

            process.Start();

            while (!process.StandardOutput.EndOfStream)

            {

                string isFire = process.StandardOutput.ReadLine();



                System.Windows.MessageBox.Show(path + isFire);

                break;

            }
        }

    }
}
