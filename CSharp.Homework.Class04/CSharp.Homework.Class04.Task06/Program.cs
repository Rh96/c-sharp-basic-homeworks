using System;

namespace CSharp.Homework.Class04.Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();

            Console.WriteLine("Word you would like to search:");
            string wordSearch = Console.ReadLine();

            CountOccurences(word, wordSearch);

            Console.ReadLine();
        }

        static void CountOccurences(string word, string wordSearch)
        {
            int occurences = word.Split(wordSearch).Length - 1;

            Console.WriteLine("Occurences: " + occurences);
        }
    }
}
