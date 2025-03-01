using System;

class Calculator
{
    static void Main()
    {
        while (true) // Keeps running until user chooses to exit
        {
            Console.Write("Enter firstt number (or type 'exit' to quit): ");
            string input1 = Console.ReadLine();

            if (input1.ToLower() == "exit") break; // Exit condition

            if (!double.TryParse(input1, out double num1))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /, %): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            if (!double.TryParse(input2, out double num2))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            double result = 0;
            bool validOperation = true;

            switch (op)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    else
                        result = num1 / num2;
                    break;
                case '%': result = num1 % num2; break;
                default:
                    Console.WriteLine("Invalid operator! Use +, -, *, /, or %.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
                Console.WriteLine($"Result: {result}");

            Console.WriteLine("\n---------------------------\n");
        }
    }
}
