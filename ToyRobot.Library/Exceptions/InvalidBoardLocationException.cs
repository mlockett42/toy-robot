namespace ToyRobot.Library.Exceptions
{
    public class InvalidBoardLocationException : ToyRobotException
    {
        // Thrown if a commandplace the robot in an invalid (i.e. off board location)
        public InvalidBoardLocationException() : base("Invalid board location.")
        {
        }
    }
}
