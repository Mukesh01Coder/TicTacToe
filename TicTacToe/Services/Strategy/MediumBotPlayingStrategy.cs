using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models.Enums;
using TicTacToe.Models;
using TicTacToe.exceptions;

namespace TicTacToe.Services.Strategy
{
    public class MediumBotPlayingStrategy: BotPlayingStrategy
    {
        public Move executeMove(Player player, Game game)
        {
            Board board = game.getBoard();
            Move move = null;
            foreach (List<Cell> cells in board.getCells())
            {
                foreach (Cell cell in cells)
                {
                    if (!cell.getCellState().Equals(CellState.EMPTY))
                    {
                        throw new InvalidCellException("Invalid Cell has been chosen for the move, please try again");
                    }
                    cell.setCellState(CellState.FULL);
                    cell.setPlayer(player);
                    move = new Move(cell, player);
                    game.getMoves().Add(move);
                    game.getBoardState().Add(board.Clone());
                }
            }
            return move;
            // TODO : randomise the move for the bot,
            // figure out all the empty cells, and then choose a cell randomly
        }
    }
}
