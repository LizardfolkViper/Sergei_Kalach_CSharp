using System;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            double chocolatePrice = 2.10;
            double cofePrice = 9.9;
            double milkPrice = 1.8;
            double productSum = chocolatePrice + cofePrice + milkPrice;

            //Task 2
            int a = 5;
            int b = a + 3;
            int c = a + b;

            //Task 3
            Console.WriteLine("Input 3 integer numbers:");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            string number3 = Console.ReadLine();
            double result1 = Convert.ToDouble(number1)/ Convert.ToDouble(number2);
            Console.WriteLine($"1st number divided by 2nd: {result1}");
            long result2 = Convert.ToInt32(number1)* Convert.ToInt32(number2) * Convert.ToInt32(number3);
            Console.WriteLine($"1st, 2nd and 3rd numbers multiplied: {result2}");
        }
    }
}
