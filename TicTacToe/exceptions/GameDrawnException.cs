namespace TicTacToe.exceptions
{
    public class GameDrawnException : Exception
    {
        public GameDrawnException(string message) : base(message)
        {
        }

        public GameDrawnException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
