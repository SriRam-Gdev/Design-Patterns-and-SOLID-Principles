using System;

namespace MyConsoleApp.src.OoPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            balance -= amount;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Current Balance: {balance:C}");
        }
    }
}