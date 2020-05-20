using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double x = double.Parse(textBox3.Text);

            double y = 2.4 * Math.Abs((Math.Pow(x, 2)+b)/a) + (a+b)* Math.Pow(Math.Sin(a-b), 2) + (1/100) * (x-b);
            label5.Text = y.ToString();
        }
    }
}
