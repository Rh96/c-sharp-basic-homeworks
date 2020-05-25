using System;

namespace CSharp.Homework.Class03.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = new int[6];
            int sumOfEven = 0;

            Console.WriteLine("Enter 6 numbers: ");

            int i = 0;
            while(i < arrayOfIntegers.Length)
            {
                bool isParsed = int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]);
                i++;
            }

            i = 0;
            while(i < 6)
            {
                if(arrayOfIntegers[i] % 2 == 0)
                {
                    sumOfEven += arrayOfIntegers[i];
                }
                i++;
            }
            Console.WriteLine("The sum of even numbers in array is: " + sumOfEven);

            Console.ReadLine();
        }
    }
}
