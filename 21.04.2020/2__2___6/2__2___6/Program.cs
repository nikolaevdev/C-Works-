using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2__2___6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0; // 1 катет
            double b = 0; // 2 катет 
            double c = 0; // 2 гипотенуза

            Console.Write("vvedite gupotenyzi = "); //Вывод текста пользователю
            c = Convert.ToDouble(Console.ReadLine()); //Ввод текста пользователем и запись в переменую

            Console.Write("vvedite katet = "); //Вывод текста пользователю
            b = Convert.ToDouble(Console.ReadLine()); //Ввод текста пользователем и запись в переменую
       
            a = Math.Sqrt(Math.Pow(c, 2)- Math.Pow(b, 2));

            Console.Write("katet a = {0}", a); //Вывод текста пользователю
            Console.ReadLine();

        }
    }
}
