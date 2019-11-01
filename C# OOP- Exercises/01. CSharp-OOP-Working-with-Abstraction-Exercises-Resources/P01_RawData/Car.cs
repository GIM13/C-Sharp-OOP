namespace P01_RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, TireSet tireSet)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            TireSet = tireSet;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public TireSet TireSet { get; set; }
    }
}
