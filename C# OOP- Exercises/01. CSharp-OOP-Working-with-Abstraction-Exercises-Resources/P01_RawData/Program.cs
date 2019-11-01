using System;
using System.Collections.Generic;

namespace P01_RawData
{
    public class RawData
    {
        public static void Main()
        {
            int numberCars = int.Parse(Console.ReadLine());

            var listCars = new List<Car>();

            for (int i = 0; i < numberCars; i++)
            {
                string[] info = Console.ReadLine().Split();

                string model = info[0];

                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);

                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];

                double tire1Pressure = double.Parse(info[5]);
                int tire1Age = int.Parse(info[6]);
                double tire2Pressure = double.Parse(info[7]);
                int tire2Age = int.Parse(info[8]);
                double tire3Pressure = double.Parse(info[9]);
                int tire3Age = int.Parse(info[10]);
                double tire4Pressure = double.Parse(info[11]);
                int tire4Age = int.Parse(info[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tireSet = new TireSet(tire1Pressure, tire1Age
                                        , tire2Pressure, tire2Age
                                        , tire3Pressure, tire3Age
                                        , tire4Pressure, tire4Age);

                var car = new Car(model, engine, cargo, tireSet);

                listCars.Add(car);
            }

            string command = Console.ReadLine();

            var result = new List<string>();

            foreach (var car in listCars)
            {
                if (command == "fragile"
                 && car.Cargo.CargoType == "fragile"
                 && car.TireSet.LittlePressureTire())
                {
                    result.Add(car.Model);
                }
                else if (command == "flamable"
                      && car.Cargo.CargoType == "flamable"
                      && car.Engine.EnginePower > 250)
                {
                    result.Add(car.Model);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
