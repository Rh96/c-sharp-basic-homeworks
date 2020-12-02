using System;

namespace CSharp.Homework.Class03.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { };
            string[] studentsG2 = new string[] { };

            int count = 0;
            int i = 0;

            Console.WriteLine("Enter student name for G1:");
            while (count < 5)
            {
                string studentG1 = Console.ReadLine();

                Array.Resize(ref studentsG1, studentsG1.Length + 1);
                studentsG1[studentsG1.Length - 1] = studentG1;

                count++;
            }

            Console.WriteLine("Enter student name for G2:");
            while (i < 5)
            {
                string studentG2 = Console.ReadLine();

                Array.Resize(ref studentsG2, studentsG2.Length + 1);
                studentsG2[studentsG2.Length - 1] = studentG2;

                i++;
            }

            Console.WriteLine("Enter student group: there are 1 and 2");
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The students from G1 are:");
                    foreach (string student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                case 2:
                    Console.WriteLine("The students from G2 are:");
                    foreach (string student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input or out of range!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
