using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class09.Helpers
{
    public class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome user!");
            Console.WriteLine("What cinema would you like to choose?\n1. Kino Milenium\n2. Cineplex");
        }

        public void CinemaMainMenu(string cinemaName)
        {
            Console.WriteLine($"Welcome to {cinemaName}");
            Console.WriteLine("1. See all movies\n2. Specific genre");
        }

        public void GenreMenu()
        {
            Console.WriteLine("Choose genre:\n1. Action\n2. Comedy\n3. Drama\n4. Horror\n5. SciFi");
        }
    }
}
