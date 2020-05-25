using System;

namespace CSharp.Homework.Class02.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Enter the second number: ");
            bool isParsed2 = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.Write("Enter the third number: ");
            bool isParsed3 = int.TryParse(Console.ReadLine(), out int thirdNumber);
            Console.Write("Enter the fourth number: ");
            bool isParsed4 = int.TryParse(Console.ReadLine(), out int fourthNumber);

            int average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine("The average of " + 
                firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourthNumber + " is: " + average);

            Console.ReadLine();
        }
    }
}
