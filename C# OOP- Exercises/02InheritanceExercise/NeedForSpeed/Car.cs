namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public override double FuelConsumption { get; set; } = 3;
    }
}
