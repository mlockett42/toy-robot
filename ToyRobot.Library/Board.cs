

using ToyRobot.Library.Exceptions;

namespace ToyRobot.Library
{
    public class Board
    {
        public bool IsIntialised()
        {
            return false;
        }

        public void Left()
        {
            throw new BoardUnitialisedException();
        }

        public void Move()
        {
            throw new BoardUnitialisedException();
        }

        public void Right()
        {
            throw new BoardUnitialisedException();
        }
    }
}
