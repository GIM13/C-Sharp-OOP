namespace Animals
{
    public class Tomcat : Cat
    {
        const string genderCat = "Male";

        public Tomcat(string name, int age)
            : base(name, age, genderCat)
        {
        }

        public override string Sound => "MEOW";
    }
}
