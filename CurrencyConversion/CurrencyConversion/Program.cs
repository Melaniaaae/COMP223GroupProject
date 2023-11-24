// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleConvertor
{
    internal class Program
    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Available Currencies are:\n 1 USD\n 2 UGX\n 3 EUR\n 4 KSH");
                    Console.Write("Select Currency in hand: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Enter amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    double KSH = amount;
                    if (choice == 1)
                    {
                        KSH = amount * 152.47;
                    }
                    else if (choice == 2)
                    {
                        KSH = amount * 0.04;
                    }
                    else if (choice == 3)
                    {
                        KSH = amount * 166.28;
                    }
                    else if (choice == 4)
                    {
                        KSH = amount;
                    }
                    Console.WriteLine("Available Currencies are:\n 1 USD\n 2 UGX\n 3 EUR\n 4 KSH");
                    Console.Write("Select Currency you want to convert to: ");
                    int choice1 = Convert.ToInt32(Console.ReadLine());
                    if (choice1 == 1)
                    {
                        Console.WriteLine($"Amount: {KSH / 152.47}");
                        break;
                    }
                    else if (choice1 == 2)
                    {
                        Console.WriteLine($"Amount: {KSH / 0.04}");
                        break;
                    }
                    else if (choice1 == 3)
                    {
                        Console.WriteLine($"Amount: {KSH / 166.28}");
                        break;
                    }
                    else if (choice1 == 4)
                    {
                        Console.WriteLine($"Amount: {KSH}");
                        break;
                    }

                } catch
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }
        }
    }
}