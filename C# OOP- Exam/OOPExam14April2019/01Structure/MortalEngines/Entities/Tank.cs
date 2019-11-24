using MortalEngines.Entities.Contracts;
using System;

namespace MortalEngines.Entities
{
    public class Tank : BaseMachine, ITank
    {
        private double healthPoints = 100;

        public Tank(string name, double attackPoints, double defensePoints, double healthPoints)
            : base(name, attackPoints, defensePoints, healthPoints)
        {
        }

        public bool DefenseMode { get; } = true;

        public void ToggleDefenseMode(string command)
        {
           // if (command == "false -> true")
           // {
           //     AttackPoints -= 40;
           //
           //     DefensePoints += 30;
           //
           //    // DefenseMode = true;
           // }
           // else if (command == "true -> false ")
           // {
           //     AttackPoints += 40;
           //
           //     DefensePoints -= 30;
           //
           //    // DefenseMode = false;
           // }
        }

        public override string ToString()
        {
            string result;

            if (DefenseMode == true)
            {
                result = "ON";
            }
            else
            {
                result = "OFF";
            }

            return base.ToString() + Environment.NewLine +
                   $" *Defense: {result}";
        }
    }
}
