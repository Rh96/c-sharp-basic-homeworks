using Csharp.Homework.Class06.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Homework.Class06.Services
{
    public class ValidationService
    {
        public static bool FindUniqueCardNumber(long cardNumber, User[] users)
        {
            foreach (var user in users)
            {
                if (user.CardNumber == cardNumber)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CardNumberValidate(string cardNumber)
        {
            if (cardNumber.Length > 19)
            {
                return false;
            }

            if (!cardNumber.Contains('-'))
            {
                return false;
            }
            return true;
        }
        public static bool PinValidation(string pin)
        {
            if (pin.Length != 4)
            {
                return false;
            }
            return true;
        }
        public static bool WidthdrawalValidation(User user, double ammount)
        {
            if (user.Balance - ammount >= 0 && ammount >= 0)
            {
                return true;
            }
            return false;
        }

        public static bool DepositValidation(double ammount)
        {
            if (ammount < 0)
            {
                return false;
            }
            return true;
        }
    }
}
