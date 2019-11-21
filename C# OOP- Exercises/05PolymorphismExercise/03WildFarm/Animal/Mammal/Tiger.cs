namespace _03WildFarm.Animal.Mammal
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight,  string livingRegion, string breed)
        {
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion; 
            Breed = breed;
        }

        public double WeightGainOverFood { get; set; } = 1.00;

        public override string Sound()
        {
            return "ROAR!!!";
        }
    }
}
