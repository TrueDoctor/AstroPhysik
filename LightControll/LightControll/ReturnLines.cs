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
            string dir = Directory.GetCurrentDirectory(); //Pfad der Exe in String "dir" zwischenspeichern
            string codeRaw = System.IO.File.ReadAllText(Path.Combine(dir, "raw.html")); //Rodatei wird in string gelesen

            byte[] brightness_bw = brightness; 
            Array.Reverse(brightness_bw); //Erstellt eine umgedrehte Variante des Brightness-Array

            byte[] brightnessOrdered = (brightness[0] > brightness[5]) ? brightness : brightness_bw; //Je nachdem, welche LED die hellste ist, wird entweder der eigentliche oder der umgedrehte Array verwendet

            string[] codeRawArray = codeRaw.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries); //Zerteilung der Rohdatei in einzelne Strings in einem Array

            for (int i = 0; i < codeRawArray.Length; i++) //Ersetzen aller Ausdrücke @... mit Pfad oder Werten
            {
                int index = codeRawArray[i].IndexOf("@");
                if (index >= 0)
                {
                    switch (codeRawArray[i][index + 1])
                    {
                        case '0': codeRawArray[i] = codeRawArray[i].Replace("@0", dir); break;
                        case '1': codeRawArray[i] = codeRawArray[i].Replace("@1", brightnessOrdered[0].ToString()); break;
                        case '2': codeRawArray[i] = codeRawArray[i].Replace("@2", brightnessOrdered[1].ToString()); break;
                        case '3': codeRawArray[i] = codeRawArray[i].Replace("@3", brightnessOrdered[2].ToString()); break;
                        case '4': codeRawArray[i] = codeRawArray[i].Replace("@4", brightnessOrdered[3].ToString()); break;
                        case '5': codeRawArray[i] = codeRawArray[i].Replace("@5", brightnessOrdered[4].ToString()); break;
                        case '6': codeRawArray[i] = codeRawArray[i].Replace("@6", brightnessOrdered[5].ToString()); break;
                    }
                }
            }
            return codeRawArray;
        }
    }
}

