namespace _01Vehicles
{
    interface IVehicle
    {
        public double FuelQuantity { get; set; }

        public double FuelConsumptionLitersPerKm { get; set; }

        public double TankCapacity { get; set; }

        public void Drive(double distance, bool airConditioning);

        public void Refueled(double liters);
    }
}
