using System;
using System.Collections.Generic;

namespace _01Vehicles
{
    public class Engine
    {
        public static void Start()
        {
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var car = new Car(double.Parse(command[1]),
                              double.Parse(command[2]),
                              double.Parse(command[3]));

            command = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(command[1]),
                                  double.Parse(command[2]),
                                  double.Parse(command[3]));

            command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var bus = new Bus(double.Parse(command[1]),
                              double.Parse(command[2]),
                              double.Parse(command[3]));

            int numCommand = int.Parse(Console.ReadLine());

            var vehicles = new Dictionary<string, IVehicle>() { { "Car", car }, { "Truck", truck }, { "Bus", bus } };

            for (int i = 0; i < numCommand; i++)
            {
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];
                string vehicle = command[1];
                double value = double.Parse(command[2]);

                if (action == "Drive")
                {
                    vehicles[vehicle].Drive(value, true);
                }
                else if (action == "Refuel")
                {
                    vehicles[vehicle].Refueled(value);
                }
                else if (action == "DriveEmpty")
                {
                    vehicles[vehicle].Drive(value, false);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, vehicles.Values));
        }
    }
}
