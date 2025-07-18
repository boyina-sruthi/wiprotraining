// See https://aka.ms/new-console-template for more information
using System;

namespace CalculatorOperation
{
    internal class Program
    {
        static void Main(String[] args)
        {
            double num1, num2, result = 0;
            string operations;
            Console.WriteLine("Simple Calculator");

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            operations = Console.ReadLine();

            Console.Write("Enter second number : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (operations == "+")
            {
                result = num1 + num2;
            }
            else if (operations == "-")
            {
                result = num1 - num2;
            }
            else if (operations == "*")
            {
                result = num1 * num2;
            }
            else if (operations == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error : Division by zero.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid Operator.");
                return;
            }
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}