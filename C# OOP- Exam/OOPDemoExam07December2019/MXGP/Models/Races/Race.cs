using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MXGP.Models.Races
{
    public class Race : IRace
    {
        private string name;
        private int laps;

        public Race(string name, int laps)
        {
            Name = name;
            Laps = laps;
            Riders = new List<IRider>();
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

                name = value;
            }
        }

        public int Laps
        {
            get => laps;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException($"Laps cannot be less than 1.");
                }

                laps = value;
            }
        }

        public List<IRider> Riders { get; }

        public void AddRider(IRider rider)
        {
            if (rider == null)
            {
                throw new ArgumentNullException("Rider cannot be null.");
            }
            else if (!rider.CanParticipate)
            {
                throw new ArgumentException($"Rider {rider.Name} could not participate in race.");
            }
            else if (Riders.Contains(rider))
            {
                throw new ArgumentNullException($"Rider {rider.Name} is already added in {this.Name} race.");
            }

            Riders.Add(rider);
        }
    }
}
