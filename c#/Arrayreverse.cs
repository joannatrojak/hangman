using System;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 1, 2, 3, 4, 5, 6, 7 };
            int[] result = array.Distinct().ToArray();
            Array.Reverse(result);
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }
    }
}
