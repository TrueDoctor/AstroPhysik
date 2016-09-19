﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace LightControl
{
    public partial class Form1 : Form
    {

        public static SerialPort myport = new SerialPort();
        static int num = 0;

        public Form1()
        {
            InitializeComponent();
            searchPorts();
        }

        

         public static void searchPorts() // port Suche
        {

            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
                {
                if (setupPorts(ports[i]) == true)
                {

                    if (myport.ReadBufferSize > 0)
                    {
                        if (myport.ReadChar() == 'B')
                        {
                            return;
                        }
                    }
                    myport.Close();
                }
            }

            MessageBox.Show("Keine Verbindung zur LightBox", "Lightcontrol",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            searchPorts();

        }

        public  byte[] brightnessGet()
        {
            byte[] brightness = new byte[2];
            brightness[0] = (byte) Bar1.Value;
            brightness[1] = (byte)Bar2.Value;
            brightness[2] = (byte)Bar3.Value;
            brightness[3] = (byte)Bar4.Value;
            brightness[4] = (byte)Bar5.Value;
            brightness[5] = (byte)Bar6.Value;
            return brightness;

        }







         



         private static bool setupPorts(string name) //PortSetup
        {

            myport.BaudRate = 20000;
            myport.PortName = name;            
            myport.RtsEnable = true;
            myport.DtrEnable = true;
            try
            {
                myport.Open();

                //initialisierung

                myport.DiscardNull = true;
                myport.WriteTimeout = 100;

                myport.DiscardInBuffer();
                return true;
            }
            catch { return false; }
        }

        public void send(byte id, byte value) //Sende Funktion
        {
            if (myport.ReadBufferSize > 0)
            {
                byte[] sendData = new byte[2] { id, value };

                myport.Write(sendData, 0, 2);
                myport.DiscardInBuffer();
            }
        }



        public bool createHTML(byte[] brightness)
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "HTML Datei|*.html";
            sFD.Title = "Ergebnisse speichern unter:";
            if (sFD.FileName != "")
            {
                try
                {
                    System.IO.File.WriteAllLines(sFD.FileName, ReturnLines.line(brightness));
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ausnahme trat auf: \n" + e, "Fehler" , MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Es wurde kein Dateiname eingegeben.", "Fehlender Dateiname", MessageBoxButtons.OK);
            };

            return true;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

       
        private void Bar1_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)Bar1.Value;
            try
            {
                send(id: 1, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar2_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)Bar2.Value;
            try
            {
                send(id: 2, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar3_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)Bar3.Value;
            try
            {
                send(id: 3, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar4_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)Bar4.Value;
            try
            {
                send(id: 4, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar5_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)Bar5.Value;
            try
            {
                send(id: 5, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar6_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)Bar6.Value;
            try
            {
                send(id: 6, value: i);
            }
            catch { searchPorts(); }
        }
    }
}
