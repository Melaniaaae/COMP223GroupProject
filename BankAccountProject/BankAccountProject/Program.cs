// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class BankAccount
{
    private static int accountNumberSeed = 1234567890;

    public string AccountNumber { get; }
    public string Owner { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance)
    {
        AccountNumber = accountNumberSeed.ToString();
        accountNumberSeed++;

        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount should be greater than zero.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"{amount:C} deposited successfully. Current balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount should be greater than zero.");
            return;
        }
        if (Balance - amount < 0)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"{amount:C} withdrawn successfully. Current balance: {Balance:C}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current balance: {Balance:C}");
    }
}

class Program
{
    static Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();

    static void Main()
    {
        bool runApp = true;
        while (runApp)
        {
            Console.WriteLine();
            Console.WriteLine("Bank Account Management System");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    MakeDeposit();
                    break;
                case 3:
                    MakeWithdrawal();
                    break;
                case 4:
                    CheckAccountBalance();
                    break;
                case 5:
                    runApp = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateAccount()
    {
        Console.Write("Enter account owner's name: ");
        string owner = Console.ReadLine();
        Console.Write("Enter initial balance: ");
        decimal balance = Convert.ToDecimal(Console.ReadLine());

        BankAccount account = new BankAccount(owner, balance);
        accounts.Add(account.AccountNumber, account);
        Console.WriteLine($"Account created successfully. Account Number: {account.AccountNumber}");
        //Console.Clear();
    }
        static void MakeDeposit()
    {
        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();
        if (accounts.ContainsKey(accNumber))
        {
            Console.Write("Enter deposit amount: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            accounts[accNumber].Deposit(depositAmount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
        Console.Clear();
    }

    static void MakeWithdrawal()
    {
        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();
        if (accounts.ContainsKey(accNumber))
        {
            Console.Write("Enter withdrawal amount: ");
            decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            accounts[accNumber].Withdraw(withdrawalAmount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
        Console.Clear();
    }

    static void CheckAccountBalance()
    {
        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();
        if (accounts.ContainsKey(accNumber))
        {
            accounts[accNumber].CheckBalance();
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
        Console.Clear();
    }
}
