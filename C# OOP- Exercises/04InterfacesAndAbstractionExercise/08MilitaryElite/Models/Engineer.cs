using _08MilitaryElite.Contracts;
using _08MilitaryElite.Enums;
using System;
using System.Collections.Generic;

namespace _08MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lasttName, decimal salary, Corps corps, ICollection<IRepair> repairs) 
            : base(id, firstName, lasttName, salary, corps)
        {
            Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get ; }

        public override string ToString()
        {

            string result = base.ToString() +
                Environment.NewLine +
                $"Corps: {Corps}" +
                Environment.NewLine +
                "Repairs:" ;

            if (Repairs.Count > 0)
            {
                result += Environment.NewLine +
                $"  {string.Join(Environment.NewLine + "  ", Repairs)}";
            }

            return result;
        }
    }
}
