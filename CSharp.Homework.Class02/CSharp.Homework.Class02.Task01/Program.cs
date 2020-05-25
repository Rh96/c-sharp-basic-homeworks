using System;

namespace CSharp.Homework.Class02.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // input two variables and one operator
            Console.Write("Enter your first number: ");
            bool isParsed = double.TryParse(Console.ReadLine(), out double firstNumber);
            Console.Write("Enter your second number: ");
            bool isParsed2 = double.TryParse(Console.ReadLine(), out double secondNumber);
            Console.Write("Enter operator: (+, -, *, /)");
            bool isParsed3 = char.TryParse(Console.ReadLine(), out char operation);

            double result = 0;

            if (operation == '+')
            {
                result = firstNumber + secondNumber;
                Console.WriteLine("The result is: " + result);
            }
            if (operation == '-')
            {
                result = firstNumber - secondNumber;
                Console.WriteLine("The result is: " + result);
            }
            if (operation == '*')
            {
                result = firstNumber * secondNumber;
                Console.WriteLine("The result is: " + result);
            }
            if (operation == '/')
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine("The result is: " + result);
                }
            }

            Console.ReadLine();
        }
    }
}
