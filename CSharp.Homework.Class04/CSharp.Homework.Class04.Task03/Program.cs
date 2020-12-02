using System;

namespace CSharp.Homework.Class04.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();

            Console.WriteLine("Number of vowels: " + Vowels(word));
            NumberOfDigits(Vowels(word));

            Console.ReadLine();
        }
        static void NumberOfDigits(int num)
        {
            int totalNumbers = 0;
            while (num != 0)
            {
                totalNumbers++;
                num /= 10;
            }
            Console.WriteLine("Total numbers calculated: {0}", totalNumbers);
        }

        static int Vowels(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
