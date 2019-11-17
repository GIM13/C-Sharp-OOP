using _08MilitaryElite.Core;

namespace _08MilitaryElite
{
    class Startup
    {
        static void Main()
        {
            var command = new CommandInterpreter();

            var engine = new Engine(command);

            engine.Start();
        }
    }
}
