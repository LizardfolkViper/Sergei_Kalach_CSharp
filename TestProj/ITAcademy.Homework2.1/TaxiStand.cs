using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Homework2.OOP
{
    class TaxiStand
    {
        public string companyName { private set; get; }
        List<Car> carCollection = new List<Car>(3);
        public TaxiStand(string compName)
        {
            companyName = compName;
        }
        public void AddCarInfo()
        {
            carCollection.Add(new Car("Sedan", 10, 10000, 150));
            carCollection.Add(new Car("Toyota", 8, 9000, 150));
            carCollection.Add(new Car("Bugatti", 20, 15000, 230));
        }
        public void ShowCompanyInfo()
        {
            Console.WriteLine($"Company name: {companyName}");
            Console.WriteLine($"Cars stationed: {carCollection.Count}");
            double carsTotalCost = 0;
            foreach (Car car in carCollection)
            {
                carsTotalCost += car.Cost;
            }
            Console.WriteLine($"Total value of cars: {carsTotalCost}");
        }
        public void SortByFuelConsumption()
        {
            carCollection.Sort(delegate (Car x, Car y) { return x.FuelConsumption.CompareTo(y.FuelConsumption); });
            foreach (Car car in carCollection)
            {
                Console.WriteLine($"Car model: {car.Model}, {car.FuelConsumption}L/100Km fuel consumption.");
            }
        }
        public void FindCarBySpeed()
        {
            int minSpeedLimit = 0;
            int maxSpeedLimit = 0;
            Console.WriteLine("Set minimum and maximum top speed values.");
            try
            {
                minSpeedLimit = Int32.Parse(Console.ReadLine());
                maxSpeedLimit = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: incorrect input. Please use whole numbers and try again!");
                this.FindCarBySpeed();
            }
            if (minSpeedLimit > maxSpeedLimit)
            {
                Console.WriteLine("Illegal speed limit (min>max). Try again!");
                this.FindCarBySpeed();
            }

            var bestCarComparison = new Car(null, 0, 0, 0);
            foreach (Car car in carCollection)
            {

                if (car.MaxSpeed >= minSpeedLimit && car.MaxSpeed <= maxSpeedLimit && car.MaxSpeed > bestCarComparison.MaxSpeed || car.Cost < bestCarComparison.Cost)
                {
                    bestCarComparison = car;
                }
            }
            if (bestCarComparison.Model != null)
            {
                Console.Clear();
                Console.WriteLine($"We found next car for you: {bestCarComparison.Model}, speed {bestCarComparison.MaxSpeed}km/h, costs {bestCarComparison.Cost} teef");
            }
            else
            {
                Console.WriteLine("Sorry, we couldn't find matching car for you. Try again.");
            }
        }

    }
}
