using Moq;
using ToyRobot.Library;
using ToyRobot.Library.Exceptions;

namespace ToyRobot.Test
{
    public class PlaceRobotInInvalidLocationTest
    {
        [Theory]
        [InlineData(-1, 2)]
        [InlineData(5, 2)]
        [InlineData(2, -1)]
        [InlineData(2, 5)]
        void PlaceRobotOnBoardInValidLocation(int initialX, int initialY)
        {
            // Verify placing the robot on the board in an invalid location throws an exception.
            var board = new Board(Mock.Of<IConsoleWriter>());

            Assert.Throws<InvalidBoardLocationException>(() => board.Place(initialX, initialY, Direction.NORTH));

            Assert.Null(board.RobotPosition);
        }
    }
}
