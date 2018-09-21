using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3};
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
