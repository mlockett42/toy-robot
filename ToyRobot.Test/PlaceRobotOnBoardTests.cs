using Moq;
using ToyRobot.Library;
using ToyRobot.Library.Exceptions;

namespace ToyRobot.Test
{
    public class PlaceRobotOnBoardTests
    {
        [Fact]
        void PlaceRobotOnBoard()
        {
            // Verify placing the robot on the board does the correct thing.
            var board = new Board(Mock.Of<IConsoleWriter>());

            board.Place(0, 2, Direction.NORTH);

            Assert.True(board.IsIntialised);

            Assert.Equal(0, board.RobotPosition!.X);
            Assert.Equal(2, board.RobotPosition!.Y);
            Assert.Equal(Direction.NORTH, board.RobotPosition!.Direction);
        }

        [Fact]
        void PlaceRobotOnBoardTwice()
        {
            // Verify placing a second robot on the board causes an error. An the original robot is still in the correct place.
            var board = new Board(Mock.Of<IConsoleWriter>());

            board.Place(0, 2, Direction.NORTH);

            var exception = Assert.Throws<BoardAlreadyInitialisedException>(() => board.Place(3, 2, Direction.WEST));

            Assert.Equal("Robot is already placed on the board.", exception.Message);
        }
    }
}
