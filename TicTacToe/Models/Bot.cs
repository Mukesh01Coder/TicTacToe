using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models.Enums;

namespace TicTacToe.Models
{
    public class Bot: Player 
    {
        private BotDifficultyLevel botDifficultyLevel;

        public Bot(int id, String name, char symbol, PlayerType playerType, BotDifficultyLevel botDifficultyLevel) 
        {
            new Player(id, name, symbol, playerType);
            this.botDifficultyLevel = botDifficultyLevel;
        }

        public BotDifficultyLevel getBotDifficultyLevel()
        {
            return botDifficultyLevel;
        }

        public void setBotDifficultyLevel(BotDifficultyLevel botDifficultyLevel)
        {
            this.botDifficultyLevel = botDifficultyLevel;
        }
    }
}
