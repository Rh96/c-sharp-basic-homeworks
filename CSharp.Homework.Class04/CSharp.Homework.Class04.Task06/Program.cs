using System;

namespace CSharp.Homework.Class04.Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter pattern: ");
            string pattern = Console.ReadLine();

            SubstringAppearance(word, pattern);

            Console.ReadLine();
        }

        public static void SubstringAppearance(string word, string pattern)
        {
            int count = 0;
            int i = 0;
            while((i = word.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }

            Console.WriteLine("The number of substring occurences in that string are: " +
                count);
        }
    }
}
