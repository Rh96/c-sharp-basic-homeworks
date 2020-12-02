using System;

namespace CSharp.Homework.Class04.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();

            CaseInsensitive(word);
            Console.ReadLine();
        }

        static void CaseInsensitive(string word)
        {
            string newWord = string.Empty;

            foreach (char c in word)
            {
                if (Char.IsUpper(c))
                {
                    newWord += Char.ToLower(c).ToString();
                }
                else
                {
                    newWord += Char.ToUpper(c).ToString();
                }
            }

            Console.WriteLine(newWord);
        }
    }
}
