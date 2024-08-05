using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task2
{
    internal class Car : IVehicle,IDrivable
    {
        private int fuel = 0;
        public Car(int Startfuel)
        {
            this.fuel = Startfuel;
            Console.WriteLine($"Car created with {this.fuel} gallons of gas");
        }
        public void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Car is driving");
                fuel--;
            }
            else
            {
                Console.WriteLine("Car is out of gas");
            }
        }

        public bool Refuel(int amount)
        {
            if (amount > 0)
            {
                fuel += amount;
                Console.WriteLine($"Car refueled with {amount} gallons of gas");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid amount to refuel.");
                return false;
            }
            
        }
        
        void IDrivable.Move()
        {
            Console.WriteLine("Car is moving");
        }

        void IDrivable.Drive()
        {
            Console.WriteLine("Car is driving");
        }

        void IDrivable.accelerate()
        {
            Console.WriteLine("Car is accelerating");
        }
    }
}
