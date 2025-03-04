using TicTacToe.exceptions;
using TicTacToe.Models;
using TicTacToe.Models.Enums;

namespace TicTacToe.Services
{
    public class PlayerService
    {
        private static int counter = 1;

        private HashSet<char> symbolSet;

        public PlayerService()
        {
            this.symbolSet = new HashSet<char>();
        }

        public Player createPlayer(String name, char symbol)
        {
            if (symbolSet.Contains(symbol))
            {
                throw new DuplicateSymbolException("The symbol used for the player, already exists : " + symbol);
            }
            symbolSet.Add(symbol);

            return new Player(counter++, name, symbol, PlayerType.HUMAN);
        }
        public Bot createBot(String name, char symbol)
        {
            if (symbolSet.Contains(symbol))
            {
                throw new DuplicateSymbolException("The symbol used for the bot, already exists : " + symbol);
            }
            symbolSet.Add(symbol);
            return new Bot(
                    counter++,
                    name,
                    symbol,
                    PlayerType.BOT,
                    BotDifficultyLevel.MEDIUM // default for now
            );
        }
    }
}
