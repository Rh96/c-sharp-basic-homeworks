using CSharp.Homework.Class09.Enums;
using CSharp.Homework.Class09.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class09.Database
{
    public class MemoryRepository
    {
        public List<Cinema> Cinemas;

        public MemoryRepository()
        {
            Cinemas = new List<Cinema>()
            {
                new Cinema
                {
                    Name = "Kino Milenium",
                    Halls = 4,
                    Movies = new List<Movie>()
                    {
                        new Movie(1, "John Wick", Genre.Action, 4),
                        new Movie(2, "The Hangover", Genre.Comedy, 5),
                        new Movie(3, "The Social Network", Genre.Drama, 5),
                        new Movie(4, "Halloween", Genre.Horror, 3),
                        new Movie(5, "Arrival", Genre.SciFi, 4)
                    }
                },
                new Cinema
                {
                    Name = "Cineplex",
                    Halls = 6,
                    Movies = new List<Movie>()
                    {
                        new Movie(1, "Taken", Genre.Action, 5),
                        new Movie(2, "The 40-Year-Old Virgin", Genre.Comedy, 3),
                        new Movie(3, "Gladiator", Genre.Drama, 5),
                        new Movie(4, "IT", Genre.Horror, 4),
                        new Movie(5, "Annihilation", Genre.SciFi, 2)
                    }
                }
            };
        }
    }
}
