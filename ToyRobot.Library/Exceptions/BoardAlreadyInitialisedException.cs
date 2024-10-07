namespace ToyRobot.Library.Exceptions
{
    public class BoardAlreadyInitialisedException : ToyRobotException
    // Thrown if we try to initialise the board more than more
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
