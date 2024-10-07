

using ToyRobot.Library.Exceptions;

namespace ToyRobot.Library
{
    public class Board
    {
        public RobotPosition? RobotPosition { get; set; }

        public bool IsIntialised { get; set; }

        public void Left()
        {
            throw new BoardUnitialisedException();
        }

        public void Move()
        {
            throw new BoardUnitialisedException();
        }

        public void Place(int x, int y, Direction direction)
        {
            RobotPosition = new RobotPosition
            {
                X = x,
                Y = y,
                Direction = direction
            };
            IsIntialised = true;
        }

        public void Right()
        {
            throw new BoardUnitialisedException();
        }
    }
}
