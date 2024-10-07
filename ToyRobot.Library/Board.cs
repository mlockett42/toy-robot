

using ToyRobot.Library.Exceptions;

namespace ToyRobot.Library
{
    public class Board
    {
        public RobotPosition? RobotPosition { get; set; }

        public bool IsIntialised { get; set; }

        public void Left()
        {
            if (!IsIntialised)
            {
                throw new BoardUnitialisedException();
            }
            RobotPosition!.Direction = RobotPosition.Direction switch
            {
                Direction.NORTH => Direction.WEST,
                Direction.EAST => Direction.NORTH,
                Direction.SOUTH => Direction.EAST,
                Direction.WEST => Direction.SOUTH,
                _ => throw new InvalidOperationException($"Not expected robot direction value: {RobotPosition.Direction}"),
            };
        }

        public void Move()
        {
            if (!IsIntialised)
            {
                throw new BoardUnitialisedException();
            }
            switch (RobotPosition!.Direction)
            {
                case Direction.NORTH:
                    RobotPosition!.Y -= 1;
                    break;
                case Direction.EAST:
                    RobotPosition!.X += 1;
                    break;
                case Direction.SOUTH:
                    RobotPosition!.Y += 1;
                    break;
                case Direction.WEST:
                    RobotPosition!.X -= 1;
                    break;
                default:
                    throw new InvalidOperationException($"Unexpected robot direction value: {RobotPosition.Direction}");
            }
        }

        public void Place(int x, int y, Direction direction)
        {
            if (IsIntialised)
            {
                throw new BoardAlreadyInitialisedException("Robot is already placed on the board.");
            }

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
            if (!IsIntialised)
            {
                throw new BoardUnitialisedException();
            }
            RobotPosition!.Direction = RobotPosition.Direction switch
            {
                Direction.NORTH => Direction.EAST,
                Direction.EAST => Direction.SOUTH,
                Direction.SOUTH => Direction.WEST,
                Direction.WEST => Direction.NORTH,
                _ => throw new InvalidOperationException($"Unexpected robot direction value: {RobotPosition.Direction}"),
            };
        }
    }
}
