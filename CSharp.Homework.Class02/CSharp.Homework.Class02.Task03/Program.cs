using System;

namespace CSharp.Homework.Class02.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Enter the second number: ");
            bool isParsed2 = int.TryParse(Console.ReadLine(), out int secondNumber);


            Console.WriteLine("After swapping:");
            int temp = 0;
            temp = firstNumber; // 5
            firstNumber = secondNumber; // 8
            secondNumber = temp; // 5
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);


            Console.ReadLine();
        }
    }
}
