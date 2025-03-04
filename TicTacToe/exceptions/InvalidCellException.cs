namespace TicTacToe.exceptions
{
    public class InvalidCellException : Exception
    {
        public InvalidCellException(string message) : base(message)
        {
        }

        public InvalidCellException(string message, Exception cause) : base(message, cause)
        {
        }
    }
}
