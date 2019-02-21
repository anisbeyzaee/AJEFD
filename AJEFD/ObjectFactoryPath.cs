using System;
using System.IO;
using System.Reflection;
using System.Linq;
using ClassLibrary1;
using LocalResources;

namespace AJEFD
{
    class ObjectFactoryPath
    {
        
        
        public static IPath Create(String[] fileInfo)
        {
            string getPath;
            //String[] info;
            String[] myList;
            myList = fileInfo;
            IPath IObj;
            String dllFileName = myList[1];
            String nameSpace = myList[2];
            String className = myList[3];
            
                // Step 1:  Load the DLL that contains this class (this DLL is called BBCustomizers.dll).
                // --------------------------------------------------------------------------------------

                // Construct the path of this DLL. In this case assume it is in the same directory where
                // this client program is running from.

                string thisClientDirectory = GetThisAssemblyDirectory();
                string dllPath = Path.Combine(thisClientDirectory, dllFileName);
                if (!File.Exists(dllPath))
                {
                    Console.WriteLine("ERROR: File " + dllPath + " does not exist");
                    
                }

                // Load the DLL
                Assembly customDLL = Assembly.LoadFrom(dllPath);

                // Step 2:  Look for the class defined in the DLL. We know its name including the namespace.
                // ----------------------------------------------------------------------------------------
               
                Type t = customDLL.GetType(className);
                if (t == null)
                {
                    Console.WriteLine("ERROR: Can't find class named " + dllFileName + " for now in DLL " + dllPath);
                   
                }

                // Step 3:  Create an instance of the specified type and cast it to the interface it is 
                //          supposed to implement.
                // ------------------------------------------------------------------------------------

                // Since we don't know the concrete type at compile time, we will save the instance in an
                // object of type "object"

                // Create an instance of the class.
                object o = Activator.CreateInstance(t);

                // Check if o is of type ICustomer.
                if (!(o is IPath))
                {
                    Console.WriteLine("ERROR: Class :: " + className+ "   does not implement interface IPath");
                    ////////return;
                }

                // Cast it to ICustomer
                IPath customerObj = (IPath)o;

                // Step 4:  Interact with the object.
                // ----------------------------------
                getPath = customerObj.getPath();
            ExternalCom ec = new ExternalCom(getPath);
            // Console.WriteLine("Customer 23466789: canDelete1 = " + getPath);
            IObj = customerObj;
                


            // Summary:
            // ========
            // We were able to create an instance of a class we didn't know of its type at compile time.
            // We only knew metadata about it (in what DLL it is, the class name, what interface it implements).
            // Once the instance is created, we interact with it as if we have created it via the new keyword.


            Console.ReadLine();

            return IObj; 

        }
        private static string GetThisAssemblyDirectory()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }
    }
}
