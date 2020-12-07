using CSharp.Homework.Class08.LINQ.App.Database;
using System;

namespace CSharp.Homework.Class08.LINQ.App
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseRepository dabaseRepository = new DatabaseRepository();

            // Task 01
            dabaseRepository.AddSongsToJerry();

            // Task 02
            dabaseRepository.AddSongsToMaria();

            // Task 03
            dabaseRepository.AddSongsToJane();

            // Task 04
            dabaseRepository.AddSongsToStefan();

            // Task 05
            dabaseRepository.GetAllPersonSongs();
            Console.ReadLine();
        }
    }
}
