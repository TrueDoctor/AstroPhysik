using System;
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

            string[] codeRawArray = codeRaw.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < codeRawArray.Length; i++)
            {
                int index = codeRawArray[i].IndexOf("@");
                if (index >= 0)
                {
                    switch (codeRawArray[i][index + 1])
                    {
                        case '0': codeRawArray[i] = codeRawArray[i].Replace("@0", dir); break;
                        case '1': codeRawArray[i] = codeRawArray[i].Replace("@1", brightness[0].ToString()); break;
                        case '2': codeRawArray[i] = codeRawArray[i].Replace("@2", brightness[1].ToString()); break;
                        case '3': codeRawArray[i] = codeRawArray[i].Replace("@3", brightness[2].ToString()); break;
                        case '4': codeRawArray[i] = codeRawArray[i].Replace("@4", brightness[3].ToString()); break;
                        case '5': codeRawArray[i] = codeRawArray[i].Replace("@5", brightness[4].ToString()); break;
                        case '6': codeRawArray[i] = codeRawArray[i].Replace("@6", brightness[5].ToString()); break;
                    }
                }
            }
            return codeRawArray;
        }
    }
}

