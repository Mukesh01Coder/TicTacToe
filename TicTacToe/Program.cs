using TicTacToe.Controller;
using TicTacToe.Services;

public class Program
{
    public static void main(string[] args)
    {
        Console.WriteLine("WELCOME TO TICTACTOE GAME");
        
        Console.WriteLine("Please enter the dimension of the board for the game");
        int dimension = Convert.ToInt32(Console.ReadLine());

        GameService gameService = new GameService(dimension);
        PlayerService playerService = new PlayerService();
        BoardService boardService = new BoardService();
        GameController gameController = new GameController(playerService, gameService, boardService);


    }
}