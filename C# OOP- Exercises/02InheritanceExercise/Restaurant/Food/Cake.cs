namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double caloriesCake = 1000;

        private const double gramsCake = 250;

        private const decimal cakePrice = 5M;

        public Cake(string name)
            : base(name, cakePrice, gramsCake, caloriesCake)
        {
        }
    }
}
