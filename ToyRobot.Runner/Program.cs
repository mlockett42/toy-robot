namespace ToyRobot.Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter a command (type 'exit' to quit):");
            while (true)
            {
                input = ReadLine.Read("> ");
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.WriteLine($"You entered: {input}");
            }
        }
    }
}
