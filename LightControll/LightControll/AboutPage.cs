using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightControl
{
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutPage.ActiveForm.Close();
        }

        private void linkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((sender as LinkLabel).Text);
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {
            linkLabel2.Links.Add(166, 21, "https://processingfoundation.org/");
            linkLabel2.Links.Add(79, 5, "https://p5js.org/");
            linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Determine which link was clicked within the LinkLabel.
            linkLabel2.Links[linkLabel2.Links.IndexOf(e.Link)].Visited = true;
            // Display the appropriate link based on the value of the LinkData property of the Link object.
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
