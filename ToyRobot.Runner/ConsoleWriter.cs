using ToyRobot.Library;

namespace ToyRobot.Runner
{
    public class ConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }
    }
}
