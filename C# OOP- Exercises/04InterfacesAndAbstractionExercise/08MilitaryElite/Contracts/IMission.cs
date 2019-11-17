using _08MilitaryElite.Enums;

namespace _08MilitaryElite.Contracts
{
   public interface IMission
    {
        public string  CodeName { get; }

        public State State { get; }

        public void CompleteMission();
    }
}
