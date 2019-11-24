using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;

namespace MortalEngines.Entities
{
    public abstract class BaseMachine : IMachine
    {
        private IPilot pilot;
        private string name;

        public BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            Name = name;
            AttackPoints = attackPoints;
            DefensePoints = defensePoints;
            HealthPoints = healthPoints;
        }

        public string Name { get; }

        public double AttackPoints { get; }

        public double DefensePoints { get; }

        public double HealthPoints { get;  set; }

        public IPilot Pilot
        {
            get => pilot;
            set
            {
                pilot = value ?? throw new NullReferenceException("Pilot cannot be null.");
            }
        }

        public IList<string> Targets { get; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException("Target cannot be null");
            }

            target.HealthPoints -= AttackPoints - target.DefensePoints;

            if (target.HealthPoints < 0)
            {
                target.HealthPoints = 0;
            }

            Targets.Add(target.Name);
        }

        public override string ToString()
        {
            var result = $"- {Name}" + Environment.NewLine +
                         $" *Type: { this.GetType()}" + Environment.NewLine +
                         $" *Health: {HealthPoints}" + Environment.NewLine +
                         $" *Attack: {AttackPoints}" + Environment.NewLine +
                         $" *Defense: {DefensePoints}" + Environment.NewLine +
                         $" *Targets: ";

            if (Targets.Count == 0)
            {
                result += "None";
            }
            else
            {
                result += string.Join(",", Targets);
            }

            return result;
        }
    }
}
