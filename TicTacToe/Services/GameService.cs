using TicTacToe.exceptions;
using TicTacToe.Models;
using TicTacToe.Models.Enums;
using TicTacToe.Services.Strategy;

namespace TicTacToe.Services
{
    public class GameService
    {
        private WinnerCheckStrategy winnerCheckStrategy;

        public GameService(int dimension)
        {
            winnerCheckStrategy = new O1WinnerCheckStrategy(dimension);
        }

        public Move executeMove(Player player, Game game, int row, int col)
        {
            Cell cell = game.getBoard().getCells()[row][col];

            if (!cell.getCellState().Equals(CellState.EMPTY))
            {
                throw new InvalidCellException("Invalid Cell has been chosen for the move, please try again");
                
            }
            cell.setCellState(CellState.FULL);
            cell.setPlayer(player);

            Move move = new Move(cell, player);

            game.getMoves().Add(move);
            game.getBoardState().Add(game.getBoard().Clone());

            return move;
        }
        public Move executeMove(Player player, Game game)
        {
            BotPlayingStrategy botPlayingStrategy = BotPlayingStrategyFactory.getBotPlayingStrategy(BotDifficultyLevel.MEDIUM);
            return botPlayingStrategy.executeMove(player, game);
        }

        public Game createGame(List<Player> players, int size)
        {
            Board board = new Board(size);
            return new Game(board, players);
        }

        public Game startGame(Game game)
        {
            game.setGameState(GameState.IN_PROGRESS);
            List<Player> players = game.getPlayers();
            // Shuffle the list
            players = players.OrderBy(x => Guid.NewGuid()).ToList();//Collections.shuffle(game.getPlayers());

            return game;
        }

        public GameState checkWinner(Game game, Move currentMove)
        {
            Player player = winnerCheckStrategy.checkWinner(game.getBoard(), currentMove);
            if (player != null)
            {
                return GameState.WINNER;
            }
            else
            {
                return GameState.IN_PROGRESS;
            }
        }

        public Game undo(int moves, Game game)
        {
            //write the logic
            winnerCheckStrategy.updateBoardDetails(game.getBoard());
            return null;
        }
    }
}
