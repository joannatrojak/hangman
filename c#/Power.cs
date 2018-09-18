using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Power(double a, double b)
        {
            string power = Convert.ToString(Math.Pow(Convert.ToInt32(a), Convert.ToInt32(b)));
            int length = power.Length; 

            if (length == 1)
            {
                Console.WriteLine(power);
            }
            if (length > 1)
            {
                Console.WriteLine(power[length - 1]); 
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj podstawę i potęgę: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Power(a, b);
        }
    }
}
