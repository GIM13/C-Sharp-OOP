using MXGP.Models.Motorcycles.Contracts;
using System;

namespace MXGP.Models.Motorcycles
{
    public abstract class Motorcycle : IMotorcycle
    {
        private string model;
        private readonly int horsePower;
        private readonly double cubicCentimeters;

        public Motorcycle(string model, int horsePower, double cubicCentimeters)
        {
            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length < 4)
                {
                    throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                }

                model = value;
            }
        }

        public int HorsePower { get; }

        public double CubicCentimeters { get; }

        public double CalculateRacePoints(int laps)
        {
            var result = cubicCentimeters / horsePower * laps;

            return result;
        }
    }
}
