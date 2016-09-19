using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LightControl
{
    public static class ReturnLines
    {
        public static string[] line(byte[] brightness)
        {
            string dir = Directory.GetCurrentDirectory();
            string coderaw = System.IO.File.ReadAllText(Path.Combine(dir, "raw.hmtl"));



            return lines;
        }
    }
}

