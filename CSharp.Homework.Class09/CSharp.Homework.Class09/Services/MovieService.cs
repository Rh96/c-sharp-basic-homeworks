using CSharp.Homework.Class09.Database;
using CSharp.Homework.Class09.Enums;
using CSharp.Homework.Class09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Homework.Class09.Services
{
    public class MovieService : MemoryRepository
    {
        public string GetCinema(string userCinema)
        {
            return Cinemas.FirstOrDefault(c => c.Name == userCinema).Name;
        }
        public List<Movie> GetAllMovies(string userChoice)
        {
            List<Movie> movies = Cinemas
                                .Where(c => c.Name == userChoice)
                                .SelectMany(m => m.Movies)
                                .ToList();
            return movies;
        }
        public void PrintInfo(List<Movie> movies)
        {
            int cnt = 1;
            foreach (var movie in movies)
            {
                Console.WriteLine($"{cnt}. Id:{movie.Id}, Name: {movie.Title}, Rating: {movie.Rating}, Price: {movie.TicketPrice}$");
                cnt++;
            }
        }
        public int ConvertGenre(int genreChoice)
        {
            int getValue = 0;
            foreach (var item in (Genre[]) Enum.GetValues(typeof(Genre)))
            {
                if (genreChoice == (int)item)
                {
                    getValue = (int)item;
                }
            }
            return getValue;
        }
        public List<Movie> GetMoviesByGenre(List<Movie> movies, int genre)
        {
            List<Movie> newGenreMovies = new List<Movie>();
            try
            {
                if(genre == 0)
                {
                    throw new Exception("Invalid input!");
                }
                else
                {
                    newGenreMovies = movies.Where(c => c.Genre == (Genre)genre).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return newGenreMovies;
        }
        public Movie GetMovie(List<Movie> movies, int movieId)
        {
            return movies.FirstOrDefault(m => m.Id == movieId);
        }
        public void PlayMovie(string cinema, Movie movie)
        {
            var playCinema = Cinemas.FirstOrDefault(c => c.Name == cinema);
            playCinema.MoviePlaying(movie);
        }
    }
}
