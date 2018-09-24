using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp31
{
    class Program
    {
        static void oddEven(int[] numbers)
        {
            List<int> result = new List<int>();
            List<int> result2 = new List<int>();
            List<int> merged = new List<int>();

            for (int i = 1; i< numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
                else
                {
                    result2.Add(numbers[i]);
                }
            }
            merged = result.Concat(result2).ToList();
            merged.ForEach(Console.WriteLine);
        }
        static void Main(string[] args)
        {
            int[] numbers = { 4, 1, 2, 3, 5 };
            oddEven(numbers);
        }
    }
}
