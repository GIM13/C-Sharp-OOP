using System;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double cubicCentimeters = 450;
        private int horsePower;

        public PowerMotorcycle(string model, int horsePower)
            : base(model, horsePower, cubicCentimeters)
        {
        }
    }
}
