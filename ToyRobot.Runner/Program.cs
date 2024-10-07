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

                //Console.WriteLine($"You entered: {input}");
                parser.Value.Parse(input);
            }
        }
    }
}
