using System;

namespace CSharp.Homework.Class04.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            IsPalindrome(word);

            Console.ReadLine();
        }

        static bool IsPalindrome(string word)
        {
            string newWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                newWord += word[i];
            }

            if (newWord == word)
            {
                Console.WriteLine("The word is palindrome: {0} == {1}", newWord, word);
                return true;
            }
            else
            {
                Console.WriteLine("The word is not palindrome: {0} != {1}", newWord, word);
                return false;
            }
        }
    }
}
