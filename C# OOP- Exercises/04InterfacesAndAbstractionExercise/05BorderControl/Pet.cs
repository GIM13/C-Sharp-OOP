namespace _05BorderControl
{
    public class Pet : IAnimal
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get ;  }

        public string Birthdate { get ;  }
    }
}
