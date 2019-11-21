namespace _03WildFarm.Animal.Mammal
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
