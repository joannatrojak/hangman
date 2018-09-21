using System;

namespace ConsoleApp22
{
    class Program
    {
        static int delta(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            
            if (delta > 0)
            {
                return 2; 
            }
            if (delta == 0)
            {
                return 1; 
            }
            if (delta < 0)
            {
                return 0; 
            }
            return -1; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynniki delty: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(delta(a, b, c));
        }
    }
}
