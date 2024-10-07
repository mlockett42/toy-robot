using ToyRobot.Library.Exceptions;

namespace ToyRobot.Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            var container = new ToyRobotContainer();
            var parser = container.Resolve();
            Console.WriteLine("Enter a command (type 'exit' to quit):");
            while (true)
            {
                input = ReadLine.Read("> ");
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                try
                {
                    parser.Value.Parse(input);
                }
                catch (ToyRobotException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
