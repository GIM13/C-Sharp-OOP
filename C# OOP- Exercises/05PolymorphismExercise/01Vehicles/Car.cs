namespace _01Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
             : base(fuelQuantity, fuelConsumptionLitersPerKm, tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionLitersPerKm = fuelConsumptionLitersPerKm;
        }

        protected override double AirConditioning { get; set; } = 0.9;
    }
}
