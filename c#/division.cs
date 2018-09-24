using System;
using System.Collections.Generic;

namespace ConsoleApp28
{
    class Program
    {
        static void division(int n, int x, int y)
        {
            List<int> result = new List<int>(); 
            for (int i = 1; i < n; i++)
            {
                if (i % x == 0 && i % y != 0)
                {
                    result.Add(i);
                }
            }
            result.ForEach(Console.WriteLine);
        }
        static void Main(string[] args)
        {
            division(7, 2, 4);
        }
    }
}
