using System;

namespace _04PizzaCalories
{
    public class Engine
    {
        public static void Start()
        {
            try
            {
                var input = Console.ReadLine()
                    .Split();

                var pizza = new Pizza(input[1]);

                input = Console.ReadLine()
                    .Split();

                pizza.DoughPizza = new Dough(input[1], input[2], int.Parse(input[3]));

                input = Console.ReadLine()
                    .Split();

                while (input[0] != "END")
                {
                    pizza.AddTopping(new Topping(input[1],int.Parse(input[2])));

                    input = Console.ReadLine()
                    .Split();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
