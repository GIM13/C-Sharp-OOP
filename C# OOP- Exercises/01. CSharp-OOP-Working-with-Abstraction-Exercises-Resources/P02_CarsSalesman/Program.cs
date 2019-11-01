using System;
using System.Collections.Generic;

namespace P02_CarsSalesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            int numEngines = int.Parse(Console.ReadLine());

            var listEngines = new List<Engine>();

            for (int i = 0; i < numEngines; i++)
            {
                string[] infoEngine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine.AddEnginToList(listEngines, infoEngine);
            }

            int numCars = int.Parse(Console.ReadLine());

            var listCar = new List<Car>();

            for (int i = 0; i < numCars; i++)
            {
                string[] infoCars = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car.AddCarToList(listEngines, listCar, infoCars);
            }

            foreach (var car in listCar)
            {
                Console.WriteLine(car);
            }
        }
    }
}
