using System.Collections.Generic;

namespace _08MilitaryElite.Contracts
{
    public interface IEngineer :ISpecialisedSoldier
    {
        public ICollection<IRepair> Repairs { get; }
    }
}
