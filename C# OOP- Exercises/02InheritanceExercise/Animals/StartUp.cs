using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            string animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                string[] infoAnimai = Console.ReadLine().Split();
                string name = infoAnimai[0];
                int age = int.Parse(infoAnimai[1]);
                string gender = infoAnimai[2];

                if (age < 0)
                {
                    Console.WriteLine("Invalid input!");

                    animalType = Console.ReadLine();

                    continue;
                }

                var animal = new Animal("", 0, "");

                if (animalType == "Dog")
                {
                    animal = new Dog(name, age, gender);
                }
                else if (animalType == "Frog")
                {
                    animal = new Frog(name, age, gender);
                }
                else if (animalType == "Cat")
                {
                    animal = new Cat(name, age, gender);
                }
                else if (animalType == "Kitten")
                {
                    animal = new Kitten(name, age);
                }
                else if (animalType == "Tomcat")
                {
                    animal = new Tomcat(name, age);
                }

                Console.WriteLine(animal);

                animalType = Console.ReadLine();
            }
        }
    }
}
