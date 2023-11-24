// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Calculator

             
{
    class Program
    {
        static void Main()
        {
            const double Residential = 25.00;
            const double Commercial = 30.50;

            int amountconsumed;
            string typeofusage;

            //bill calculation function
            void billCalculator(int amountconsumed, double rate) {
                Console.WriteLine("Your waterbill is: " + amountconsumed * rate) ;
            }

            void inputAction()
            {
                Console.WriteLine("Welcome to our WaterBill Calculator");
                Console.Write("Specify your type of usage \n 1 residential\n: 2 commercial\n : ");
                typeofusage = Console.ReadLine();
                if (typeofusage == "1" || typeofusage == "2")
                {
                    try {
                        Console.Write("Enter amount of water consumed: ");
                        amountconsumed = Convert.ToInt32(Console.ReadLine());
                    } catch (System.FormatException) {
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
                    billCalculator(amountconsumed, Residential);
                }
            else if (typeofusage == "2")
            {
                billCalculator(amountconsumed, Commercial);
            }
        }
    }
}


