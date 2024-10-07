namespace ToyRobot.Library.Exceptions
{
    public class BoardAlreadyInitialisedException : ToyRobotException
    {
        public BoardAlreadyInitialisedException()
        {
        }

        public BoardAlreadyInitialisedException(string message) : base(message)
        {
        }

        public BoardAlreadyInitialisedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
