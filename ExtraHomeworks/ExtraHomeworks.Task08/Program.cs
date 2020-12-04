using System;

namespace ExtraHomeworks.Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two arrays:");
            int[] array1 = new int[4];
            int[] array2 = new int[4];
            bool flag = true;

            for (int i = 0; i < array1.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out array1[i])) 
                {
                    Console.WriteLine("Wrong Input");
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out array2[i]))
                {
                    Console.WriteLine("Wrong Input");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (array1[i] != array2[i]) 
                {
                    //Console.WriteLine(array1[i] + " not equal to " + array2[i]);
                    flag = false;
                }
                //else
                //{
                //    Console.WriteLine(array1[i] + " is equal to " + array2[i]);
                    
                //}
            }

            //foreach (int el in array1)
            //{
            //    Console.WriteLine(el);
            //}
            if (flag)
            {
                Console.WriteLine("Arrays are equal!");
            }
            else
            {
                Console.WriteLine("Arrays not equal!");
            }

            Console.ReadLine();
        }
    }
}
