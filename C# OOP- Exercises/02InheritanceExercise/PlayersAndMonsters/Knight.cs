namespace PlayersAndMonsters
{
    public class Knight : Hero
    {
        public Knight(string name, int level) : base(name, level)
        {
            Username = name;
            Level = level;
        }
    }
}
