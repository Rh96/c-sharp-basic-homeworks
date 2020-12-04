using System;

namespace ExtraHomework.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                int product = 1;
                int temp = i;

                while (temp != 0)
                {
                    int res = temp % 10;
                    product *= res;
                    temp /= 10;
                }

                if (product == 0)
                {
                    Console.WriteLine(i + " Cannot divide by zero!");
                    continue;
                }

                if (i % product == 0)
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
