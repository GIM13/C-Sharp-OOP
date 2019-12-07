using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double cubicCentimeters = 450;

        public PowerMotorcycle(string model, int horsePower)
            : base(model, horsePower, cubicCentimeters)
        {
        }

        new public int HorsePower
        {
            get => HorsePower;
            private set
            {
                if (value < 70 && 100 < value)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                HorsePower = value;
            }
        }
    }
}
