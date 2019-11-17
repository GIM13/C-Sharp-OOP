using _08MilitaryElite.Contracts;
using System;

namespace _08MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {Math.Round(Salary,2):f2}";
        }
    }
}
