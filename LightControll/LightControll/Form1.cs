using System;
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
using System.Threading;

namespace LightControl
{
    public partial class Form1 : Form
    {

        public static SerialPort myport = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(50);
            searchPorts();
        }

        

         public static void searchPorts() // port Suche
        {

            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
                {
                for (int i = 0; i < 4; i++)
                {
                    if (setupPorts(port) == true)
                    {

                        if (myport.ReadBufferSize > 0)
                        {
                            if (myport.ReadByte() == 42)
                            {
                                return;
                            }
                        }
                        myport.Close();
                    }
                }
            }

            DialogResult result = MessageBox.Show("Keine Verbindung zur LightBox", "Lightcontrol", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Cancel) { return; }
            else if (result == DialogResult.Retry) { searchPorts();}


        }





        private  byte[] brightnessGet()
        {
            byte[] brightness = new byte[6];
            brightness[0] = (byte)(255-Bar1.Value);
            brightness[1] = (byte)(255-Bar2.Value);
            brightness[2] = (byte)(255-Bar3.Value);
            brightness[3] = (byte)(255-Bar4.Value);
            brightness[4] = (byte)(255-Bar5.Value);
            brightness[5] = (byte)(255-Bar6.Value);
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

                //Initialisierung

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
            sFD.ShowDialog(); //Zeigt Dialog zum Abspeichern an
            if (sFD.FileName != "")
            {
                try
                {
                    System.IO.File.WriteAllText(sFD.FileName, String.Join("", ReturnLines.line(brightness))); //Schreibt den bearbeiteten HTML Code in neue Datei (ReturnLines.lines ist in einer extra Datei untergebracht)
                    System.Diagnostics.Process startHTML = new System.Diagnostics.Process();                  //Code zum Öffnen der Erstellten Datei
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C \"" + sFD.FileName + "\"";
                    startHTML.StartInfo = startInfo;
                    startHTML.Start();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ausnahme trat auf: \n" + e, "Fehler" , MessageBoxButtons.OK); //Fehlermeldung für unbehandelten Fehler
                }
            }
            else //Fehlermeldung bei leerem Dateinamen
            {
                MessageBox.Show("Es wurde kein Dateiname eingegeben.", "Fehlender Dateiname", MessageBoxButtons.OK);
            };

            return true;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            byte[] ab = { 123, 123 };
            ReturnLines.line(ab);
        }

       
        private void Bar1_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)(255-Bar1.Value);
            try
            {
                if (!check1.Checked)
                    send(id: 1, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar2_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)(255-Bar2.Value);
            try
            {
                if (!check2.Checked)
                    send(id: 2, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar3_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)(255-Bar3.Value);
            try
            {
                if (!check3.Checked)
                    send(id: 3, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar4_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)(255-Bar4.Value);
            try
            {
                if (!check4.Checked)
                    send(id: 4, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar5_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)(255-Bar5.Value);
            try
            {
                if (!check5.Checked)
                    send(id: 5, value: i);
            }
            catch { searchPorts(); }
        }
        private void Bar6_Scroll(object sender, ScrollEventArgs e)
        {
            byte i = (byte)(255-Bar6.Value);
            try
            {
                if (!check6.Checked)
                    send(id: 6, value: i);
            }
            catch { searchPorts(); }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            createHTML(brightnessGet());
        }

        private void button1_Click(object sender, EventArgs e) //Standardwerte einrichten
        {
            Bar1.Value = 255;
            Bar1_Scroll(null, null);
            Bar6.Value = 1;
            Bar6_Scroll(null, null);
            check1.Checked = true;
            check6.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bar1.Value = 0;
            Bar1_Scroll(null, null);
            Bar2.Value = 0;
            Bar2_Scroll(null, null);
            Bar3.Value = 0;
            Bar3_Scroll(null, null);
            Bar4.Value = 0;
            Bar4_Scroll(null, null);
            Bar5.Value = 0;
            Bar5_Scroll(null, null); 
            Bar6.Value = 0;
            Bar6_Scroll(null, null);
        }
    }
}
