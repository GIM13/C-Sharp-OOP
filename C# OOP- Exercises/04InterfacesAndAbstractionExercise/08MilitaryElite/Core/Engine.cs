using System;
using System.Linq;

namespace _08MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Start()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] inputInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string result = commandInterpreter.Read(inputInfo);

                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                }

                input = Console.ReadLine();
            }
        }
    }
}
