using _08MilitaryElite.Contracts;
using System.Collections.Generic;
using System;

namespace _08MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lasttName, decimal salary, Dictionary<int, IPrivate> privates)
            : base(id, firstName, lasttName, salary)
        {
            Privates = privates;
        }

        public Dictionary<int, IPrivate> Privates { get; }

        public override string ToString()
        {
            string result = base.ToString() +
                Environment.NewLine +
                "Privates:";

            if (Privates.Count > 0)
            {
                result += Environment.NewLine +
                $"  {string.Join(Environment.NewLine + "  ", Privates.Values)}";
            }

            return result;
        }
    }
}
