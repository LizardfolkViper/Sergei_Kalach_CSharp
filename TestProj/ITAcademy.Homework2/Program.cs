using System;

namespace ITAcademy.Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What task you want to run? (task1, task2, task3, task4, exit)");
            String taskCommand = Console.ReadLine();
            switch (taskCommand)
            {
                case "task1":
                    Console.WriteLine("Task #1 is loaded.");

                    Console.WriteLine("Input numbers. Input 0 to proceed.");
                    int sequenceInput;
                    int sequenceCounter = -1;
                    double sequenceSum = 0;
                    do
                    {
                        sequenceInput = Convert.ToInt32(Console.ReadLine());
                        sequenceCounter++;
                        sequenceSum += sequenceInput;

                    }
                    while (sequenceInput != 0);
                    Console.WriteLine($"Input amount: {sequenceCounter}");
                    Console.WriteLine($"Sum of numbers: {sequenceSum}");
                    if (sequenceCounter != 0)
                        Console.WriteLine($"Average: {sequenceSum / sequenceCounter}");
                    else
                        Console.WriteLine("No data");


                    break;
                case "task2":
                    Console.WriteLine("Task #2 is loaded.");


                    Console.WriteLine("Input range for numbers (Lowest border, then highest border)");
                    int rangeSum = 0;
                    int lowestBorder = int.Parse(Console.ReadLine());
                    int highestBorder = int.Parse(Console.ReadLine());
                    if (lowestBorder <= highestBorder)
                    {
                        do
                        {
                            if (lowestBorder % 2 == 1)
                            {
                                rangeSum += lowestBorder;


                            }
                            lowestBorder++;
                        }
                        while (lowestBorder <= highestBorder);
                        Console.WriteLine($"Sum of all odd numbers from range: {rangeSum}");
                    }
                    else Console.WriteLine("Error: range is invalid");


                    break;
                case "task3":
                    Console.WriteLine("Task #3 is loaded.");


                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    int i;
                    int j;
                    Console.Write("Input number of rows:");
                    int rows = Convert.ToInt32(Console.ReadLine());
                    for (i = 0; i < rows; i++)
                    {
                        for (j = 1; j <= rows - i; j++)
                            Console.Write(" ");
                        for (j = 1; j <= 2 * i - 1; j++)
                            Console.Write("\u039B");
                        Console.Write("\n");
                    }

                    break;
                case "task4":
                    Console.WriteLine("Task #4 is loaded.");

                    calculator("HateIt");


                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine($"Error: {taskCommand} is invalid command.");
                    break; 
            }
        }
        static string calculator(string starter)
        {
            var command = GetNewCommand();

            switch (command)
            {
                case "Calc":
                    {
                        var x = NumberInput();
                        var operation = OperationInput();
                        var y = NumberInput();

                        Calculate(x, y, operation);
                        return calculator("Haaaate");
                    }
                case "Fact":
                    {
                        Console.WriteLine("Input integer number for factorial^");
                        var factorial = CalculateFactorial(int.Parse(Console.ReadLine()));
                        if (factorial != 0)
                        {
                            Console.WriteLine($"Result: {factorial}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Incorrect input");
                        }
                        return calculator("HateSoMuch");
                    }
                case "Exit":
                    {
                        break;
                    }
                default:
                    {
                        return calculator("Hate");
                    }
            }
            return "FinallyDead";    

        }

        static string GetNewCommand()
        {
            Console.WriteLine("Input task (Calc, Fact, Exit)");
            return Console.ReadLine();
            
        }

        static double NumberInput()
        {
            Console.WriteLine("Please enter number for calculation:");
            var userInput = Console.ReadLine();
            var x = Convert.ToDouble(userInput);
            return x;
        }
        static string OperationInput()
        {
            Console.WriteLine("Input operation (+,-,*,/,^)");
            return Console.ReadLine();
        }

        static void Calculate(double a, double b, string operationType)
        {
            
            double output = 0;

            switch (operationType)
            {
                case "+":
                    output = CalculateSum(a, b);
                    break;
                case "-":
                    output = CalculateDifference(a, b);
                    break;
                case "*":
                    output = CalculateMultiplication(a, b);
                    break;
                case "/":
                    output = CalculateDivide(a, b);
                    break;
                case "^":
                    output = CalculatePower(a, b);
                    break;
                default:
                    Console.WriteLine("Error: incorrect");
                    break;
            }
            Console.WriteLine($"{a} {operationType} {b} = {output}");
        }
        static double CalculateSum(double a, double b)
        {
            return a + b;
        }
        static double CalculateDifference(double a, double b)
        {

            return a - b;
        }
        static double CalculateMultiplication(double a, double b)
        {
            return a * b;
        }
        static double CalculateDivide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero");
                return 0;
            }
            return a / b;
        }
        static double CalculatePower(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
