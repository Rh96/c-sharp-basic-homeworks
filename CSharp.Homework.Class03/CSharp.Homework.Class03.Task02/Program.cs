using System;

namespace CSharp.Homework.Class03.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] group1 = new string[]
            {
                "Rade","Mare","Trale","Stojancho","Ivko",
            };

            string[] group2 = new string[]
            {
                "Zdravko","Petko","Stanko","Branko","Trajko",
            };

            Console.WriteLine("Enter student group: (there are 1 and 2)");
            bool isParsed = int.TryParse(Console.ReadLine(), out int userChoice);

            if (userChoice == 1)
            {
                Console.WriteLine("Students from group 1:");
                foreach (var item in group1)
                {
                    Console.WriteLine(item);
                }
            }
            if (userChoice == 2)
            {
                Console.WriteLine("Students from group 2:\n");
                foreach (var item in group2)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
