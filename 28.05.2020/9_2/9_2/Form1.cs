using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender, MouseEventArgs e)
        {
            Control element;

            if (e.Location.X < (Size.Width / 2))
            {
                element = new Button() { 
                    Text = "Кнопка" 
                };
                element.Size = new Size(120, 40);
            }
            else
            {
                element = new TextBox() {
                    Text = "Поле ввода" 
                };
                element.Size = new Size(123, 20);
            }

            element.Location = e.Location;
            this.Controls.Add(element);
        }
    }
}
