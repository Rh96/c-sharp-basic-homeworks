using System;

namespace CSharp.Homework.Class04.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();

            Palindrome(word);

            Console.ReadLine();
        }

        public static void Palindrome(string input)
        {
            string result = string.Empty;
                        
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    result += input[i];
                }

                if (result == input)
                {
                    Console.WriteLine("Is palindrome");
                }
                else
                {
                    Console.WriteLine("Not palindrome");
                }
            
        }
    }
}
