using TicTacToe.exceptions;
using TicTacToe.Models;
using TicTacToe.Models.Enums;
using TicTacToe.Services.Strategy;

namespace TicTacToe.Services
{
    public class GameService
    {
        private WinnerCheckStrategy winnerCheckStrategy;

        public GameService(int dimension)
        {
            winnerCheckStrategy = new O1WinnerCheckStrategy(dimension);
        }

        public Move executeMove(Player player, Game game, int row, int col)
        {
            Cell cell = game.getBoard().getCells()[row][col];

            if (!cell.getCellState().Equals(CellState.EMPTY))
            {
                throw new InvalidCellException("Invalid Cell has been chosen for the move, please try again");
                
            }
            cell.setCellState(CellState.FULL);
            cell.setPlayer(player);

            Move move = new Move(cell, player);

            game.getMoves().Add(move);
            game.getBoardState().Add(game.getBoard().Clone());

            return move;
        }
    }
}
