using System;

namespace _01Vehicles
{
    public class Truck : IVehicle
    {
        private const double AirConditioning = 1.6;

        private const double leakage = 0.95;

        private double fuelQuantity; 

        public Truck(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionLitersPerKm = fuelConsumptionLitersPerKm;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {value} fuel in the tank");
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumptionLitersPerKm { get ; set ; }

        public double TankCapacity { get ; set ; }

        public void Drive(double distance, bool airConditioning)
        {
            double distanceConsumption;

            if (airConditioning)
            {
                distanceConsumption = (AirConditioning + FuelConsumptionLitersPerKm) * distance;
            }
            else
            {
                distanceConsumption = FuelConsumptionLitersPerKm * distance;
            }

            if (FuelQuantity >= distanceConsumption)
            {
                FuelQuantity -= distanceConsumption;

                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refueled(double liters)
        {
            if (liters + fuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                fuelQuantity +=  liters * leakage;
            }
        }

        public override string ToString()
        {
            return $"Truck: {FuelQuantity:f2}";
        }
    }
}
