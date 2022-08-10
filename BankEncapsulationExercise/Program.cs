﻿using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        private static object davidAccount;

        static void Main(string[] args)
        {
            var davidsAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            davidsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {davidsAccount.GetBalance()} ");

        }
    }
}
