using _08MilitaryElite.Contracts;
using System;

namespace _08MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lasttName, int codeNumber)
            : base(id, firstName, lasttName)
        {
             CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            return base.ToString() +
                   Environment.NewLine +
                   $"Code Number: {CodeNumber}";
        }
    }
}
