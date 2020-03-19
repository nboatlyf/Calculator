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
            Console.WriteLine(Environment.NewLine);

            // Specify which operators can be used.
            var validOperators = new List<string>
            {
                 "+"
                ,"-"
                ,"*"
                ,"/"
            };
            var validOperatorsListed= string.Join(", ", validOperators.ToArray());

            // Ask the user to choose an operator from the specified list.
            Console.Write($"Please enter one of the following operators: {validOperatorsListed}: ");
            var chosenOperator = Console.ReadLine();
            if (!validOperators.Contains(chosenOperator))
            {
                throw new ArgumentOutOfRangeException($"Invalid operator entered. Please use one of the following: {validOperatorsListed}.");
            }

            // Ask the user to choose the number of operands (that the chosen operator will be applied to).
            Console.Write($"Please enter how many operands you would like to include: ");
            var numberOfOperandsArgument = Console.ReadLine();
            if (!int.TryParse(numberOfOperandsArgument, out var numberOfOperands))
                throw new ArgumentOutOfRangeException($"Invalid number of operands entered. Please enter a positive integer number.");
            if (numberOfOperands <= 0)
                throw new ArgumentOutOfRangeException($"Invalid number of operands entered. Please enter a positive integer number.");

            // Ask the user to specify the operands (that the chosen operator will be applied to, in the order the operands were specified).
            var arguments = new List<string> { };
            var operands = new List<double> { };
            for (var i = 0; i < numberOfOperands; i++)
            {
                Console.Write($"Please enter operand {i}: ");
                var argument = Console.ReadLine();
                if (!double.TryParse(argument, out var operand))
                    throw new ArgumentOutOfRangeException("Invalid argument entered. Please enter a number.");
                arguments.Add(argument);
                operands.Add(operand);
            }

            // Calculate the answer by applying the chosen operator to each operand, in the order they were entered into the program.
            var intermediateAnswer = operands[0];

            if (chosenOperator == "+")
            {
                for (var i = 1; i < numberOfOperands; i++)
                {
                    intermediateAnswer += operands[i];
                }
            }

            else if (chosenOperator == "-")
            {
                for (var i = 1; i < numberOfOperands; i++)
                {
                    intermediateAnswer -= operands[i];
                }
            }

            else if (chosenOperator == "*")
            {
                for (var i = 1; i < numberOfOperands; i++)
                {
                    intermediateAnswer *= operands[i];
                }
            }

            else if (chosenOperator == "/")
            {
                for (var i = 1; i < numberOfOperands; i++)
                {
                    intermediateAnswer /= operands[i];
                }
            }

            var answer = intermediateAnswer;

            // Write out the expression as a string.

            var answerExpressionWrittenOut = arguments[0];

            for (var i = 1; i < numberOfOperands; i++)
            {
                answerExpressionWrittenOut = $"({answerExpressionWrittenOut} {chosenOperator} {arguments[i]})";
            }

            // Output the calculation for the user to see.
            var message = $"Answer = {answerExpressionWrittenOut} = {answer}";
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
