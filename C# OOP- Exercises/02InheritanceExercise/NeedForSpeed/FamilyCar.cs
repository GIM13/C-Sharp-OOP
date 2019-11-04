namespace NeedForSpeed
{
    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }
    }
}
