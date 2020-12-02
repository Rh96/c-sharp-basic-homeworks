using System;

namespace CSharp.Homework.Class04.Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine(Substring(num));

            Console.ReadLine();
        }

        static string Substring(int num)
        {
            string word = "Hello from SEDC Codecademy v7.0";
            string newWord = string.Empty;

            if (num < 1 || num > word.Length)
            {
                Console.WriteLine("Can't enter an integer larger than the length of the string!");
            }

            else
            {
                newWord = word.Substring(0, num);
            }

            return string.Format("{0}\nLength: {1}", newWord, newWord.Length);
        }
    }
}
