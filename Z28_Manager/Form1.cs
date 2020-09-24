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
        PathRedactor pathRedactor;

        public Form1()
        {
            InitializeComponent();
            transporter = new Transporter();
            pathRedactor = new PathRedactor();
            textBox1.Text = "deba\\2.txt";
            textBox4.Text = "deba\\1\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transporter.transportFiles(textBox1.Text, textBox3.Text, false);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            transporter.transportFiles(textBox1.Text, textBox3.Text, true);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = pathRedactor.replaceFileNameInPath(textBox1.Text, textBox2.Text, checkBox1.Checked);
            textBox5.Text = pathRedactor.replacePathToDirectory(textBox1.Text, textBox4.Text);
        }
    }
}
