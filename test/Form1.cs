using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            label2.Text = (a + b).ToString();
            label3.Text = (a - b).ToString();
            label5.Text = (a * b).ToString();
            if (b != 0) label7.Text = (a / b).ToString();
            else label7.Text = "nelze";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            label2.Text = (a + b).ToString();
        }
    }
}
