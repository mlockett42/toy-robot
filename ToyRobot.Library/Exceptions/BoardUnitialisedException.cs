namespace ToyRobot.Library.Exceptions
{
    public class BoardUnitialisedException : ToyRobotException
    {
        public BoardUnitialisedException() : base("Board must by initialised first.")
        {
        }
    }
}
