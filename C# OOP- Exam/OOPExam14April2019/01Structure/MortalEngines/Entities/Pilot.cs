using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;

namespace MortalEngines.Entities
{
    public class Pilot : IPilot
    {
        private readonly string name;

        public Pilot(string name)
        {
            Name = name;
        }

        public List<IMachine> Machines { get; set; }

        public string Name { get; }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException("Null machine cannot be added to the pilot.");
            }

            Machines.Add(machine);
        }

        public string Report()
        {
            return $"{name} - {Machines.Count} machines" + Environment.NewLine +
                   $"{string.Join(Environment.NewLine, Machines)}";
        }
    }
}
