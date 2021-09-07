using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Homework2.OOP
{
    class Car
    {
        public string Model { private set; get; }
        public double FuelConsumption { private set; get; }
        public double Cost { private set; get; }
        public int MaxSpeed { private set; get; }
        public Car(string model, double fuelConsumption, double cost, int speed)
        {
            this.Model = model;
            this.FuelConsumption = fuelConsumption;
            this.Cost = cost;
            this.MaxSpeed = speed;
        }

    }
}
