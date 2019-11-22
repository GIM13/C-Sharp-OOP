using CommandPattern.Core.Contracts;

namespace CommandPattern
{
    public class HelloCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string name = args[0];

            string result = $"Hello, {name}";

            return result;
        }
    }
}
