using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator! \n");

            Console.WriteLine("Firstly let's multiply 2 numbers together.");
            Console.Write("Please enter the first number to multiply: ");
            double multiplicand1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number to multiply: ");
            double multiplicand2 = double.Parse(Console.ReadLine());
            double product = multiplicand1 * multiplicand2;
            Console.WriteLine(multiplicand1 + " x " + multiplicand2 + " = " + product);

            Console.ReadLine();
        }
    }
}
