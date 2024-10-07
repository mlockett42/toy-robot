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

        [Fact]
        void ParseLeft()
        {
            var mockBoard = new Mock<IBoard>();

            var parser = new Parser(mockBoard.Object, Mock.Of<IConsoleWriter>());

            parser.Parse("LEFT");

            mockBoard.Verify(b => b.Left(), Times.Once);
        }

        [Fact]
        void ParseRight()
        {
            var mockBoard = new Mock<IBoard>();

            var parser = new Parser(mockBoard.Object, Mock.Of<IConsoleWriter>());

            parser.Parse("RIGHT");

            mockBoard.Verify(b => b.Right(), Times.Once);
        }

        [Fact]
        void ParseMove()
        {
            var mockBoard = new Mock<IBoard>();

            var parser = new Parser(mockBoard.Object, Mock.Of<IConsoleWriter>());

            parser.Parse("MOVE");

            mockBoard.Verify(b => b.Move(), Times.Once);
        }

        [Fact]
        void ParseReport()
        {
            var mockBoard = new Mock<IBoard>();

            var parser = new Parser(mockBoard.Object, Mock.Of<IConsoleWriter>());

            parser.Parse("REPORT");

            mockBoard.Verify(b => b.Report(), Times.Once);
        }

        [Fact]
        void ParserInvalidCommand()
        {
            var mockConsoleWriter = new Mock<IConsoleWriter>();

            var parser = new Parser(Mock.Of<IBoard>(), mockConsoleWriter.Object);

            parser.Parse("STUFF");

            mockConsoleWriter.Verify(b => b.WriteLine(It.Is<string>(s => s == "Unknown command STUFF")), Times.Once);
        }
    }
}
