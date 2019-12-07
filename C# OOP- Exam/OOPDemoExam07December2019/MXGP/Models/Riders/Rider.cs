using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Riders.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Riders
{
    public class Rider : IRider
    {
        private readonly string name;
        private readonly IMotorcycle motorcycle;
        private readonly int numberOfWins;
        private readonly bool canParticipate = false;

        public Rider(string name)
        {
            Name = name;
        }

        public string Name 
        { 
            get => name; 
            private set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length < 5)
                {
                    throw new ArgumentNullException($"Name {value} cannot be less than 5 symbols.");
                }

                Name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate 
        { 
            get => canParticipate;
            private set
            {
                if (Motorcycle != null)
                {
                   CanParticipate = true;
                }
                else
                {
                    CanParticipate = false;
                }
            }

        }

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            if (motorcycle == null)
            {
                throw new ArgumentNullException("Motorcycle cannot be null.");
            }

            Motorcycle = motorcycle;

            CanParticipate = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}
