using System;

namespace MXGP
{
    using Models.Motorcycles;
    using MXGP.Core;

    public static class StartUp
    {
        public static void Main(string[] args)
        {
            var engin = new Engine();

            engin.Run();

            Motorcycle varche = new PowerMotorcycle("12214235", 75);

            Console.WriteLine(varche.HorsePower);
        }
    }
}
