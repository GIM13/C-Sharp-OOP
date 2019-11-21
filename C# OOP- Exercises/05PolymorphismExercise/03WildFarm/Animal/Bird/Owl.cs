namespace _03WildFarm.Animal.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, double weight,  double wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }

        public double WeightGainOverFood { get; set; } = 0.25;

        public override string Sound()
        {
            return "Hoot Hoot";
        }
    }
}
