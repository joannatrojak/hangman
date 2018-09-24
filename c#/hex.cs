using System;
using System.Collections.Generic;

namespace ConsoleApp27
{
    class Program
    {
        static string hexadecimal(double number)
        {
            Dictionary<string, string> hexaNumbers = new Dictionary<string, string>
            {
                {"0", "0"}, {"1", "1"}, {"2", "2" }, {"3", "3"}, {"4", "4"}, {"5", "5"}, {"6", "6"},
                {"7", "7" }, {"8", "8"}, {"9", "9"}, {"10", "A"}, {"11", "B"}, {"12", "C"}, {"13", "D"},
                {"14", "E" }, {"15", "F"}
            };
            List<int> convertedNumber = new List<int>();
            List<string> result = new List<string>();
            int i = 1; 

            if (hexaNumbers.ContainsKey(Convert.ToString(number)))
            {
                return hexaNumbers[Convert.ToString(number)];
            }
            else
            {
                while (number > 0)
                {
                    int remainder = Convert.ToInt32(number % 16);
                    number = Math.Floor(number / 16);
                    i += 1;
                    convertedNumber.Add(remainder); 
                }
                convertedNumber.Reverse();
                foreach (int value in convertedNumber)
                {
                    result.Add(hexaNumbers[Convert.ToString(value)]);
                }
                return String.Join("", result.ToArray());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(hexadecimal(1263));
        }
    }
}
