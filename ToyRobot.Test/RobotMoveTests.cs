using Moq;
using ToyRobot.Library;
using ToyRobot.Library.Exceptions;

namespace ToyRobot.Test
{
    public class RobotMoveTests
    {
        [Theory]
        [InlineData(Direction.NORTH, 2, 1)]
        [InlineData(Direction.WEST, 1, 2)]
        [InlineData(Direction.SOUTH, 2, 3)]
        [InlineData(Direction.EAST, 3, 2)]
        void MoveRobot(Direction direction, int expectedX, int expectedY)
        {
            // Verify moving the robot in the correct direction does the right thing.
            var board = new Board(Mock.Of<IConsoleWriter>());
            board.Place(2, 2, direction);
            board.Move();

            Assert.Equal(expectedX, board.RobotPosition!.X);
            Assert.Equal(expectedY, board.RobotPosition!.Y);
        }

        [Theory]
        [InlineData(2, 0, Direction.NORTH)]
        [InlineData(4, 0, Direction.EAST)]
        [InlineData(2, 4, Direction.SOUTH)]
        [InlineData(0, 2, Direction.WEST)]
        void AttemptToMoveOffBoard(int initialX, int initialY, Direction direction)
        {
            var board = new Board(Mock.Of<IConsoleWriter>());
            board.Place(initialX, initialY, direction);
            // Verify to throws an exception if it would move off board
            Assert.Throws<MoveOffBoardException>(board.Move);

            // Verify the robot did not move
            Assert.Equal(initialX, board.RobotPosition!.X);
            Assert.Equal(initialY, board.RobotPosition!.Y);
            // Verify it still points in the same direction
            Assert.Equal(direction, board.RobotPosition!.Direction);
        }
    }
}
