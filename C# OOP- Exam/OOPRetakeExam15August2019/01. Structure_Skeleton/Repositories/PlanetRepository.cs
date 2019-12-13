using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace SpaceStation.Repositories
{
    public class PlanetRepository<Planet> : IRepository<Planet>
    {
        private readonly IReadOnlyCollection<Planet> models;

        public PlanetRepository()
        {
            Models = new List<Planet>();
        }

        public IReadOnlyCollection<Planet> Models { get; }

        public void Add(Planet model)
        {
            throw new NotImplementedException();
        }

        public Planet FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Planet model)
        {
            throw new NotImplementedException();
        }
    }
}
