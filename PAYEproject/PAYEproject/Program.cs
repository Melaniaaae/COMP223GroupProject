// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;

namespace PAYECalc { 
    class Program { 
        static void Main() { 
        double monthlyincome;
        double allowance;
        double deduction;

        void InputAction()
            {
                try {
                    Console.Write("Enter your monthly income: ");
                    monthlyincome = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter your allowance ,if any: ");
                    allowance = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter deductions,if any: ");
                    deduction = Convert.ToDouble(Console.ReadLine());
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("Wrong Input");
                    InputAction();
                }
            
        }
        InputAction();
        double totalincome = monthlyincome + allowance - deduction;
        if (totalincome >= 24000)
        {
            Console.WriteLine($"Your PAYE tax amount is: {totalincome * 0.10}");
        }
        else if (totalincome <= 24001 && totalincome >= 40000)
        {
            Console.WriteLine($"Your PAYE tax amount is: {totalincome * 0.15}");
        }
        else if (totalincome <= 40001 && totalincome >= 60000)
        {
            Console.WriteLine($"Your PAYE tax amount is: {totalincome * 0.20}");
        }
        else if (totalincome <= 60001 && totalincome >= 100000)
        {
            Console.WriteLine($"Your PAYE tax amount is: {totalincome * 0.25}");
        }
        else if (totalincome <= 100001 && totalincome >= 150000)
        {
            Console.WriteLine($"Your PAYE tax amount is: {totalincome * 0.30}");
        }
        else if (totalincome <= 150001 && totalincome >= 250000)
        {
            Console.WriteLine($"Your PAYE tax amount is: {totalincome * 0.35}");
        }
        else if (totalincome <= 250000)
        {
            Console.WriteLine($"Your PAYE tax amount is: {totalincome * 0.40}");
        }
}
}
}
