namespace ToyRobot.Library.Exceptions
{
    public class MoveOffBoardException : ToyRobotException
    {
        public MoveOffBoardException() : base("Move off board must by initialised first.")
        {
        }
    }
}
