using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LightControll
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        static SerialPort myport = new SerialPort();

        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
            setup("COM3");
            



        }













        private static void setup(string name)
        {
            
            myport.BaudRate = 20000;
            myport.PortName = name;
            myport.Open();

            //initialisierung
            myport.DiscardNull = true;
            myport.WriteTimeout = 100;

            myport.DiscardInBuffer();
            myport.DiscardOutBuffer();
        }

       

        public static void Write(byte i, byte n)
        {
            if (myport.ReadBufferSize > 0) {
                byte[] send = new byte[2] { n, i };

                myport.Write(send, 0, 2);
                myport.DiscardInBuffer(); }
        }
    }
}
