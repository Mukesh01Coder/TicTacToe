using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TicTacToe.Models.Enums;

namespace TicTacToe.Models
{
    public class Player
    {
        private int id;
        private string name;
        private char symbol;
        private PlayerType playerType;
        private bool hasUsedUndo;

        public Player()
        {
        }

        public Player(int id, string name, char symbol, PlayerType playerType)
        {
            this.id = id;
            this.name = name;
            this.symbol = symbol;
            this.playerType = playerType;
            this.hasUsedUndo = false;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public char getSymbol()
        {
            return symbol;
        }

        public void setSymbol(char symbol)
        {
            this.symbol = symbol;
        }

        public PlayerType getPlayerType()
        {
            return playerType;
        }

        public void setPlayerType(PlayerType playerType)
        {
            this.playerType = playerType;
        }

        public bool isHasUsedUndo()
        {
            return hasUsedUndo;
        }

        public void setHasUsedUndo(bool hasUsedUndo)
        {
            this.hasUsedUndo = hasUsedUndo;
        }
    }
}
