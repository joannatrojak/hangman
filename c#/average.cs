using System;
using System.Linq;

namespace ConsoleApp32
{
    class Program
    {
        static void average(int[] list)
        {
            int sum = list.Sum();
            Console.WriteLine(Math.Floor(Convert.ToDouble(sum / list.Length)));
        }
        static void Main(string[] args)
        {
            int[] list = { 4, 1, 2, 3, 4 };
            average(list);
        }
    }
}
