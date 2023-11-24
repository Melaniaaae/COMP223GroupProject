// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace PowerbillCalc

{
    class Program
    {
        static void Main()
        {
            const double Residential = 12.50;
            const double Commercial = 15.75;

            int powerconsumption;
            string typeofusage;

            //bill calculation function
            void billCalculator(int powerconsumption, double rate)
            {
                Console.WriteLine("Your Powerbill is: " + powerconsumption * rate);
            }

            void inputAction()
            {
                Console.WriteLine("Welcome to our PowerBill Calculator");
                Console.Write("Specify your type of usage \n 1 residential\n: 2 commercial\n : ");
                typeofusage = Console.ReadLine();
                if (typeofusage == "1" || typeofusage == "2")
                {
                    try
                    {
                        Console.Write("Enter amount of power consumed: ");
                        powerconsumption = Convert.ToInt32(Console.ReadLine());
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
                billCalculator(powerconsumption, Residential);
            }
            else if (typeofusage == "2")
            {
                billCalculator(powerconsumption, Commercial);
            }
        }
    }
}






