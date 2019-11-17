namespace _03Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            Driver = driver;
            Model = "488-Spider";
        }

        public string Model { get ; private set ; }

        public string Driver { get; set; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{Model}/{Brakes()}/{Gas()}/{Driver}";
        }
    }
}
