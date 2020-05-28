using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button btn = new Button(); //Новая кнопка
                this.Controls.Add(btn); //Добавление кнопки в форму
                btn.Location = new Point(e.X, e.Y); //координата e.X - x координата, координата e.Y - y координата
                btn.Text = string.Format("{0}, {1}", e.X, e.Y); //Перевод в строку
            }
        }
    }
}
