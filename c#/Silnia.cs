using System;
using System.Collections.Generic;
using System.Linq;

namespace Silnia
{
    class Program
    {
        static int Factorial(int n)
        {
            int factorial = 1;
            if (n <= 1)
            {
                return 1; 
            }
            for (int i = 1; i < (n + 1); i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        public static void Digits(int n)
        {
            if (n > 9)
            {
                Console.Write("0 0");
            }
            else
            {
                string number_as_string = Convert.ToString(Factorial(n));
                int length = number_as_string.Length; 
                if (length >= 2)
                {
                    Console.WriteLine(number_as_string[length - 2] + " " + number_as_string[length - 1]); 
                }
                else
                {
                    Console.WriteLine("0 " + number_as_string[length - 1]);
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of {0} is {1}", n, Factorial(n));
            Digits(n);
            //Console.ReadLine();
        }
    }
}
