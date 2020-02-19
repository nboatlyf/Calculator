using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("==========================");
            Console.WriteLine("\n");

            // Specify which operators can be used.
            List<string> validOperators = new List<string>();
            validOperators.Add("+");
            validOperators.Add("-");
            validOperators.Add("*");
            validOperators.Add("/");
            string validOperatorsListString = string.Join(", ", validOperators.ToArray());

            // Ask the user to choose an operator from the specified list.
            Console.Write($"Please enter one of the following operators: {validOperatorsListString}: ");
            string userOperator = Console.ReadLine();
            if (!validOperators.Contains(userOperator))
            {
                throw new ArgumentOutOfRangeException($"Invalid operator entered. Please use one of the following: {validOperatorsListString}.");
            }

            // Ask the user to enter the first operand.
            Console.Write("Please enter the first number: ");
            string argument1 = Console.ReadLine();
            if (!double.TryParse(argument1, out double operand1))
                throw new ArgumentOutOfRangeException("Invalid argument entered. Please enter a number.");

            // Ask the user to enter the second operand.
            Console.Write("Please enter the second number: ");
            string argument2 = Console.ReadLine();
            if (!double.TryParse(argument2, out double operand2))
                throw new ArgumentOutOfRangeException("Invalid argument entered. Please enter a number.");

            double expressionEvaluation = 0;

            // Evaluate the expression formed using the operator and 2 operands entered by the user.
            if (userOperator == "+")
                expressionEvaluation = operand1 + operand2;

            else if (userOperator == "-")
                expressionEvaluation = operand1 - operand2;

            else if (userOperator == "*")
                expressionEvaluation = operand1 * operand2;

            else if (userOperator == "/")
                expressionEvaluation = operand1 / operand2;

            // Output the calculation for the user to see.
            string message = $"{operand1} {userOperator} {operand2} = {expressionEvaluation}";
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
