using System;

namespace ConsoleApp10
{
    class Program
    {
        private static double CircleAr(int d, int r)
        {
            const double pi = 3.141592654;
            return Math.Round(((Math.Pow(d, 2)) - (Math.Pow(r, 2) / 4)) * pi, 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CircleAr(10, 10));
        }
    }
}
