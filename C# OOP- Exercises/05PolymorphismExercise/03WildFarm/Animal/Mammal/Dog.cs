namespace _03WildFarm.Animal.Mammal
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        public double WeightGainOverFood { get; set; } = 0.40;

        public override string Sound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
