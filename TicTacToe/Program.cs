using TicTacToe.Controller;
using TicTacToe.exceptions;
using TicTacToe.Models;
using TicTacToe.Models.Enums;
using TicTacToe.Services;

//public class Program
//{
//    public static void main(string[] args)
//    {
        Console.WriteLine("WELCOME TO TICTACTOE GAME");
        StreamReader sc = new StreamReader(Console.OpenStandardInput());

        Console.WriteLine("Please enter the dimension of the board for the game");
        int dimension = Convert.ToInt32(sc.ReadLine());

        GameService gameService = new GameService(dimension);
        PlayerService playerService = new PlayerService();
        BoardService boardService = new BoardService();
        GameController gameController = new GameController(playerService, gameService, boardService);

        List<Player> players = gameController.generatePlayerList(dimension - 1);
        Game game = gameService.createGame(players, dimension);
        game = gameService.startGame(game);
        int moveIndex = 0;
        gameController.displayBoard(game);

        while (true)
        {
            try
            {
                Player currentPlayer = game.getPlayers()[moveIndex];
                Console.WriteLine("Player to make a move : " + currentPlayer.getName());
                Move currentMove = gameController.createMove(currentPlayer, game);
                gameController.displayBoard(game);
                if (currentPlayer.getPlayerType().Equals(PlayerType.HUMAN) && !currentPlayer.isHasUsedUndo())
                {
                    Console.WriteLine("Please enter the number of steps you want to undo, if you dont want to undo now, please enter 0");
                    int undoCount = Convert.ToInt32(sc.ReadLine());
                    if (undoCount > 0)
                    {
                        gameController.undo(undoCount, game);
                        currentPlayer.setHasUsedUndo(true);
                        gameController.displayBoard(game);
                    }
                    else
                    {
                        Console.WriteLine("Undo not done, moving forward");
                    }
                }
                GameState gameState = gameController.checkWinner(game, currentMove);
                if (gameState.Equals(GameState.WINNER))
                {
                    game.setWinner(currentPlayer);
                    Console.WriteLine("Congratulations to the winner : " + currentPlayer.getName());
                    break;
                }
            }
            catch (GameDrawnException ex)
            {
                Console.WriteLine("Game has drawn, no more winners ");
                break;
            }
            catch (InvalidCellException ex)
            {
                Console.WriteLine("Player has chosen a wrong cell for input, please enter again");
                continue;
            }
            moveIndex = (moveIndex + 1) % (dimension - 1);
        }
//    }
//}