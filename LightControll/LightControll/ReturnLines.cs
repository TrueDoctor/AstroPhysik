﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LightControl
{
    public static class ReturnLines
    {
        public static string[] line(byte[] brightness)
        {
            string dir = Directory.GetCurrentDirectory();
            string codeRaw = System.IO.File.ReadAllText(Path.Combine(dir, "raw.html"));

            string[] codeRawArray = codeRaw.Split('\n');

            for (int i = 0; i < codeRawArray.Length; i++)
            {
                int index = codeRawArray[i].IndexOf("@");
                if (index >= 0)
                {
                    switch (codeRawArray[i][index + 1])
                    {
                        case '0': codeRawArray[i].Replace("@0", Path.Combine(dir, "amcharts.js")); break;
                        case '1': codeRawArray[i].Replace("@0", Path.Combine(dir, "serial.js")); break;
                        case '2': codeRawArray[i].Replace("@0", Path.Combine(dir, "plugins", "export", "export.min.js")); break;
                        case '3': codeRawArray[i].Replace("@0", Path.Combine(dir, "plugins", "export", "export.css")); break;
                        case '4': codeRawArray[i].Replace("@0", Path.Combine(dir, "themes", "light.js")); break;
                        case '5': codeRawArray[i].Replace("@0", brightness[0].ToString()); break;
                        case '6': codeRawArray[i].Replace("@0", brightness[1].ToString()); break;
                        case '7': codeRawArray[i].Replace("@0", brightness[2].ToString()); break;
                        case '8': codeRawArray[i].Replace("@0", brightness[3].ToString()); break;
                        case '9': codeRawArray[i].Replace("@0", brightness[4].ToString()); break;
                        case 'A': codeRawArray[i].Replace("@0", brightness[5].ToString()); break;
                    }
                }
            }
            return codeRawArray;
        }
    }
}

