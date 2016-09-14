using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM9";
            myport.Open();

            myport.Write("1,0");

                       
            for(int i= 0;i<=2550;i++) 
            {
                myport.WriteLine("1,"+i.ToString());
                
                string data = myport.ReadLine();
                Console.WriteLine(i);
                
            }

        }
    }
}
