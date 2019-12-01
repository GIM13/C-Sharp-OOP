using MortalEngines.Entities.Contracts;
using System;

namespace MortalEngines.Entities
{
    public class Tank : BaseMachine, ITank
    {
        private double healthPoints ;
        private double attackPoints ;
        private double defensePoints;
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints, double healthPoints)
            : base(name, attackPoints, defensePoints, healthPoints)
        {
        }

        public bool DefenseMode { get; set; } = true;

        public void ToggleDefenseMode(string command)
        {
            if (command == "false -> true")
            {
                attackPoints -= 40;

                defensePoints += 30;

                defenseMode = true;
            }
            else if (command == "true -> false ")
            {
                attackPoints += 40;

                defensePoints -= 30;

                defenseMode = false;
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
