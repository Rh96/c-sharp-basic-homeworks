using System;

namespace ExtraHomework.Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfChars = new string[] {"a", "b", "c", "d"};


            Console.WriteLine("Array before reversing it:");
            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                Console.WriteLine(arrayOfChars[i]);
            }
            
            Array.Reverse(arrayOfChars);

            Console.WriteLine("Array after reversing it:");

            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                Console.WriteLine(arrayOfChars[i]);
            }

            Console.ReadLine();
        }
    }
}
