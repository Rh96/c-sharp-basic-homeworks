using System;

namespace CSharp.Homework.Class04.Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int number);

            Substrings(number);

            Console.ReadLine();
        }

        public static void Substrings(int number)
        {
            string word = "Hello from SEDC CodeAcademy v7.0";
            string newWordLength = string.Empty;
            string errorMessage = "can't enter an integer larger than the length of the string";


            if (number <= word.Length)
            {
                newWordLength = word.Substring(0, number);
                Console.WriteLine("New word: " + newWordLength);
                Console.WriteLine("The length of the word is: " + newWordLength.Length);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
