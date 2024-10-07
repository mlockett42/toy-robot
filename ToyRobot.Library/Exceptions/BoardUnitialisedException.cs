namespace ToyRobot.Library.Exceptions
{
    public class BoardUnitialisedException : ToyRobotException
    {
        // Thrown when an operation requires the board to be initialised
        public BoardUnitialisedException() : base("Board must by initialised first.")
        {
        }
    }
}
