using System;
using System.Threading;

namespace ExtraHomeWorks.Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to guess the number game!");
            Thread.Sleep(1500);
            Console.WriteLine("Choose difficulty:\nEasy, Medium, Hard");
            string userInput = Console.ReadLine().ToLower();


            // Choosing difficulty

            // Easy Mode
            if (userInput == "Easy".ToLower())
            {
                Console.WriteLine("Easy mode\n You have 9 tries to guess the number between 0-100");

                while (1 < 9)
                {
                    Console.WriteLine("Enter number:");
                    if (!int.TryParse(Console.ReadLine(), out int number));
                    {
                        Console.WriteLine("Wrong input!");
                        break;
                    }
                }
            }

            // Medium Mode
            else if (userInput == "Medium".ToLower())
            {
                Console.WriteLine("Medium mode\n You have 7 tries to guess the number between 0-500");
            }

            // Hard Mode
            else if (userInput == "Hard".ToLower())
            {
                Console.WriteLine("Hard mode\n You have 5 tries to guess the number between 0-1000");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            Console.ReadLine();
        }
    }
}
