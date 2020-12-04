using System;

namespace ExtraHomework.Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            bool success = int.TryParse(Console.ReadLine(), out int n);
            int sumNumbers = 0;

            if (!success)
            {
                Console.WriteLine("Invalid Input");
            }

            for (int i = 1; i <= n; i++)
            {
                if(i % 5 == 0)
                {
                    Console.WriteLine("Adding numbers: " + i);
                    sumNumbers += i;
                }
            }
            Console.WriteLine("The sum of numbers divided by 5 is: " + sumNumbers);

            Console.ReadLine();
        }
    }
}
