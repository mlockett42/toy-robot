namespace ToyRobot.Library.Exceptions
{
    public class MoveOffBoardException : ToyRobotException
    {
        // Thrown if a command would cause the robot to move off the board
        public MoveOffBoardException() : base("Move off board must by initialised first.")
        {
        }
    }
}
