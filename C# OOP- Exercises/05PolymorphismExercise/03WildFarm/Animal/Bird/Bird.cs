namespace _03WildFarm.Animal.Bird
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
