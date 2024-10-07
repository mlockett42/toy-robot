namespace ToyRobot.Library.Exceptions
{
    public class ToyRobotException : Exception
    {
        // A base exception for the ToyRobot program, so we can wasily catch our internally generated exceptions
        public ToyRobotException()
        {
        }

        public ToyRobotException(string message) : base(message)
        {
        }

        public ToyRobotException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
