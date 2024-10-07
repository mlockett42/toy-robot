

using ToyRobot.Library.Exceptions;

namespace ToyRobot.Library
{
    public class Board
    {
        private readonly IConsoleWriter _consoleWriter;

        public Board(IConsoleWriter consoleWriter)
        {
            _consoleWriter = consoleWriter;
        }
        // Represents the board and all the operations we can do on it.
        // Because there can only be one robot on the board and the board is a fixed size the state of the board is just the position of the robot.
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
            ValidateMove();
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

        private void ValidateMove()
        {
            if (!IsIntialised)
            {
                throw new BoardUnitialisedException();
            }
            switch (RobotPosition!.Direction)
            {
                case Direction.NORTH:
                    if (RobotPosition!.Y <= 0)
                    {
                        throw new MoveOffBoardException();
                    }
                    break;
                case Direction.EAST:
                    if (RobotPosition!.X >= 4)
                    {
                        throw new MoveOffBoardException();
                    }
                    break;
                case Direction.SOUTH:
                    if (RobotPosition!.Y >= 4)
                    {
                        throw new MoveOffBoardException();
                    }
                    break;
                case Direction.WEST:
                    if (RobotPosition!.X <= 0)
                    {
                        throw new MoveOffBoardException();
                    }
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
            if (x < 0 || x > 4 || y < 0 || y > 4)
            {
                throw new InvalidBoardLocationException();
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
            // Right means left (check the spec)
            Left();
        }

        public void Report()
        {
            if (!IsIntialised)
            {
                _consoleWriter.WriteLine("Not initialised.");
                return;
            }
            _consoleWriter.WriteLine($"{RobotPosition!.X},{RobotPosition!.Y},{RobotPosition!.Direction}");
        }
    }
}
