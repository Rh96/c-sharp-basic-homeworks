using CSharp.Homework.Class08.LINQ.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Homework.Class08.LINQ.App.Database
{
    public class DatabaseRepository : Database
    {
        public void AddSongsToJerry()
        {
            var person = FansArray.Where(p => p.FirstName == "Jerry").FirstOrDefault();

            var songs = Songs.Where(s => s.Title.StartsWith('B')).ToList();

            songs.ForEach(s => person.FavoriteSongs.Add(s));

            person.GetFavSongs();
        }

        public void AddSongsToMaria()
        {
            var person = FansArray.Where(p => p.FirstName == "Maria").FirstOrDefault();

            var songs = Songs.Where(s => s.Length > 360).ToList();

            songs.ForEach(s => person.FavoriteSongs.Add(s));

            person.GetFavSongs();
        }

        public void AddSongsToJane()
        {
            var person = FansArray.Where(p => p.FirstName == "Jane").FirstOrDefault();

            var songs = Songs.Where(s => s.Genre == Genre.Rock).ToList();

            songs.ForEach(s => person.FavoriteSongs.Add(s));

            person.GetFavSongs();
        }

        public void AddSongsToStefan()
        {
            var person = FansArray.Where(p => p.FirstName == "Stefan").FirstOrDefault();

            var songs = Songs.Where(s => s.Length < 180 && s.Genre == Genre.Hip_Hop).ToList();

            songs.ForEach(s => person.FavoriteSongs.Add(s));

            person.GetFavSongs();
        }

        public void GetAllPersonSongs()
        {
            var personsWithMoreThan4Songs = FansArray.Where(p => p.FavoriteSongs.Count >= 4).ToList();

            foreach (var person in personsWithMoreThan4Songs)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
