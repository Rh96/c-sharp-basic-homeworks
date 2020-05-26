using System;

namespace CSharp.Homework.Class04.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");
            string wordSearch = Console.ReadLine();

            NumberOfDigits(wordSearch);
            Vowels(wordSearch);

            Console.ReadLine();
        }

        public static void NumberOfDigits(string wordSearch)
        {
            int numberOfDigits = 0;

            for (int i = 0; i < wordSearch.Length; i++)
            {
                numberOfDigits += wordSearch[i].ToString().Length;
            }

            Console.WriteLine("The ammount of digits is: " + numberOfDigits);
        }

        public static void Vowels(string wordSearch)
        {
            int totalVowels = 0;

            for (int i = 0; i < wordSearch.Length; i++)
            {
                if (wordSearch.Contains("a") || wordSearch.Contains("e") || wordSearch.Contains("i") || wordSearch.Contains("o") || wordSearch.Contains("u"))
                {
                    totalVowels += wordSearch[i].ToString().Length;
                }
            }

            Console.WriteLine("The string contains: " + totalVowels + " vowels");
        }
    }
}
