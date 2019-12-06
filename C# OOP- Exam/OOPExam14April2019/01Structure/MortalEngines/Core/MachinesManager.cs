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
        private Dictionary<BaseMachine, Pilot> pilotMachine = new Dictionary<BaseMachine, Pilot>();

        public List<Pilot> Pilots { get => pilots; set => pilots = value; }

        public List<BaseMachine> Machines { get => machines; set => machines = value; }

        public Dictionary<BaseMachine, Pilot> PilotMachine { get => pilotMachine; set => pilotMachine = value; }

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

                var tank = new Tank(name, attackPoints, defensePoints, healthPoints);

                machines.Add(tank);

                return $"Tank {name} manufactured - attack: {tank.AttackPoints:f2}; defense: {tank.DefensePoints:f2}";
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

                var fighter = new Fighter(name, attackPoints, defensePoints, healthPoints);

                machines.Add(fighter);

                return $"Fighter {name} manufactured - attack: {fighter.AttackPoints:f2}; defense: {fighter.DefensePoints:f2}; aggressive: ON";
            }
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!pilots.Contains(pilots.FirstOrDefault(x => x.Name == selectedPilotName)))
            {
                return $"Pilot {selectedPilotName} could not be found";
            }
            else if (!machines.Contains(machines.FirstOrDefault(x => x.Name == selectedMachineName)))
            {
                return $"Machine {selectedMachineName} could not be found";
            }
            else if (pilotMachine.ContainsKey(machines.FirstOrDefault(x => x.Name == selectedMachineName)))
            {
                return $"Machine {selectedMachineName} is already occupied";
            }
            else 
            {
                pilotMachine.Add(machines.FirstOrDefault(x => x.Name == selectedMachineName), pilots.FirstOrDefault(x => x.Name == selectedPilotName));

                return $"Pilot {selectedPilotName} engaged machine {selectedMachineName}";
            }
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            BaseMachine attackingMachine = machines
                .FirstOrDefault(x => x.Name == attackingMachineName);
            BaseMachine defendingMachine = machines
                .FirstOrDefault(x => x.Name == defendingMachineName);

            if (!pilotMachine.ContainsKey(attackingMachine))
            {
                return $"Machine {attackingMachineName} could not be found";
            }
            else if (!pilotMachine.ContainsKey(defendingMachine))
            {
                return $"Machine {defendingMachineName} could not be found";
            }
            else if (attackingMachine.HealthPoints <= 0)
            {
                return $"Dead machine {attackingMachineName} cannot attack or be attacked";
            }
            else if (defendingMachine.HealthPoints <= 0)
            {
                return $"Dead machine {defendingMachineName} cannot attack or be attacked";
            }
            else
            {
                attackingMachine.Attack(defendingMachine);

                return $"Machine {defendingMachineName} was attacked by machine {attackingMachineName} - current health: {defendingMachine.HealthPoints:f2}";
            }
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