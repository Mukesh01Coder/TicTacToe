using TicTacToe.Services;

namespace TicTacToe.Controller
{
    public class GameController
    {
        private PlayerService playerService;
        private GameService gameService;
        private BoardService boardService;

        public GameController(PlayerService playerService, GameService gameService, BoardService boardService)
        {
            this.playerService = playerService;
            this.gameService = gameService;
            this.boardService = boardService;
        }
    }
}
