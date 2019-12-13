using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private readonly string name;
        private readonly double oxygen;
        private readonly bool canBreath;
        private readonly IBag bag;

        public Astronaut(string name, double oxygen)
        {
            Name = name;
            Oxygen = oxygen;
        }

        public string Name { get; }

        public double Oxygen { get; }

        public bool CanBreath { get; }

        public IBag Bag { get; }

        public void Breath()
        {
            throw new NotImplementedException();
        }
    }
}
