using System;

namespace _04PizzaCalories
{
    public class Topping
    {
        private const double meat  = 1.2;
        private const double veggies  = 0.8;
        private const double cheese  = 1.1;
        private const double sauce  = 0.9;

        private double modifier;
        private string type;
        private int weight;
        private double calories;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;

            private set
            {
                string copy = value.ToLower();

                if (copy == "meat")
                {
                    modifier = meat;
                }
                else if (copy == "veggies")
                {
                    modifier = veggies;
                }
                else if (copy == "sauce")
                {
                    modifier = sauce;
                }
                else if (copy == "cheese")
                {
                    modifier = cheese;
                }
                else
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }
        public int Weight
        {
            get => weight;

            private set
            {
                if (value < 1 || 50 < value)
                {
                    throw new Exception($"{type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double GetCalories()
        {
            calories = 2 *  weight * modifier;

            return calories;
        }
    }
}
