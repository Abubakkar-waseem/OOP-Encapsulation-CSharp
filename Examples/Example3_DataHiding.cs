using System;

class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(6000);
        Console.WriteLine(account.GetBalance());
    }
}
