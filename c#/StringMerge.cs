using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static string stringMerge(string a, string b)
        {
            List<char> merged = new List<char>();
            int lengthA = a.Length;
            int lengthB = b.Length;
            int i = 0;
            while (lengthA > 0 || lengthB > 0)
            {
                merged.Add(a[i]);
                lengthA--;
                merged.Add(b[i]);
                lengthB--;
                i++;
            }
            return string.Join("", merged.ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine(stringMerge("abs","sfd"));
        }
    }
}
