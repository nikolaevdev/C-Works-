using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
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

            double y = 4.5 * (Math.Pow((a + b), 2) / Math.Pow((a - b), 2)) - (Math.Sqrt((a+b)*(a-b)))+(1/10) * (Math.Log10(a -b)/ Math.Log10(a +b)) * Math.Exp(Math.Pow(x, 2));
            label5.Text = y.ToString();
        }
    }
}
