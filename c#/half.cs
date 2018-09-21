using System;

namespace ConsoleApp25
{
    class Program
    {
        static void half(int number, string[] strings)
        {
            for (int i = 0; i< number; i++)
            {
                if (strings[i].Length % 2 == 0)
                {
                    string text = strings[i];
                    Console.WriteLine(text.Substring(0, text.Length/2));
                }
            }
        }
        static void Main(string[] args)
        {
            string[] strings = { "pierwszy", "lubiec", "ktotozrobi" };
            half(3, strings);
        }
    }
}
