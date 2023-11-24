
            // See https://aka.ms/new-console-template for more information
            // See https://aka.ms/new-console-template for more information
            using System;
            using System.Runtime.CompilerServices;
            using System.Security.Cryptography.X509Certificates;
namespace SewageCalc

    {
        class Program
        {
            static void Main()
            {
                const double Residential = 10.00;
                const double Commercial = 12.50;

                int waterconsumption;
            string typeofusage;

                //bill calculation function
                void billCalculator(int waterconsumption, double rate)
                {
                    Console.WriteLine("Your Sewagebill is: " + waterconsumption * rate);
                }

                void inputAction()
                {
                    Console.WriteLine("Welcome to our SewageBill Calculator");
                    Console.Write("Specify your type of usage \n 1 residential\n: 2 commercial\n : ");
                    typeofusage = Console.ReadLine();
                    if (typeofusage == "1" || typeofusage == "2")
                    {
                        try
                        {
                            Console.Write("Enter amount of water consumed: ");
                            waterconsumption = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (System.FormatException)
                        {
                            inputAction();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!!!");
                        inputAction();
                    }
                }

                inputAction();

                if (typeofusage == "1")
                {
                    billCalculator(waterconsumption, Residential);
                }
                else if (typeofusage == "2")
                {
                    billCalculator(waterconsumption, Commercial);
                }
            }
        }
    }




    
