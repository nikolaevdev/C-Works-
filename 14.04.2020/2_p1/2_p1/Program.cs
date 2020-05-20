using System;

namespace _2_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("s = ");
            double p = Double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", 4 * Math.Sqrt(p));
            Console.ReadKey();
        }
    }
}
