namespace _03WildFarm.Animal.Mammal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion; 
        }

        public double WeightGainOverFood { get; set; } = 0.10;

        public override string Sound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
