using System.Collections.Generic;

namespace _08MilitaryElite.Contracts
{
    public interface IComando : ISpecialisedSoldier
    {
        public ICollection<IMission> Missions { get; }
    }
}
