using CSharp.Homework.Class09.Database;
using CSharp.Homework.Class09.Enums;
using CSharp.Homework.Class09.Helpers;
using CSharp.Homework.Class09.Models;
using CSharp.Homework.Class09.Services;
using System;

namespace CSharp.Homework.Class09
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieService movieService = new MovieService();
            Menu menu = new Menu();

            menu.MainMenu();
            int.TryParse(Console.ReadLine(), out int userChoice);

            switch (userChoice)
            {
                case 1:
                    #region Kino Milenium
                    string firstCinema = movieService.GetCinema("Kino Milenium");
                    var movies = movieService.GetAllMovies(firstCinema);

                    Console.Clear();
                    menu.CinemaMainMenu(firstCinema);
                    int.TryParse(Console.ReadLine(), out int userChoice2);

                    if (userChoice2 == 1)
                    {
                        Console.Clear();
                        movieService.PrintInfo(movies);

                        Console.WriteLine("Choose movie to watch?");
                        int.TryParse(Console.ReadLine(), out int movieToWatch);

                        Console.Clear();
                        var movie = movieService.GetMovie(movies, movieToWatch);
                        movieService.PlayMovie(firstCinema, movie);
                    }

                    else if (userChoice2 == 2)
                    {
                        Console.Clear();
                        menu.GenreMenu();
                        int.TryParse(Console.ReadLine(), out int genreChoice);

                        int genre = movieService.ConvertGenre(genreChoice);
                        var moviesByGenre = movieService.GetMoviesByGenre(movies, genre);

                        Console.Clear();
                        movieService.PrintInfo(moviesByGenre);

                        Console.WriteLine("Choose movie to watch?");
                        int.TryParse(Console.ReadLine(), out int movieToWatch);

                        Console.Clear();
                        var movie = movieService.GetMovie(moviesByGenre, movieToWatch);
                        movieService.PlayMovie(firstCinema, movie);
                    }
                    #endregion
                    break;
                case 2:
                    #region Cineplex
                    string secondCinema = movieService.GetCinema("Cineplex");
                    movies = movieService.GetAllMovies(secondCinema);

                    Console.Clear();
                    menu.CinemaMainMenu(secondCinema);
                    int.TryParse(Console.ReadLine(), out int userChoice3);

                    if (userChoice3 == 1)
                    {
                        Console.Clear();
                        movieService.PrintInfo(movies);

                        Console.WriteLine("Choose movie to watch?");
                        int.TryParse(Console.ReadLine(), out int movieToWatch);

                        Console.Clear();
                        var movie = movieService.GetMovie(movies, movieToWatch);
                        movieService.PlayMovie(secondCinema, movie);
                    }
                    else if (userChoice3 == 2)
                    {
                        Console.Clear();
                        menu.GenreMenu();
                        int.TryParse(Console.ReadLine(), out int genreChoice);

                        int genre = movieService.ConvertGenre(genreChoice);
                        var moviesByGenre = movieService.GetMoviesByGenre(movies, genre);

                        Console.Clear();
                        movieService.PrintInfo(moviesByGenre);

                        Console.WriteLine("Choose movie to watch?");
                        int.TryParse(Console.ReadLine(), out int movieToWatch);

                        Console.Clear();
                        var movie = movieService.GetMovie(moviesByGenre, movieToWatch);
                        movieService.PlayMovie(secondCinema, movie);
                    }
                    #endregion
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
