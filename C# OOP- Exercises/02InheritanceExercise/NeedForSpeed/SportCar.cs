namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public override double FuelConsumption { get; set; } = 10;
    }
}
