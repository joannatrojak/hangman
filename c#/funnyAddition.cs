using System;

namespace ConsoleApp8
{
    class Program
    {
        static string reverse (string n)
        {
            char[] CharArray = n.ToCharArray();
            Array.Reverse(CharArray);
            return new String(CharArray);
        }
        static string palindrome(int n)
        {
            int count = 0;
            while (n != Convert.ToInt32(reverse(n.ToString())))
            {
                n = n + Convert.ToInt32(reverse(n.ToString()));
                count += 1;
            }
            return n.ToString() + " " + count.ToString();
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            string n = Console.ReadLine();
            Console.WriteLine(reverse(n));
            Console.WriteLine(palindrome(Convert.ToInt32(n)));
        }
    }
}
