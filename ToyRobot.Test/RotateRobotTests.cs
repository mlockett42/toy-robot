using ToyRobot.Library;

namespace ToyRobot.Test
{
    public class RotateRobotTests
    {
        [Theory]
        [InlineData(Direction.NORTH, Direction.WEST)]
        [InlineData(Direction.WEST, Direction.SOUTH)]
        [InlineData(Direction.SOUTH, Direction.EAST)]
        [InlineData(Direction.EAST, Direction.NORTH)]
        public void LeftRotatePointsInTheCorrectDirection(Direction initDirection, Direction finalDirection)
        {
            // Verify rotating to the left does the correct thing.
            var board = new Board();
            board.Place(2, 2, initDirection);

            board.Left();

            Assert.Equal(finalDirection, board.RobotPosition!.Direction);
        }

        [Theory]
        [InlineData(Direction.NORTH, Direction.EAST)]
        [InlineData(Direction.WEST, Direction.NORTH)]
        [InlineData(Direction.SOUTH, Direction.WEST)]
        [InlineData(Direction.EAST, Direction.SOUTH)]
        public void RightRotatePointsInTheCorrectDirection(Direction initDirection, Direction finalDirection)
        {
            // Verify rotating to the right does the correct thing.
            var board = new Board();
            board.Place(2, 2, initDirection);

            board.Right();

            Assert.Equal(finalDirection, board.RobotPosition!.Direction);
        }
    }
}
