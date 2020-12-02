using System;

namespace CSharp.Homework.Class02.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double.TryParse(Console.ReadLine(), out double num1);

            Console.WriteLine("Enter second number:");
            double.TryParse(Console.ReadLine(), out double num2);

            Console.WriteLine("Enter operation:");
            char.TryParse(Console.ReadLine(), out char operation);

            switch (operation)
            {
                case '+':
                    Console.WriteLine("The result is: {0}", num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("The result is: {0}", num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("The result is: {0}", num1 * num2);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        Console.WriteLine("The result is: {0}", num1 / num2);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
