using ToyRobot.Library;

namespace ToyRobot.Test
{
    public class PlaceRobotOnBoardTests
    {
        [Fact]
        void PlaceRobotOnBoard()
        {
            var board = new Board();

            board.Place(0, 2, Direction.NORTH);

            Assert.True(board.IsIntialised);

            Assert.Equal(0, board.RobotPosition!.X);
            Assert.Equal(2, board.RobotPosition!.Y);
            Assert.Equal(Direction.NORTH, board.RobotPosition!.Direction);
        }
    }
}
