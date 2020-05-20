using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _2__6
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 0; //1 число
            double b = 0; //2 число
            double c = 0; // 3 число

            Console.WriteLine("Vvedite 3 veshchestvennykh chisla"); //Вывод текста пользователю
            Console.Write("a= ");//Вывод текста пользователю

            a = Convert.ToDouble(Console.ReadLine()); //Ввод текста пользователем и запись в переменую
            Console.Write("b= ");//Вывод текста пользователю

            b = Convert.ToDouble(Console.ReadLine());//Ввод текста пользователем и запись в переменую
            Console.Write("c= ");//Вывод текста пользователю

            c = Convert.ToDouble(Console.ReadLine());//Ввод текста пользователем и запись в переменую
            Console.WriteLine("({0:F2}+{1})+{2:F2} = {0:F2}+({1}+{2:F2})", a, Math.Round(b, 2), c);  //Округление чисел после запятой до 2 знаков и вывод строки пользователю
            /*
             * f - формат c плавающей запятой
             * 2 - кол-во знаков после запятой
            */ 
            Console.ReadLine();
        }
    }
}
