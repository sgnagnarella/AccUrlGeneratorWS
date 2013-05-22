using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using com.teletech.AUG.Core;


namespace TestDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcclaimUrlGenerator aug = new AcclaimUrlGenerator();
            textBox3.Text = aug.GenerateAcclaimURL(textBox1.Text, textBox2.Text, "!fr#*sD23(#p$&@8");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AcclaimUrlGeneratorWS.AcclaimURLGeneratorSoapClient ws = new AcclaimUrlGeneratorWS.AcclaimURLGeneratorSoapClient();
            textBox3.Text = ws.GenerateUrl(textBox1.Text, textBox2.Text, "!fr#*sD23(#p$&@8");
        }
    }
}
