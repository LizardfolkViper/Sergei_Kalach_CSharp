using System;
using System.Collections.Generic;

namespace ITAcademy.Homework2.OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TaxiStand TaxiService = new TaxiStand("Umer");
            TaxiService.AddCarInfo();
            string userInput;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose command number: 1.Show info, 2.Sort by fuel, 3.Choose car by speed, 0.Exit");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        TaxiService.ShowCompanyInfo();
                        Console.WriteLine("Press Enter to proceed");
                        Console.ReadLine();
                        break;
                    case "2":
                        TaxiService.SortByFuelConsumption();
                        Console.WriteLine("Press Enter to proceed");
                        Console.ReadLine();
                        break;
                    case "3":
                        TaxiService.FindCarBySpeed();
                        Console.WriteLine("Press Enter to proceed");
                        Console.ReadLine();
                        break;
                    case "0":
                        Console.WriteLine("Goodbye, user!");
                        break;
                    default:
                        Console.WriteLine("Error: Unknown command!");
                        Console.WriteLine("Press Enter to proceed");
                        Console.ReadLine();
                        break;
                }
            } while (userInput != "0");
            
        }

    }
}
