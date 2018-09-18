using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static string CountLetters(string letters)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (char s in letters)
            {
                if (letters.Count(x => x == s) <= 2)
                {
                    result.Add(Convert.ToString(s));
                }
                
                if (letters.Count(x => x == s) > 2)
                {
                    result.Add(Convert.ToString(letters.Count(x => x == s)));
                }
            }
            return String.Join("", result.ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountLetters("ABBCCCDDDDEEEEEFGGHIIJKKKL"));
        }
    }
}
