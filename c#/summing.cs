using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1; 

            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string number = Console.ReadLine(); 

                if (number == "")
                {
                    break; 
                }
                sum += Convert.ToInt32(number);
                i += 1;
                Console.WriteLine(sum);
            }
        }
    }
}
