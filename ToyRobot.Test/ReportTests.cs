using Moq;
using ToyRobot.Library;

namespace ToyRobot.Test
{
    public class ReportTests
    {
        [Fact]
        public void ReportStateOfUninitialisedBoard()
        {
            var mockConsoleWriter = new Mock<IConsoleWriter>();

            var board = new Board(mockConsoleWriter.Object);
            mockConsoleWriter.Verify(cw => cw.WriteLine(It.IsAny<string>()), Times.Never);

            board.Report();
            mockConsoleWriter.Verify(cw => cw.WriteLine(It.Is<string>(s => s == "Not initialised.")), Times.Once);
            mockConsoleWriter.Verify(cw => cw.WriteLine(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void ReportStateOfInitialisedBoard()
        {
            var mockConsoleWriter = new Mock<IConsoleWriter>();

            var board = new Board(mockConsoleWriter.Object);
            mockConsoleWriter.Verify(cw => cw.WriteLine(It.IsAny<string>()), Times.Never);

            board.Place(2, 2, Direction.NORTH);
            mockConsoleWriter.Verify(cw => cw.WriteLine(It.IsAny<string>()), Times.Never);

            board.Report();
            mockConsoleWriter.Verify(cw => cw.WriteLine(It.Is<string>(s => s == "2,2,NORTH")), Times.Once);
            mockConsoleWriter.Verify(cw => cw.WriteLine(It.IsAny<string>()), Times.Once);
        }
    }
}
