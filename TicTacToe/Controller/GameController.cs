using TicTacToe.Models;
using TicTacToe.Models.Enums;
using TicTacToe.Services;

namespace TicTacToe.Controller
{
    public class GameController
    {
        private PlayerService playerService;
        private GameService gameService;
        private BoardService boardService;
        private StreamReader sc;

        public GameController(PlayerService playerService, GameService gameService, BoardService boardService)
        {
            this.sc = new StreamReader(Console.OpenStandardInput());
            this.playerService = playerService;
            this.gameService = gameService;
            this.boardService = boardService;
        }

        public List<Player> generatePlayerList(int playerCount)
        {
            Console.WriteLine("Please enter 1 if you want a bot in the game, else 0");

            int botCheck = Convert.ToInt32(sc.ReadLine());//1 or 0

            List<Player> players = new List<Player>();

            if (botCheck == 1)
            {
                //TODO : take user input for bot difficulty level, and create bot accordingly

                //TODO : take user input for bot name, and bot symbol --> Completed
                Console.WriteLine("Enter the name for the bot player");
                string botPlayerName = sc.ReadLine();
                Console.WriteLine("Enter the symbol for bot player : " + botPlayerName);
                char botSymbol = sc.ReadLine()[0];
                Bot bot = playerService.createBot(botPlayerName, botSymbol);
                players.Add(bot);
                playerCount--;
            }
            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("Enter the name for the player");
                string playerName = sc.ReadLine();
                Console.WriteLine("Enter the symbol for player : " + playerName);
                char symbol = sc.ReadLine()[0];
                Player player = playerService.createPlayer(playerName, symbol);
                players.Add(player);
            }
            players = players.OrderBy(x => Guid.NewGuid()).ToList();//Collections.shuffle(players);
            return players;
        }
        public Move createMove(Player player, Game game)
        {
            if (player.getPlayerType().Equals(PlayerType.HUMAN))
            {
                Console.WriteLine("Please enter the row");
                int row = Convert.ToInt32(sc.ReadLine());
                Console.WriteLine("Please enter the col");
                int col = Convert.ToInt32(sc.ReadLine());
                //TODO: validate row and column before executing the move
                return gameService.executeMove(player, game, row, col);
            }
            else
            {
                return gameService.executeMove(player, game);
            }
        }

        public GameState checkWinner(Game game, Move move)
        {
            return gameService.checkWinner(game, move);
        }

        public Game undo(int moves, Game game)
        {
            //TODO: add validations for moves
            return gameService.undo(moves, game);
        }
        public Game startGame(Game game)
        {
            return null;
        }

        public void replayGame(Game game)
        {
            //actual business logic in gameService class
        }

        public void displayBoard(Game game)
        {
            boardService.displayBoard(game.getBoard());
        }
    }
}

