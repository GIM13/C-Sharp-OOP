namespace _05BorderControl
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public int Food { get; private set; }

        public string Name { get;  }

        public int Age { get;  }

        public string Group { get; }

        public void BuyFood()
        {
             Food += 5;
        }
    }
}
