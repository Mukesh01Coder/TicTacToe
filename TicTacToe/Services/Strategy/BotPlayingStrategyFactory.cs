using TicTacToe.Models.Enums;

namespace TicTacToe.Services.Strategy
{
    public class BotPlayingStrategyFactory
    {
        public static BotPlayingStrategy getBotPlayingStrategy(BotDifficultyLevel botDifficultyLevel)
        {
            switch(botDifficultyLevel)
            {
                case BotDifficultyLevel.EASY:
                    return new EasyBotPlayingStrategy();
                case BotDifficultyLevel.MEDIUM:
                    return new MediumBotPlayingStrategy();
                case BotDifficultyLevel.HARD:
                    return new HardBotPlayingStrategy();
                default:
                    return new EasyBotPlayingStrategy();
            }
        }
    }
}
