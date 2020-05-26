using System;

namespace CSharp.Homework.Class04.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] realNumbers = new float[]
            {
                1.2f,1.8f,1.6f,1.4f,1.5f,1.9f,
            };

            GreatesNumberOfRealNumbers(realNumbers);

            Console.ReadLine();
        }

        public static void GreatesNumberOfRealNumbers(float[] arrayOfRealNumbers)
        {
            float temp = 0;
            for (int i = 0; i < arrayOfRealNumbers.Length; i++)
            {
                if (arrayOfRealNumbers[i] >= temp)
                {
                    temp = arrayOfRealNumbers[i];
                }
            }

            Console.WriteLine("The greatest value stored in array of real numbers is: " + temp);
        }
    }
}
