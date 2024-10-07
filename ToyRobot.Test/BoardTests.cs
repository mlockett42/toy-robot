using ToyRobot.Library;

namespace ToyRobot.Test
{
    public class BoardTests
    {
        [Fact]
        void BoardIsUnitialisedByDefault()
        {
            var board = new Board();
            Assert.False(board.IsIntialised());
        }
    }
}
