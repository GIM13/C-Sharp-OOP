namespace _03WildFarm.Animal.Bird
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
        {
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }

        public double WeightGainOverFood { get; set; } = 0.35;

        public override string Sound()
        {
            return "Cluck";
        }
    }
}
