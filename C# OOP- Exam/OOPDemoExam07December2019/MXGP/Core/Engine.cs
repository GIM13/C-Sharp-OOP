using MXGP.Core.Contracts;
using System;

namespace MXGP.Core
{
    internal class Engine : IEngine
    {
        public void Run()
        {
            string input = Console.ReadLine();

            ChampionshipController controller = new ChampionshipController();

            while (input != "End")
            {
                string[] info = input.Split();

                try
                {
                    if (input.StartsWith("CreateRider"))
                    {
                        string name = info[1];

                        Console.WriteLine(controller.CreateRider(name));
                    }
                    else if (input.StartsWith("CreateMotorcycle"))
                    {
                        string motorcycleType = info[1];
                        string model = info[2];
                        int horsePower = int.Parse(info[3]);

                        Console.WriteLine(controller.CreateMotorcycle(motorcycleType, model, horsePower));
                    }
                    else if (input.StartsWith("AddMotorcycleToRider"))
                    {
                        string riderName = info[1];
                        string motorcycleName = info[2];

                        Console.WriteLine(controller.AddMotorcycleToRider(riderName, motorcycleName));
                    }
                    else if (input.StartsWith("AddRiderToRace"))
                    {
                        string raceName = info[1];
                        string riderName = info[2];

                        Console.WriteLine(controller.AddRiderToRace(raceName, riderName));
                    }
                    else if (input.StartsWith("CreateRace"))
                    {
                        string name = info[1];
                        int laps = int.Parse(info[2]);

                        Console.WriteLine(controller.CreateRace(name, laps));
                    }
                    else if (input.StartsWith("StartRace"))
                    {
                        string raceName = info[1];

                        Console.WriteLine(controller.StartRace(raceName));
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
