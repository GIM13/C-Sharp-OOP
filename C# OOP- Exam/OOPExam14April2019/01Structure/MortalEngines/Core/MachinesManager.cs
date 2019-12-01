namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Entities;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<Pilot> pilots = new List<Pilot>();
        private List<BaseMachine> machines = new List<BaseMachine>();

        public string HirePilot(string name)
        {
            if (pilots.Contains(pilots.FirstOrDefault(x => x.Name == name)))
            {
                return $"Pilot {name} is hired already";
            }
            else
            {
                pilots.Add(new Pilot(name));

                return $"Pilot {name} hired";
            }
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (machines.Contains(machines.FirstOrDefault(x => x.Name == name)))
            {
                return $"Machine {name} is manufactured already";
            }
            else
            {
                double healthPoints = 100;

                machines.Add(new Tank(name, attackPoints, defensePoints, healthPoints));

                return $"Tank {name} manufactured - attack: {attackPoints}; defense: {defensePoints}";
            }
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (machines.Contains(machines.FirstOrDefault(x => x.Name == name)))
            {
                return $"Machine {name} is manufactured already";
            }
            else
            {
                double healthPoints = 200;

                machines.Add(new Fighter(name, attackPoints, defensePoints, healthPoints));

                return $"Fighter {name} manufactured - attack: {attackPoints}; defense: {defensePoints}; aggressive: ON";
            }
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            throw new System.NotImplementedException();
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            throw new System.NotImplementedException();
        }

        public string PilotReport(string pilotReporting)
        {
            return pilots.FirstOrDefault(x => x.Name == pilotReporting).Report();

        }

        public string MachineReport(string machineName)
        {
            return machines.FirstOrDefault(x => x.Name == machineName).ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (machines.Contains(machines.FirstOrDefault(x => x.Name == fighterName)))
            {
                (machines.FirstOrDefault(x => x.Name == fighterName) as Fighter)
                    .AggressiveMode =
                         !(machines.FirstOrDefault(x => x.Name == fighterName) as Fighter)
                          .AggressiveMode;

                return $"Fighter {fighterName} toggled aggressive mode";

            }
            else
            {
                return $"Machine {fighterName} could not be found";
            }
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (machines.Contains(machines.FirstOrDefault(x => x.Name == tankName)))
            {
                (machines.FirstOrDefault(x => x.Name == tankName) as Tank)
                    .DefenseMode = 
                         !(machines.FirstOrDefault(x => x.Name == tankName) as Tank)
                          .DefenseMode;

                return $"Tank {tankName} toggled defense mode";

            }
            else
            {
                return $"Machine {tankName} could not be found";
            }
        }
    }
}