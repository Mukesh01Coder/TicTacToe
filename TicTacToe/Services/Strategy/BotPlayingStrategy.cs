using TicTacToe.Models;

namespace TicTacToe.Services.Strategy
{
    public interface BotPlayingStrategy
    {
        Move executeMove(Player player, Game game);
    }
}
