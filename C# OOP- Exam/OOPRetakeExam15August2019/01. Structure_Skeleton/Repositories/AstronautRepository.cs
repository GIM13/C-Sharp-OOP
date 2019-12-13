using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Repositories
{
    public class AstronautRepository<Astronaut> : IRepository<Astronaut>
    {
        private IReadOnlyCollection<Astronaut> models;

        public AstronautRepository()
        {
            Models = new List<Astronaut>();
        }

        public IReadOnlyCollection<Astronaut> Models { get; }

        public void Add(Astronaut model)
        {
            throw new NotImplementedException();
        }

        public Astronaut FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Astronaut model)
        {
            throw new NotImplementedException();
        }
    }
}
