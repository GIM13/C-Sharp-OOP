namespace _05BorderControl
{
    public class Citizen : ISubjects
    {
        public Citizen(string name, int age, long id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public long Id { get ; }
    }
}
