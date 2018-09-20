using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            int steps = 1;

            Console.Write("Enter a number greater than 1: ");
            string number = Console.ReadLine();

            try
            {
                n = Int32.Parse(number);
            }
            catch
            {
                Console.WriteLine("Invalid input. Try again!");
                Main();
            }

            while (n != 1)
            {
                if (n%2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                steps++;
                Console.WriteLine(n);
            }
            Console.WriteLine("It took {steps} to reach {n} from {number}");
        }
    }
}
