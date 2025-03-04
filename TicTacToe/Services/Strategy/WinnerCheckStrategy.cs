using TicTacToe.Models;

namespace TicTacToe.Services.Strategy
{
    public interface WinnerCheckStrategy
    {
        Player checkWinner(Board board, Move currentMove);
        Board updateBoardDetails(Board board);
        
    }
}
