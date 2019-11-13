using System;
using System.Collections.Generic;

namespace _04PizzaCalories
{
    public class Pizza
    {
        private string namePizza;

        public Pizza(string name)
        {
            NamePizza = name;
            ToppingsPizza = new List<Topping>();
        }

        public string NamePizza
        {
            get => namePizza;

            private set
            {
                if (value.Length < 1 || 15 < value.Length)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }

                namePizza = value;
            }
        }

        public Dough DoughPizza { get; set; }

        public List<Topping> ToppingsPizza { get; }

        public void AddTopping(Topping tooping)
        {
            if (ToppingsPizza.Count == 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            ToppingsPizza.Add(tooping);
        }

        private double GetCalories()
        {
           double calories = DoughPizza.GetCalories();

            foreach (var topping in ToppingsPizza)
            {
                calories += topping.GetCalories();
            }

            return calories;
        }

        public override string ToString()
        {
            return $"{namePizza} - {GetCalories():f2} Calories.";
        }
    }
}
