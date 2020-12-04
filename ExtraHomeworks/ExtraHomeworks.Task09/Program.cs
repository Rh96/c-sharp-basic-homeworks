using System;

namespace ExtraHomeworks.Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1
            //int inputNumber = 13;
            //int sum = 0;

            //int result = inputNumber;

            //while (inputNumber != 0)
            //{
            //    int res = inputNumber % 10;
            //    sum += res;
            //    inputNumber /= 10;
            //}
            //if (result % sum == 0)
            //{
            //    Console.WriteLine("Is Divisible!");
            //}
            //else
            //{
            //    Console.WriteLine("Is not Divisible!");
            //}
            #endregion


            for (int i = 1; i < 1000; i++)
            {
                int sum = 0;
                int temp = i;

                while (temp != 0)
                {
                    int res = temp % 10;
                    sum += res;
                    temp /= 10;
                }
                if(i % sum == 0)
                {
                    Console.WriteLine(i + " Is divisible");
                }
                else
                {
                    Console.WriteLine(i + " Is not divisible!");
                }
            }

            Console.ReadLine();
        }
    }
}
