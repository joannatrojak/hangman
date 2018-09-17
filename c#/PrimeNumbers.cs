using System;

namespace ConsoleApp3
{
    class Program
    {
        public static string IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return "NIE";
                }
                return "TAK";
            }
            return "NIE";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Is Prime: {0}", IsPrime(5));
            Console.ReadLine();
        }
    }
}
