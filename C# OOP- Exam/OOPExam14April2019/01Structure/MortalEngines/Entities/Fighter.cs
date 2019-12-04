using MortalEngines.Entities.Contracts;
using System;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        public Fighter(string name, double attackPoints, double defensePoints, double healthPoints)
            : base(name,attackPoints,defensePoints,healthPoints)
        {
            this.ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; set; } = true;

        public void ToggleAggressiveMode()
        {
            if (AggressiveMode == true)
            {
                AttackPoints += 50;

                DefensePoints -= 25;

                AggressiveMode = true;
            }
            else if (AggressiveMode == false)
            {
                AttackPoints -= 50;

                DefensePoints += 25;

                AggressiveMode = false;
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
