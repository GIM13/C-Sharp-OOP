using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;

        public Planet(string name)
        {
            Name = name;
            Items = new List<string>();
        }

        public ICollection<string> Items { get; }

        public string Name
        {
            get => this.name;
            private set
            {

            }
        }
    }
}
