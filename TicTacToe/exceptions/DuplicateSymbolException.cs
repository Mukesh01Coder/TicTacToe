namespace TicTacToe.exceptions
{
    public class DuplicateSymbolException : Exception
    {
        public DuplicateSymbolException(string message) : base(message)
        {
        }

        public DuplicateSymbolException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
