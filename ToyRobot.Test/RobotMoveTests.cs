using ToyRobot.Library;

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
            var board = new Board();
            board.Place(2, 2, direction);
            board.Move();

            Assert.Equal(expectedX, board.RobotPosition!.X);
            Assert.Equal(expectedY, board.RobotPosition!.Y);
        }
    }
}
