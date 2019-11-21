using System;
using System.Linq;
using System.Collections.Generic;

namespace _05BorderControl
{
    public class Engine
    {
        public static void Start()
        {
            int num = int.Parse(Console.ReadLine());

            var command = Console.ReadLine().Split();

            var buyers = new List<IBuyer>();

            for (int i = 0; i < num ; i++)
            {
                string name = command[0];
                int age = int.Parse(command[1]);
                string idOrGroup = command[2];

                if (command.Length == 4)
                {
                    string birthdate = command[3];

                    buyers.Add(new Citizen(name, age, idOrGroup,birthdate));
                }
                else
                {
                    buyers.Add(new Rebel(name, age, idOrGroup));
                }

                command = Console.ReadLine().Split();
            }

            while (command[0] != "End")
            {
                foreach (var buyer in buyers)
                {
                    if (buyer.Name == command[0])
                    {
                        buyer.BuyFood();
                    }
                }

                command = Console.ReadLine().Split();
            }

            int sumFood = buyers.Sum(x => x.Food);

            Console.WriteLine(sumFood);
        }
    }
}
