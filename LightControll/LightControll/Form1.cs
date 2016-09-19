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

        static SerialPort myport = new SerialPort();
        static int num = 0;

        public Form1()
        {
            InitializeComponent();
            searchPorts();
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
           
            

            label1.Text = Bar.Value.ToString();
       

            byte i = (byte)Bar.Value;
            try
            {
                send(id: 1, value: i);
            }
            catch { searchPorts(); }

           
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









         



        private static bool setupPorts(string name) //PortSetup
        {

            myport.BaudRate = 20000;
            myport.PortName = name;
                myport.DiscardOutBuffer();
                return true;
            myport.RtsEnable = true;
            myport.DtrEnable = true;
            try
            {
                myport.Open();

                //initialisierung
                myport.DiscardNull = true;
                myport.WriteTimeout = 100;

                myport.DiscardInBuffer();
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
                System.IO.File.WriteAllLines(sFD.FileName, ReturnLines.line(brightness));
            }

            return true;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

    }
}
