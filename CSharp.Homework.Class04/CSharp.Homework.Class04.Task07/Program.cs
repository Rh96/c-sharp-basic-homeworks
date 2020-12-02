using System;

namespace CSharp.Homework.Class04.Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter exponent:");
            int.TryParse(Console.ReadLine(), out int exponent);

            Console.WriteLine("Enter power number:");
            int.TryParse(Console.ReadLine(), out int pow);

            Pow(exponent, pow);

            Console.ReadLine();
        }

        static void Pow(int x, int y)
        {
            int result = 1;
            int count = 0;

            while (count < y)
            {
                result *= x;
                count++;
            }
            Console.WriteLine("The result is: " + result);
        }
    }
}
