using Moq;
using ToyRobot.Library;
using ToyRobot.Library.Exceptions;

namespace ToyRobot.Test
{
    public class UninitialisedBoardTests
    // Test uninitialised board is handled correctly
    {
        [Fact]
        void BoardIsUnitialisedByDefault()
        {
            var board = new Board(Mock.Of<IConsoleWriter>());
            Assert.False(board.IsIntialised);
        }

        [Fact]
        void MoveRequiresInitialisation()
        {
            var board = new Board(Mock.Of<IConsoleWriter>());
            Assert.Throws<BoardUnitialisedException>(board.Move);
        }

        [Fact]
        void LeftRequiresInitialisation()
        {
            var board = new Board(Mock.Of<IConsoleWriter>());
            Assert.Throws<BoardUnitialisedException>(board.Left);
        }

        [Fact]
        void RightRequiresInitialisation()
        {
            var board = new Board(Mock.Of<IConsoleWriter>());
            Assert.Throws<BoardUnitialisedException>(board.Right);
        }
    }
}
