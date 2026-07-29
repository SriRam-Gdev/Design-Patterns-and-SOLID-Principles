using System;

class BankAccount
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
            throw new InvalidOperationException("Insufficient funds");
        }
        balance -= amount;
    }

    public void GetBalance()
    {
        Console.WriteLine($"Current balance: {balance:C}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.GetBalance();

            account.Withdraw(500);
            account.GetBalance();

            try
            {
                account.Withdraw(600);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            account.GetBalance();
        }
    }
}