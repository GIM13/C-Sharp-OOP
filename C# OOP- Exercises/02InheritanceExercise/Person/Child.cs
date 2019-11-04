namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base( name, age)
        {
            Name = name;

            if (age >= 0 && age <= 15)
            {
                Age = age;
            }
        }
    }
}
