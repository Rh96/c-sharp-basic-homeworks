using System;

namespace ExtraHomeworks.Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            bool success = int.TryParse(Console.ReadLine(), out int n);
            int sumOfOdd = 0;

            if (!success)
            {
                Console.WriteLine("Invalid Input");
            }

            int i = 1;
            while (i<=n)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Adding numbers: " + i);
                    sumOfOdd += i;
                }
                i++;
            }
            Console.WriteLine("The sum of odd numbers is: " + sumOfOdd);

            Console.ReadLine();
        }
    }
}
