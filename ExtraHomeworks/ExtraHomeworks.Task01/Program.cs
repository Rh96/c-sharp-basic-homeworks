using System;

namespace ExtraHomeworks.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                int.TryParse(Console.ReadLine(), out n);
                if (n <= 2)
                {
                    Console.WriteLine("invalid input");
                }
            }
            while (n <= 2);

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {                  
                    Console.WriteLine(i + " is divided by 3");
                }
            }

            Console.ReadLine();
        }
    }
}
