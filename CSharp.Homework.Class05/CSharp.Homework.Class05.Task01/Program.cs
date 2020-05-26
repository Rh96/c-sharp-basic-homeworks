using CSharp.Homework.Class05.Task01.Classes;
using System;

namespace CSharp.Homework.Class05.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter dog race: ");
            string race = Console.ReadLine();
            Console.WriteLine("Enter dog color: ");
            string color = Console.ReadLine();

            var dog = new Dog();
            dog.Name = name;
            dog.Race = race;
            dog.Color = color;

            dog.DogInfo();

            Console.WriteLine("What action do you prefer your dog to do?\n(1: Eat, 2: Play, 3: Chase Tail)");
            bool isParsed = int.TryParse(Console.ReadLine(), out int userChoice);

            switch (userChoice)
            {
                case 1:
                    dog.Eat();
                    break;
                case 2:
                    dog.Play();
                    break;
                case 3:
                    dog.ChaseTail();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
