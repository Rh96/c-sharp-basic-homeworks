using System;

namespace ExtraHomeworks.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                int.TryParse(Console.ReadLine(), out n);
                if (n <= 5)
                {
                    Console.WriteLine("invalid input");
                }
            }
            while (n <= 5);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is divided by 2");
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " is divided by 3");
                }
            }

            Console.ReadLine();
        }
    }
}
