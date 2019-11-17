using _08MilitaryElite.Contracts;

namespace _08MilitaryElite.Models
{
    public abstract class Soldier : ISolduer
    {
        protected Soldier(int id, string firstName, string lasttName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lasttName;
        }

        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }
}
