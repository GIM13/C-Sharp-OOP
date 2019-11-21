using System;

namespace _01Vehicles
{
    public class Bus : IVehicle
    {
        private const double AirConditioning = 1.4;

        private double fuelQuantity;

        public Bus(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
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

        public double FuelConsumptionLitersPerKm { get; set; }

        public double TankCapacity { get; set; }

        public void Drive(double distance, bool airConditioning)
        {
            double distanceConsumption = 0;

            if (airConditioning == true)
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

                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
                fuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"Bus: {FuelQuantity:f2}";
        }
    }
}
