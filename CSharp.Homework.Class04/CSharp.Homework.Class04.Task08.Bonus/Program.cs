using System;

namespace CSharp.Homework.Class04.Task08.Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date of birth: MM/dd/yyyy");
            string userInput = Console.ReadLine();

            Console.WriteLine("You are {0} years old", AgeCalculator(userInput));

            Console.ReadLine();
        }

        static int AgeCalculator(string input)
        {
            DateTime dob = DateTime.Parse(input);
            return DateTime.Now.Year - dob.Year;
        }
    }
}
