using System;
using ClassLibrary1;

namespace EarthNowResources
{
    class EarthNowResource : IPath
    {
        String sourceFolder;
        public EarthNowResource()
        {

        }
        public String getPath()
        {
           // Console.Write(" Path of Type EarthNOw Created,   the path is +> {0} \n", sourceFolder );
            return sourceFolder;
        }
        
    }
}
