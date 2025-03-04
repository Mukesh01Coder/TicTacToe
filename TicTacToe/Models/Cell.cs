﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models.Enums;

namespace TicTacToe.Models
{
    public class Cell
    {
        private int row;
        private int col;
        private CellState cellState;
        private Player player;

        public Cell(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.cellState = CellState.EMPTY;
            this.player = null;
        }
        public int getRow()
        {
            return row;
        }

        public void setRow(int row)
        {
            this.row = row;
        }

        public int getCol()
        {
            return col;
        }

        public void setCol(int col)
        {
            this.col = col;
        }

        public CellState getCellState()
        {
            return cellState;
        }

        public void setCellState(CellState cellState)
        {
            this.cellState = cellState;
        }

        public Player getPlayer()
        {
            return player;
        }

        public void setPlayer(Player player)
        {
            this.player = player;
        }
    }
}

