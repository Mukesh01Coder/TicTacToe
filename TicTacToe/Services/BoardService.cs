using TicTacToe.Models;
using TicTacToe.Models.Enums;

namespace TicTacToe.Services
{
    public class BoardService
    {
        public void displayBoard(Board board)
        {
            for(int i=0;i<board.getSize();i++)
            {
                for(int j=0;j<board.getSize();j++)
                {
                    Console.Write('|');

                    Cell cell = board.getCells()[i][j];

                    if(cell.getCellState() == CellState.EMPTY)
                    {
                        Console.Write(" ");
                    }
                    else if (cell.getCellState() == CellState.FULL)
                    {
                        Console.Write(cell.getPlayer().getSymbol());
                    }
                    else
                    {
                        Console.Write("-");
                    }
                    Console.Write('|');
                }
                Console.WriteLine();
            }
        }
    }
}
