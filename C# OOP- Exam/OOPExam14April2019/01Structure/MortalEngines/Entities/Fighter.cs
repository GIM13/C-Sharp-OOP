using MortalEngines.Entities.Contracts;
using System;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        private double healthPoints = 200;
        private double attackPoints;
        private double defensePoints;
        private bool aggressiveMode;

        public Fighter(string name, double attackPoints, double defensePoints, double healthPoints)
            : base(name,attackPoints,defensePoints,healthPoints)
        {
        }

        public bool AggressiveMode { get; set; } = true;

        public void ToggleAggressiveMode(string command)
        {
            if (command == "false -> true")
            {
                attackPoints += 50;

                defensePoints -= 25;

                aggressiveMode = true;
            }
            else if (command == "true -> false ")
            {
                attackPoints -= 50;

                defensePoints += 25;

                aggressiveMode = false;
            }
        }

        public override string ToString()
        {
            string result;

            if (AggressiveMode == true)
            {
                result = "ON";
            }
            else
            {
                result = "OFF";
            }

            return base.ToString() + Environment.NewLine +
                   $" *Aggressive: {result}";
        }
    }
}
