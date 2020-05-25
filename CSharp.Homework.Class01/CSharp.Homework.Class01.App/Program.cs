using System;
using System.Threading;

namespace CSharp.Homework.Class01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic light...\n");

            Thread.Sleep(3000);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red light - STOP!\n");

            Thread.Sleep(3000);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow light - PREPARE!\n");

            Thread.Sleep(3000);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green light - GO!");

            Console.ReadLine();
        }
    }
}
