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

            string[] codeRawArray = codeRaw.Split('\n');

            for (int i = 0; i < codeRawArray.Length; i++)
            {
                if (codeRawArray[i].IndexOf("{*}"))
                {

                }
            }
            MessageBox.Show(codeRawArray[0]);

            string[] arraya = { "a", "b" };
            return arraya;
            //return lines;
        }
    }
}

