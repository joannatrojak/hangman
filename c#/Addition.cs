using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb chcesz dodać: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (count > 0)
            {
                Console.WriteLine("Podaj liczby do dodania: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                count --;
                Console.WriteLine(sum);
            }
        }
    }
}
