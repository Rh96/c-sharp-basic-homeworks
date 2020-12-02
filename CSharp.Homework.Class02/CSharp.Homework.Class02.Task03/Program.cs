using System;

namespace CSharp.Homework.Class02.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Enter second number:");
            int.TryParse(Console.ReadLine(), out int num2);

            int temp;
            temp = num1; // temp = 5
            num1 = num2; // num1 = 8
            num2 = temp; // num2 = 5

            Console.WriteLine("After swapping:\nFirst number: {0}\nSecond number: {1}", num1, num2);


            Console.ReadLine();
        }
    }
}
