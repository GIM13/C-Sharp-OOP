namespace PlayersAndMonsters
{
    public class DarkKnight : Knight
    {
        public DarkKnight(string name, int level) : base(name, level)
        {
            Username = name;
            Level = level;
        }
    }
}
