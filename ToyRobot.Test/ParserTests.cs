using Moq;
using ToyRobot.Library;
using ToyRobot.Runner;

namespace ToyRobot.Test
{
    public class ParserTests
    {
        [Fact]
        void ParsePlace()
        {
            var mockBoard = new Mock<IBoard>();

            var parser = new Parser(mockBoard.Object, Mock.Of<IConsoleWriter>());

            parser.Parse("PLACE 2,3,NORTH");

            mockBoard.Verify(b => b.Place(
                It.Is<int>(x => x == 2),
                It.Is<int>(y => y == 3),
                It.Is<Direction>(d => d == Direction.NORTH)),
            Times.Once);
        }
    }
}
