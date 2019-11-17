using _08MilitaryElite.Enums;

namespace _08MilitaryElite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corps { get;  }
    }
}
