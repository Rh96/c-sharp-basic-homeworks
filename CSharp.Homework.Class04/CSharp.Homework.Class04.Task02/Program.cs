using System;

namespace CSharp.Homework.Class04.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfNumbers = new double[] { };

            int counter = 0;

            Console.WriteLine("Enter 5 numbers:");
            while (counter < 5)
            {
                double.TryParse(Console.ReadLine(), out double num);

                Array.Resize(ref arrayOfNumbers, arrayOfNumbers.Length + 1);
                arrayOfNumbers[arrayOfNumbers.Length - 1] = num;

                counter++;
            }

            Console.WriteLine("The gratest value is: " + GreatestValue(arrayOfNumbers));

            Console.ReadLine();
        }

        static double GreatestValue(double[] array)
        {
            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
