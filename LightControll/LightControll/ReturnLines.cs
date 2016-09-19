using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnL
{
    class ReturnLines
    {
        string[] line(string[] brightness)
        {
            string[] lines =
            {
                    "<!DOCTYPE html>",
                    "<html>",
                    "  <head>",
                    "    <meta charset=\"UTF-8\">",
                    "    <title>Auswertung der Helligkeiten</title>",
                    "    <style>",
                    "      table, td, th { broder: 1px solid black }",
                    "    </style>",
                    "  </head>",
                    "  <body>",
                    "    <table>",
                    "      <tr>",
                    "        <th>LED</th>",
                    "        <th>Helligkeit</th>",
                    "      </tr>",
                    "      <tr>",
                    "        <td>1</td>",
                    "        <td>"+brightness[0]+"</td>",
                    "      </tr>",
                    "      <tr>",
                    "        <td>1</td>",
                    "        <td>"+brightness[1]+"</td>",
                    "      </tr>",
                    "      <tr>",
                    "        <td>1</td>",
                    "        <td>"+brightness[2]+"</td>",
                    "      </tr>",
                    "      <tr>",
                    "        <td>1</td>",
                    "        <td>"+brightness[3]+"</td>",
                    "      </tr>",
                    "      <tr>",
                    "        <td>1</td>",
                    "        <td>"+brightness[4]+"</td>",
                    "      </tr>",
                    "      <tr>",
                    "        <td>1</td>",
                    "        <td>"+brightness[5]+"</td>",
                    "      </tr>",
                    "    </table>",
                    "  </body>",
                    "</html>"
            };
            return lines;
        }
    }
}
