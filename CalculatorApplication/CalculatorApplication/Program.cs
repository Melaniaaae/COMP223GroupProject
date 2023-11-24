
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

                    if (operation == "+")
                    {
                        Console.WriteLine($"Answer: {num1 + num2}");
                        break;
                    }
                    else if (operation == "-")
                    {
                        Console.WriteLine($"Answer: {num1 - num2}");
                        break;
                    }
                    else if (operation == "*")
                    {
                        Console.WriteLine($"Answer: {num1 * num2}");
                        break;
                    }
                    else if (operation == "/")
                    {
                        try
                        {
                            double answer = num1 / num2;
                            Console.WriteLine($"Answer: {answer}");
                            break;
                        }
                        catch(DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    }
                }
                catch 
                {
                    continue;
                }
            }
    }
    }
}