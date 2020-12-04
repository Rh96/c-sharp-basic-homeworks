using System;

namespace Extrahomewrok.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number:");
            int inputNumber;
            bool success = int.TryParse(Console.ReadLine(), out inputNumber);
            int result = 1;

            if (!success)
            {
                Console.WriteLine("Invalid Input!");
            }

            while (inputNumber>0)
            {
                result *= inputNumber % 10;
                inputNumber /= 10;
            }
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
