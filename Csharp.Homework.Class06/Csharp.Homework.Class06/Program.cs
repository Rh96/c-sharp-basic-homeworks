using Csharp.Homework.Class06.Services;
using System;
using System.Threading;

namespace Csharp.Homework.Class06
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();

            Console.WriteLine("Welcome to ATM App!");
            Thread.Sleep(1500);

            Console.WriteLine("Enter your card number: ex. 1234-1234-1234-1234");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Enter your pin:");
            string pin = Console.ReadLine();

            var userLoggedIn = userService.Login(cardNumber, pin);

            bool findLoggedUser = false;
            if (userLoggedIn == null)
            {
                findLoggedUser = false;
            }

            if (!findLoggedUser)
            {
                Console.Clear();
                Console.WriteLine($"Welcome {userLoggedIn.FirstName} {userLoggedIn.LastName}");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check Balance\n2. Cash Withdrawal\n3. Cash Deposit");
                int.TryParse(Console.ReadLine(), out int userChoice);

                bool stopApp = true;
                while (stopApp)
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();
                            stopApp = false;

                            Console.WriteLine($"Your current balance is: {userLoggedIn.Balance}$");
                            break;
                        case 2:
                            Console.Clear();
                            stopApp = false;

                            Console.WriteLine("Enter how much money you want to withdraw:");
                            double.TryParse(Console.ReadLine(), out double withdrawCash);

                            userLoggedIn.Balance = userService.WithdrawalCash(userLoggedIn, withdrawCash);

                            Console.WriteLine($"You withdrew {withdrawCash}$. You have {userLoggedIn.Balance}$ left on your account.");
                            Console.WriteLine("Thank you for using ATM app!");
                            break;
                        case 3:
                            Console.Clear();
                            stopApp = false;

                            Console.WriteLine("Enter how much money you want to deposit:");
                            double.TryParse(Console.ReadLine(), out double depositCash);

                            userLoggedIn.Balance = userService.DepositCash(userLoggedIn, depositCash);

                            Console.WriteLine($"Your successfuly deposit cash!\n" +
                                              $"Deposit Cash: {depositCash}$\n" +
                                              $"New Balance: {userLoggedIn.Balance}$");
                            Console.WriteLine("Thank you for using ATM app!");
                            break;
                        default:
                            Console.WriteLine("Invalid Input!");
                            break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
