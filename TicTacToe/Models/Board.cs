using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Board
    {
        private List<List<Cell>> cells;
        private int size;

        public Board(int size)
        {
            this.size = size;
            cells = new List<List<Cell>>();
            for (int i = 0; i < size; i++)
            {
                List<Cell> celllist = new List<Cell>();
                for (int j = 0; j < size; j++)
                {
                    celllist.Add(new Cell(i,j));
                }
                cells.Add(celllist);
            }
        }

        public List<List<Cell>> getCells()
        {
            return cells;
        }

        public void setCells(List<List<Cell>> cells)
        {
            this.cells = cells;
        }
        public int getSize()
        {
            return size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public Board Clone()
        {
            Board newBoard = new Board(this.size); // Create new board due to reference type So can easily do undo operation 
     
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    newBoard.getCells()[i][j] = this.cells[i][j];
                }
            }
            return newBoard;
        }
    }
}
