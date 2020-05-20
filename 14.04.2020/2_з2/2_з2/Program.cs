using System;

namespace _2_з2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            byte a = byte.Parse(Console.ReadLine());
            string resulst = ((a / 100 + a / 10 % 10 + a % 10) % 2 == 0) ? "четное" : "нечетное";
            Console.WriteLine(resulst);
            Console.ReadLine();
        }
    }
}
