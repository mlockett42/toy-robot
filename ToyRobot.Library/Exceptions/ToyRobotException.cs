namespace ToyRobot.Library.Exceptions
{
    public class ToyRobotException : Exception
    {
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
