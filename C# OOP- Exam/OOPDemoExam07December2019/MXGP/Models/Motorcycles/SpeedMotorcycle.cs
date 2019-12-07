using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const double cubicCentimeters = 125;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, cubicCentimeters)
        {
        }

        new public int HorsePower
        {
            get => HorsePower;
            private  set
            {
                if (value < 50 && 69 < value)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                HorsePower = value;
            }
        }
    }
}
