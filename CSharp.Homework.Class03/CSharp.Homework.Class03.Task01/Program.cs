using System;

namespace CSharp.Homework.Class03.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[] { };

            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter 6 numbers:");

            while (count < 6)
            {
                int.TryParse(Console.ReadLine(), out int num);

                Array.Resize(ref arrayOfNumbers, arrayOfNumbers.Length + 1);
                arrayOfNumbers[arrayOfNumbers.Length - 1] = num;

                count++;
            }

            foreach (int n in arrayOfNumbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }

            Console.WriteLine("The sum of even numbers in array is: " + sum);

            Console.ReadLine();
        }
    }
}
