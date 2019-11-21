namespace _03WildFarm.Animal.Mammal
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }

        public double WeightGainOverFood { get; set; } = 0.30;

        public override string Sound()
        {
            return "Meow";
        }
    }
}
