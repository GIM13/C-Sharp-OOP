namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public override double FuelConsumption { get; set; } = 8;
    }
}
