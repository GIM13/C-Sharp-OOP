using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Riders.Contracts;
using System;

namespace MXGP.Models.Riders
{
    public class Rider : IRider
    {
        private string name;
        private bool canParticipate = false;

        public Rider(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentNullException($"Name {value} cannot be less than 5 symbols.");
                }

                name = value;
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
                    canParticipate = true;
                }
                else
                {
                    canParticipate = false;
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
