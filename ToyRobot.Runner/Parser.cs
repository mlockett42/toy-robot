using CommandLine;
using ToyRobot.Library;

namespace ToyRobot.Runner
{
    public class PlaceOptions
    {
        [Value(0, MetaName = "X", Required = true, HelpText = "The X coordinate.")]
        public int X { get; set; }

        [Value(1, MetaName = "Y", Required = true, HelpText = "The Y coordinate.")]
        public int Y { get; set; }

        [Value(2, MetaName = "F", Required = true, HelpText = "The direction (North, East, South, West).")]
        public Direction F { get; set; }
    }

    public class Parser
    {
        private readonly IBoard _board;
        private readonly IConsoleWriter _consoleWriter;
        public Parser(IBoard board, IConsoleWriter consoleWriter)
        {
            _board = board;
            _consoleWriter = consoleWriter;
        }

        public void Parse(string command)
        {
            var upperCaseCommand = command.ToUpper();
            if (upperCaseCommand.StartsWith("PLACE "))
            {
                var commandArgsString = upperCaseCommand.Substring(6);
                var commandArgs = commandArgsString.Split(',');

                // Trim any whitespace around the split parts
                commandArgs = Array.ConvertAll(commandArgs, arg => arg.Trim());

                // Parse the arguments
                CommandLine.Parser.Default.ParseArguments<PlaceOptions>(commandArgs)
                    .WithParsed(ExecutePlaceCommand)
                    .WithNotParsed(HandleParseError);
            }
            var upperCaseCommandTrimmed = upperCaseCommand.Trim();
            if (upperCaseCommandTrimmed == "LEFT")
            {
                _board.Left();
            }
            if (upperCaseCommandTrimmed == "RIGHT")
            {
                _board.Right();
            }
            if (upperCaseCommandTrimmed == "MOVE")
            {
                _board.Move();
            }
            if (upperCaseCommandTrimmed == "REPORT")
            {
                _board.Report();
            }
        }

        private void ExecutePlaceCommand(PlaceOptions options)
        {
            _board.Place(options.X, options.Y, options.F);
        }

        private void HandleParseError(IEnumerable<Error> errors)
        {
            // Handle errors (e.g., display help)
            foreach (var error in errors)
            {
                _consoleWriter.WriteLine(error.ToString() ?? "");
            }
        }
    }
}
