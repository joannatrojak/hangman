using System;

namespace ConsoleApp17
{
    class Program
    {
        static void shiftArray(int[] array)
        {
            int[] shifted = new int[array.Length];
            for (int i = 1; i< array.Length-1; i++)
            {
                shifted[i] = array[i + 1];
                Console.WriteLine(shifted[i]);
            }

        }
        static void Main(string[] args)
        {
            int[] array = { 7, 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(array.Length);
            shiftArray(array);
        }
    }
}
