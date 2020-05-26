using System;

namespace CSharp.Homework.Class04.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentece: ");
            string word = Console.ReadLine();

            CaseInsensitive(word);

            Console.ReadLine();
        }

        public static void CaseInsensitive(string word)
        {
            string newWord = string.Empty;

            foreach (char ch in word)
            {
                if (Char.IsUpper(ch))
                {
                    newWord += Char.ToLower(ch).ToString();
                }
                if (Char.IsLower(ch))
                {
                    newWord += Char.ToUpper(ch).ToString();
                }
            }

            Console.WriteLine(newWord);
        }
    }
}
