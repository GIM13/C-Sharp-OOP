using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    internal class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputArgs = args.Split("",StringSplitOptions.RemoveEmptyEntries);

            string command = inputArgs[0] + "Command";

            string[] commandArgs = inputArgs.Skip(1).ToArray();

            var commandType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x .Name == command);

            if (commandType == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            var instance = Activator.CreateInstance(commandType);

            string result = ((ICommand)instance).Execute(commandArgs);

            return result;
        }
    }
}