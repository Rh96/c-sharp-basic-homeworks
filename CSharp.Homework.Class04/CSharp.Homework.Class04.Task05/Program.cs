using System;

namespace CSharp.Homework.Class04.Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            bool isParsed = char.TryParse(Console.ReadLine(), out char ch);

            IsAlphabet(ch);

            Console.ReadLine();
        }

        public static void IsAlphabet(char ch)
        {
            if(ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("Is alphabet");

                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("The character is Upper");
                }
                if (Char.IsLower(ch))
                {
                    Console.WriteLine("The character is Lower");
                }

            }
            else
            {
                Console.WriteLine("Is not alphabet");
            }
        }
    }
}
