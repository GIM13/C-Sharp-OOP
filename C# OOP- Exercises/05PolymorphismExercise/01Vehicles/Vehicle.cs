using System;

namespace _01Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
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
                if (value <= TankCapacity)
                {
                    fuelQuantity = value;
                }
                else if (value <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
            }
        }

        public double FuelConsumptionLitersPerKm { get; set; }

        public double TankCapacity { get; set; }

        protected virtual double AfterLeakage { get; set; } = 1;

        protected virtual double AirConditioning { get; set; } = 0;

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

                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
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
                fuelQuantity += liters * AfterLeakage;
            }
        }

        public override string ToString()
        {
            double result = Math.Round(FuelQuantity, 2);

            return $"{GetType().Name}: {result:f2}";
        }
    }
}
