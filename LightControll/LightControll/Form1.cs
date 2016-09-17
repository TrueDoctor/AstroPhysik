using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightControll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myport.Open();
            myport.DiscardNull = true;
            myport.WriteTimeout = 100;

            myport.DiscardInBuffer();
            myport.DiscardOutBuffer();
            myport.BaudRate = 20000;

        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
           
            //myport.PortName = "COM3"; 

            label1.Text = Bar.Value.ToString();
            //initialisierung

            byte i = (byte)Bar.Value;
            send(id: 1,value: i);

           
        }

        public void send(byte id, byte value)
        {
            if (myport.ReadBufferSize > 0)
            {
                byte[] sendData = new byte[2] { id, value };

                myport.Write(sendData, 0, 2);
                myport.DiscardInBuffer();
            }
        }
    }
}
