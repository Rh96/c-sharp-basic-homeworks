using Csharp.Homework.Class06.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Homework.Class06.Services
{
    public class UserService
    {
        // Register
        public User Register(User user)
        {
            User newUser = CreateNewUser(user.FirstName, user.LastName, user.CardNumber, user.Pin, user.Balance);

            if (ValidationService.FindUniqueCardNumber(newUser.CardNumber, users))
            {
                Console.WriteLine("Card number already exists!");
            }
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = newUser;
            return newUser;
        }
        // Login
        public User Login(string cardNumber, string pin)
        {
            if (!ValidationService.CardNumberValidate(cardNumber))
            {
                Console.WriteLine("Enter valid card number!");
            }

            string[] cardNumParts = cardNumber.Split('-');
            string newCardNum = string.Empty;

            foreach (var item in cardNumParts)
            {
                newCardNum += item;
            }
            long cardNum = long.Parse(newCardNum);

            if (!ValidationService.PinValidation(pin))
            {
                Console.WriteLine("Enter valid pin!");
            }

            User user = FindUserByCardNumber(cardNum);
            if (user == null)
            {
                Console.WriteLine("User does not exists!");
            }
            return user;
        }
        // Create New User
        public User CreateNewUser(string fName, string lName, long cardNumber, string pin, double balance)
        {
            Console.WriteLine("Enter first name:");
            fName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            lName = Console.ReadLine();

            Console.WriteLine("Enter cardNumber:");
            string inputCardNum = Console.ReadLine();

            if (!ValidationService.CardNumberValidate(inputCardNum))
            {
                Console.WriteLine("Enter valid card number!");
            }

            string[] cardNumParts = inputCardNum.Split('-');
            string newCardNum = string.Empty;

            foreach (var item in cardNumParts)
            {
                newCardNum += item;
            }
            cardNumber = long.Parse(newCardNum);

            Console.WriteLine("Enter pin:");
            pin = Console.ReadLine();

            if (!ValidationService.PinValidation(pin))
            {
                Console.WriteLine("Enter valid pin number!");
            }

            Console.WriteLine("Enter balance: ");
            double.TryParse(Console.ReadLine(), out balance);

            return new User(fName, lName, cardNumber, pin, balance);
        }
        // Withdrawal cash
        public double WithdrawalCash(User user, double ammount)
        {
            if (ValidationService.WidthdrawalValidation(user, ammount))
            {
                user.Balance = user.Balance - ammount;
                foreach (var u in users)
                {
                    if (u.CardNumber == user.CardNumber)
                    {
                        u.Balance = user.Balance;
                    }
                }
            }
            else
            {
                Console.WriteLine("You can't withdraw money more than your balance!");
            }


            return user.Balance;
        }
        // Deposit cash
        public double DepositCash(User user, double ammount)
        {
            if (!ValidationService.DepositValidation(ammount))
            {
                Console.WriteLine("You can't deposit money with negative sum!");
            }
            else
            {
                user.Balance = user.Balance + ammount;
                foreach (var u in users)
                {
                    if (u.CardNumber == user.CardNumber)
                    {
                        u.Balance = user.Balance;
                    }
                }
            }

            return user.Balance;
        }
        // DATABASE
        public User[] GetAllUsers()
        {
            return users;
        }
        public User FindUserByCardNumber(long cardNumber)
        {
            User[] users = GetAllUsers();
            foreach (var user in users)
            {
                if (user.CardNumber == cardNumber)
                {
                    return user;
                }
            }
            return null;
        }
        static User[] users = new User[]
        {
            new User("Rade", "Hrgovikj", 2222333344445555, "4233", 1500),
            new User("Ivan", "Stojanov", 1111666699992222, "1234", 2500)
        };
    }
}
