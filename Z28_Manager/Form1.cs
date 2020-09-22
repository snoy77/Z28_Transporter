using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Z28_Dll;
using Z28_Dll.Transporter;

namespace Z28_Manager
{
    public partial class Form1 : Form
    {
        Transporter transporter;

        public Form1()
        {
            InitializeComponent();
            transporter = new Transporter();
            textBox1.Text = "deba\\2.txt";
            textBox2.Text = "deba\\1\\2.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transporter.transportFiles(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transporter.transportFiles(textBox1.Text, textBox2.Text, true);
        }
    }
}
