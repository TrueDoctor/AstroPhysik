using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial
{
    public class Class1
    {
        public static void setup(string name)
        {
            SerialPort myport = new SerialPort();
            myport.BaudRate = 20000;
            myport.PortName = name;
            myport.Open();

            //initialisierung
            myport.DiscardNull = true;
            myport.WriteTimeout = 100;

            myport.DiscardInBuffer();
            myport.DiscardOutBuffer();
        }

        public static void canRead
        {
            if (myport.ReadBufferSize > 0)
                return 1; 
            else 
                return 0;
        }

        public static void Write(byte i, byte n)
        {
            byte[] send = new byte[2] { n, i };

            myport.Write(send, 0, 2);
            myport.DiscardInBuffer();
        }
    }
}
