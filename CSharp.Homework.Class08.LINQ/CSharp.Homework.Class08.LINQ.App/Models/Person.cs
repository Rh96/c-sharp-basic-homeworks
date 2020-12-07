using CSharp.Homework.Class08.LINQ.App.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class08.LINQ.App.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string fName, string lName, int age, Genre favoriteSongType)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            FavoriteMusicType = favoriteSongType;
            FavoriteSongs = new List<Song>();
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music!");
            }
            else
            {
                Console.WriteLine("Person favorite songs:");
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}
