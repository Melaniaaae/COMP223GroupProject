
// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq.Expressions;
namespace Program
{ 

class Calculator
{

    static void Main()
    {
        bool running = true;
            while (running)
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Enter num1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter num2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter operator: ");
                    string operation = Console.ReadLine();


                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"Answer: {num1 + num2}");
                            running = false;
                            break;
                        case "-":
                            Console.WriteLine($"Answer: {num1 - num2}");
                            running = false;
                            break;
                        case "*":
                            Console.WriteLine($"Answer: {num1 * num2}");
                            running = false;
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                double answer = num1 / num2;
                                Console.WriteLine($"Answer: {answer}");
                                running = false;
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
            }
    }
    }
}