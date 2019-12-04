using MortalEngines.Core.Contracts;
using MortalEngines.IO;
using System;
using System.Linq;

namespace MortalEngines.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            var machinesManager = new MachinesManager();

            var writer = new Writer();

            string command = Console.ReadLine();

            try
            {
                while (command != "Quit")
                {
                    if (command.StartsWith("HirePilot"))
                    {
                        string[] name = command.Split().Skip(1).ToArray();

                        writer.Write(machinesManager.HirePilot(name[0]));
                    }
                    else if (command.StartsWith("PilotReport"))
                    {
                        string[] name = command.Split().Skip(1).ToArray();

                        writer.Write(machinesManager.PilotReport(name[0]));
                    }
                    else if (command.StartsWith("ManufactureTank"))
                    {
                        string[] info = command.Split();
                        string name = info[1];
                        double attack = double.Parse(info[2]);
                        double defense = double.Parse(info[3]);

                        writer.Write(machinesManager.ManufactureTank(name, attack, defense)); 
                    }
                    else if (command.StartsWith("ManufactureFighter"))
                    {
                        string[] info = command.Split();
                        string name = info[1];
                        double attack = double.Parse(info[2]);
                        double defense = double.Parse(info[3]);

                        writer.Write(machinesManager.ManufactureFighter(name, attack, defense)); 
                    }
                    else if (command.StartsWith("MachineReport"))
                    {
                        string[] name = command.Split().Skip(1).ToArray();

                        writer.Write(machinesManager.MachineReport(name[0])); 
                    }
                    else if (command.StartsWith("AggressiveMode"))
                    {
                        string[] name = command.Split().Skip(1).ToArray();

                        writer.Write(machinesManager.ToggleFighterAggressiveMode(name[0])); 
                    }
                    else if (command.StartsWith("DefenseMode"))
                    {
                        string[] name = command.Split().Skip(1).ToArray();

                        writer.Write(machinesManager.ToggleTankDefenseMode(name[0])); 
                    }
                    else if (command.StartsWith("Engage"))
                    {
                        string[] info = command.Split();
                        string pilotName = info[1];
                        string machineName = info[2];

                        writer.Write(machinesManager.EngageMachine(pilotName, machineName));
                    }
                    else if (command.StartsWith("Attack"))
                    {
                        string[] info = command.Split();
                        string attackingMachineName = info[1];
                        string defendingMachineName = info[2];

                        writer.Write(machinesManager.AttackMachines(attackingMachineName, defendingMachineName)); 
                    }

                    command = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                writer.Write($"Error:{ex.Message}");
            }
        }
    }
}
