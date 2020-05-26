using System;

namespace CSharp.Homework.Class04.Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine("Enter number you want to raise: ");
            bool isParsed2 = int.TryParse(Console.ReadLine(), out int exponent);

            RaisingInteger(number, exponent);

            Console.ReadLine();
        }

        public static void RaisingInteger(int number, int exponent)
        {
            // 5^3 = 5 * 5 * 5
            int result = 1;
            for (int i = 1; i <= exponent ; i++)
            {
                result *= number;
                Console.WriteLine($"{number}");
            }

            Console.WriteLine("The result is: " + result);
        }
    }
}
