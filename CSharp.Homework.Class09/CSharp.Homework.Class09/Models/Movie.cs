using CSharp.Homework.Class09.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Homework.Class09.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; } = 5;

        public Movie(int id, string title, Genre genre, int rating)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = GetTicketPrice();
        }

        public int GetTicketPrice()
        {
            int result = 0;
            try
            {
                if (Rating < 1 || Rating > 5)
                {
                    throw new Exception("The rating is out of range or invalid input!");
                }
                result = TicketPrice * Rating;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
