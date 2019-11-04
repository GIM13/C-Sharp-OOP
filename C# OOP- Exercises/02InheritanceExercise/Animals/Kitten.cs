namespace Animals
{
    public class Kitten : Cat
    {
        const string genderCat = "Female";

        public Kitten(string name, int age)
            : base(name, age, genderCat)
        {
        }

        public override string Sound => "Meow";
    }
}
