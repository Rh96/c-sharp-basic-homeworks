using System;

namespace CSharp.Homework.Class02.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine("Enter third number:");
            int.TryParse(Console.ReadLine(), out int num3);

            Console.WriteLine("Enter fourth number:");
            int.TryParse(Console.ReadLine(), out int num4);

            int average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of {0}, {1}, {2} and {3} is: {4}", num1, num2, num3, num4, average);

            Console.ReadLine();
        }
    }
}
