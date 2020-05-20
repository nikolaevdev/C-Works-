using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
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

            double y = ((a * x - Math.Sqrt(b)) / (5.7 * (Math.Pow(x, 2) + Math.Pow(b, 2)))) - ((Math.Abs(x + b) - Math.Pow(a, 2)) / (Math.Pow(x, 2)) * Math.Pow(Math.Tan(b), 2));
            label5.Text = y.ToString();
        }
    }
}
