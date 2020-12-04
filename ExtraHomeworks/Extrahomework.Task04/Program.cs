using System;

namespace Extrahomework.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            bool success = int.TryParse(Console.ReadLine(), out int n);
            int sumOfEven = 0;

            if (!success)
            {
                Console.WriteLine("Invalid Input");
            }

            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Adding numbers: " + i);
                    sumOfEven += i;
                }
            }
            Console.WriteLine("The sum of Even is: " + sumOfEven);
            

            Console.ReadLine();
        }
    }
}
