using System;

class BankAccount
{
    public string AccountNumber { get; set; } = "";
    private decimal balance;

    public decimal Balance
    {
        get => balance;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Balance), "Balance cannot be negative.");
            balance = value;
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount { AccountNumber = "AC101", Balance = 5000m };
        Console.WriteLine($"{account.AccountNumber}: {account.Balance}");
        try { account.Balance = -100m; }
        catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
    }
}
