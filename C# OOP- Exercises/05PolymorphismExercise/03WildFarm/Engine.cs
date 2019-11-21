using System;
using System.Collections.Generic;

using _03WildFarm.Animal;
using _03WildFarm.Animal.Bird;
using _03WildFarm.Animal.Mammal;

namespace _03WildFarm
{
    public static class Engine
    {
        public static void Start()
        {
            string[] animalInfo = Console.ReadLine().Split();
            
            var animals = new List<IAnimal>();

            while (animalInfo[0] != "End")
            {
                string[] foodInfo = Console.ReadLine().Split();

                string animalType = animalInfo[0];
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);

                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);

                if (animalType == "Hen")
                {
                    double wingSize = double.Parse(animalInfo[3]);

                    var hen = new Hen(name, weight, wingSize);
                    Console.WriteLine(hen.Sound());

                    hen.FoodEaten += quantity;
                    hen.Weight += quantity * hen.WeightGainOverFood;

                    animals.Add(hen);
                }
                else if (animalType == "Owl")
                {
                    double wingSize = double.Parse(animalInfo[3]);

                    var owl = new Owl(name, weight, wingSize);
                    Console.WriteLine(owl.Sound());

                    if (foodType == "Meat")
                    {
                        owl.FoodEaten += quantity;
                        owl.Weight += quantity * owl.WeightGainOverFood;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }

                    animals.Add(owl);
                }
                else if (animalType == "Cat")
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];

                    var cat = new Cat(name, weight, livingRegion, breed);
                    Console.WriteLine(cat.Sound());

                    if (foodType == "Meat" || foodType == "Vegetable")
                    {
                        cat.FoodEaten += quantity;
                        cat.Weight += quantity * cat.WeightGainOverFood;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }

                    animals.Add(cat);
                }
                else if (animalType == "Dog")
                {
                    string livingRegion = animalInfo[3];

                    var dog = new Dog(name, weight, livingRegion);
                    Console.WriteLine(dog.Sound());

                    if (foodType == "Meat")
                    {
                        dog.FoodEaten += quantity;
                        dog.Weight += quantity * dog.WeightGainOverFood;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }

                    animals.Add(dog);
                }
                else if (animalType == "Mouse")
                {
                    string livingRegion = animalInfo[3];

                    var mouse = new Mouse(name, weight, livingRegion);
                    Console.WriteLine(mouse.Sound());

                    if (foodType == "Fruit" || foodType == "Vegetable")
                    {
                        mouse.FoodEaten += quantity;
                        mouse.Weight += quantity * mouse.WeightGainOverFood;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }

                    animals.Add(mouse);
                }
                else if (animalType == "Tiger")
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];

                    var tiger = new Tiger(name, weight, livingRegion, breed);
                    Console.WriteLine(tiger.Sound());

                    if (foodType == "Meat")
                    {
                        tiger.FoodEaten += quantity;
                        tiger.Weight += quantity * tiger.WeightGainOverFood;
                    }
                    else
                    {
                        Console.WriteLine($"{animalType} does not eat {foodType}!");
                    }

                    animals.Add(tiger);
                }

                animalInfo = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }
    }
}
