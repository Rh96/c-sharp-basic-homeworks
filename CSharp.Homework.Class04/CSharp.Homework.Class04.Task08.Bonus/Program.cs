using System;

namespace CSharp.Homework.Class04.Task08.Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth: (1996/11/28)");
            Console.WriteLine("Enter year: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int year);
            Console.WriteLine("Enter month: ");
            bool isParsed2 = int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Enter day: ");
            bool isParsed3 = int.TryParse(Console.ReadLine(), out int day);

            DateTime dob = new DateTime(year, month, day);

            AgeCalculator(dob);

            Console.ReadLine();
        }

        public static void AgeCalculator(DateTime dob)
        {
            int userDob = DateTime.Now.Year - dob.Year;

            Console.WriteLine("Your age is: " + userDob);
        }
    }
}
