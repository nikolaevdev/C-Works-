using System;

namespace _2_p3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y= ");
            int y = int.Parse(Console.ReadLine());
            int a = y / 100;
            int b = (y / 10) % 10;
            int c = y % 10;
            int p = 100 * c + 10 * b + a;

            if (y == p)
                Console.WriteLine("Число {0} палиндром ", y);
            else Console.WriteLine("Число {0} не палиндром ", y);

            Console.ReadLine();
        }
    }
}
