using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class05.Task01.Classes
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine("The dog is now eating.");
        }

        public void Play()
        {
            Console.WriteLine("The dog is now playing.");
        }

        public void ChaseTail()
        {
            Console.WriteLine("Dog is now chasing its tail.");
        }

        public void DogInfo()
        {
            Console.WriteLine($"Dog info: Name: {Name}, Race: {Race}, Color: {Color}");
        }
    }
}
