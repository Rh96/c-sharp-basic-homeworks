using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Homework.Class06.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        public string Pin { get; set; }
        public double Balance { get; set; }

        public User(string firstName, string lastName, long cardNumber, string pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
    }
}
