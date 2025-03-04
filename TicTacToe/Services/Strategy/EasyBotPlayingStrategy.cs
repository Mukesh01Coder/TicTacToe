
using TicTacToe.exceptions;
using TicTacToe.Models;
using TicTacToe.Models.Enums;

namespace TicTacToe.Services.Strategy
{
    public class EasyBotPlayingStrategy : BotPlayingStrategy
    {
        public Move executeMove(Player player, Game game)
        {
            Board board = game.getBoard();

            Move move = null;

            foreach (List<Cell> cells in board.getCells())
            {
                foreach(Cell cell in cells)
                {
                    if (!cell.getCellState().Equals(CellState.EMPTY))
                    {
                        throw new InvalidCellException("Invalid Cell has been chosen for the move, please try again");
                    }

                    cell.setCellState(CellState.FULL);
                    cell.setPlayer(player);
                    move = new Move(cell, player);
                    game.getMoves().Add(move);
                    game.getBoardState().Add(game.getBoard().Clone());
                    return move;
                }
            }

            return move;
        }
    }
}
