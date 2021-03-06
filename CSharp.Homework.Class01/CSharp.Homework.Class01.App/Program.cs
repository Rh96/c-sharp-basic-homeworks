﻿using System;
using System.Threading;

namespace CSharp.Homework.Class01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic light...\n");

            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Red light - STOP!\n");

            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow light - PREPARE!\n");

            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green light - GO!");

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
