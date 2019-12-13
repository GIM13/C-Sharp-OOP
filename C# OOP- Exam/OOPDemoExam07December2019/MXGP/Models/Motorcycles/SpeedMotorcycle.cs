using System;

namespace MXGP.Models.Motorcycles
{
    public class SpeedMotorcycle : Motorcycle
    {
        private const double cubicCentimeters = 125;

        public SpeedMotorcycle(string model, int horsePower)
            : base(model, horsePower, cubicCentimeters)
        {
        }
    }
}
