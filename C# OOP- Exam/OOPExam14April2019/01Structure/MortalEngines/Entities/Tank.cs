using MortalEngines.Entities.Contracts;
using System;

namespace MortalEngines.Entities
{
    public class Tank : BaseMachine, ITank
    {
        public Tank(string name, double attackPoints, double defensePoints, double healthPoints)
            : base(name, attackPoints, defensePoints, healthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; set; } = true;

        public void ToggleDefenseMode()
        {
            if (DefenseMode == true)
            {
                AttackPoints -= 40;

                DefensePoints += 30;

                DefenseMode = true;
            }
            else if (DefenseMode == false)
            {
                AttackPoints += 40;

                DefensePoints -= 30;

                DefenseMode = false;
            }
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
