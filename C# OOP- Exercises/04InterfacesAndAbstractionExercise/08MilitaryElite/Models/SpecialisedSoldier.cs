using _08MilitaryElite.Contracts;
using _08MilitaryElite.Enums;

namespace _08MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lasttName, decimal salary, Corps corps) 
            : base(id, firstName, lasttName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; }
    }
}
