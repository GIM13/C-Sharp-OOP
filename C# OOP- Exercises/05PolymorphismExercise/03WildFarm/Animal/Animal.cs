namespace _03WildFarm.Animal
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string Sound();
    }
}
