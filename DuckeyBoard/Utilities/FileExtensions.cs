using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckeyBoard.Utilities
{
    public static class FileExtensions
    {
        public static bool SaveConfigFile(string path = "")
        {
            if (!File.Exists(path))
                File.Create(path);

            using StreamReader sr = new StreamReader(path);
            var line = sr.ReadToEnd();
            

        } 

    }
}
