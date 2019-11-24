using MortalEngines.Entities.Contracts;
using System;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        private double healthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, double healthPoints)
            : base(name,attackPoints,defensePoints,healthPoints)
        {
        }

        public bool AggressiveMode { get;  } = true;

        public void ToggleAggressiveMode(string command)
        {
           // if ( command == "false -> true")
           // {
           //    this.AttackPoints += 50;
           //
           //     DefensePoints -= 25;
           //
           //     //AggressiveMode = true;
           // }
           // else if ( command == "true -> false ")
           // {
           //     AttackPoints -= 50;
           //
           //     DefensePoints += 25;
           //
           //    // AggressiveMode = false;
           // }
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
