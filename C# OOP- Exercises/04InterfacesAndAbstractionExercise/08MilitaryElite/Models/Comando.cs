using _08MilitaryElite.Contracts;
using _08MilitaryElite.Enums;
using System;
using System.Collections.Generic;

namespace _08MilitaryElite.Models
{
    public class Comando : SpecialisedSoldier, IComando
    {
        public Comando(int id, string firstName, string lasttName, decimal salary, Corps corps, ICollection<IMission> missions)
            : base(id, firstName, lasttName, salary, corps)
        {
            Missions = missions;
        }

        public ICollection<IMission> Missions { get; }

        public override string ToString()
        {
            string result = base.ToString() +
                Environment.NewLine +
                $"Corps: {Corps}" +
                Environment.NewLine +
                "Missions:";

            if (Missions.Count > 0)
            {
                result += Environment.NewLine +
                $"  {string.Join(Environment.NewLine + "  ", Missions)}";
            }

            return result;
        }
    }
}
