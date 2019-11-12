using System;
using System.Collections.Generic;

namespace _03ShoppingSpree
{
    public static class Engine
    {
        public static void Start()
        {
            try
            {
                string[] input = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                var persons = new Dictionary<string, Person>();

                for (int i = 0; i < input.Length; i++)
                {
                    string[] info = input[i]
                     .Split("=", StringSplitOptions.RemoveEmptyEntries);

                    string name = info[0];
                    decimal money = decimal.Parse(info[1]);

                    persons.Add(name, new Person(name, money));
                }

                input = Console.ReadLine()
                     .Split(";", StringSplitOptions.RemoveEmptyEntries);

                var products = new Dictionary<string, Product>();

                for (int i = 0; i < input.Length; i++)
                {
                    string[] info = input[i]
                     .Split("=", StringSplitOptions.RemoveEmptyEntries);

                    string name = info[0];
                    decimal cost = decimal.Parse(info[1]);

                    products.Add(name, new Product(name, cost));
                }

                string[] command = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                while (command[0] != "END")
                {
                    string namePerson = command[0];
                    string nameProduct = command[1];

                    if (persons.ContainsKey(namePerson)
                     && products.ContainsKey(nameProduct))
                    {
                        if (persons[namePerson].Money >= products[nameProduct].Cost)
                        {
                            persons[namePerson].BagOfProducts.Add(products[nameProduct]);

                            persons[namePerson].Money -= products[nameProduct].Cost;

                            Console.WriteLine($"{namePerson} bought {nameProduct}");
                        }
                        else
                        {
                            Console.WriteLine($"{namePerson} can't afford {nameProduct}");
                        }
                    }

                    command = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }

                foreach (var person in persons.Values)
                {
                    if (person.BagOfProducts.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
