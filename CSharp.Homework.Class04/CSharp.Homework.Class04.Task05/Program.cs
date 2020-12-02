using System;

namespace CSharp.Homework.Class04.Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character:");
            char.TryParse(Console.ReadLine(), out char ch);

            CheckAlphabet(ch);

            Console.ReadLine();
        }

        static void CheckAlphabet(char ch)
        {
            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine($"The entered character {ch} is an Alphabet!");

                if (Char.IsUpper(ch))
                {
                    Console.WriteLine($"The entered character {ch} is UpperCase!");
                }
                else
                {
                    Console.WriteLine($"The entered character {ch} is LowerCase!");
                }
            }
            else
            {
                Console.WriteLine($"The entered character {ch} is not Alphabet!");
            }
        }
    }
}
