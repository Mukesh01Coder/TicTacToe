using TicTacToe.Models;

namespace TicTacToe.Services.Strategy
{
    public class O1WinnerCheckStrategy : WinnerCheckStrategy
    {
        private Dictionary<char, int> topLeftDiagonalMap;
        private Dictionary<char, int> topRightDiagonalMap;
        private Dictionary<char, int> cornerMap;
        private List<Dictionary<char, int>> rowMaps;
        private List<Dictionary<char, int>> columnMaps;

        public O1WinnerCheckStrategy(int size)
        {
            this.topLeftDiagonalMap = new Dictionary<char, int>();
            this.topRightDiagonalMap = new Dictionary<char, int>();
            this.cornerMap = new Dictionary<char, int>();
            rowMaps = new List<Dictionary<char, int>>();
            columnMaps = new List<Dictionary<char, int>>();
            initialiseMaps(size);
        }
        public Player checkWinner(Board board, Move currentMove)
        {
            int size = board.getSize();

            char symbol = currentMove.getPlayer().getSymbol();
            int row = currentMove.getCell().getRow();
            int col = currentMove.getCell().getCol();

            //update row and col hashmaps
            Dictionary<char, int> rowMap = rowMaps[row];
            Dictionary<char, int> colMap = columnMaps[col];

            rowMap.Add(symbol, rowMap.GetValueOrDefault(symbol, 0) + 1);
            colMap.Add(symbol, colMap.GetValueOrDefault(symbol, 0) + 1);

            if (rowMap[symbol] == size || colMap[symbol] == size)
            {
                return currentMove.getPlayer();
            }

            //update diagonal maps
            //left diagonal
            if (row == col)
            {
                topLeftDiagonalMap.Add(symbol, topLeftDiagonalMap.GetValueOrDefault(symbol, 0) + 1);
            }
            //right diagonal
            if ((row + col) == (size - 1))
            {
                topRightDiagonalMap.Add(symbol, topRightDiagonalMap.GetValueOrDefault(symbol, 0) + 1);
            }

            if (topLeftDiagonalMap.GetValueOrDefault(symbol, 0) == size || topRightDiagonalMap.GetValueOrDefault(symbol, 0) == size)
            {
                return currentMove.getPlayer();
            }

            //update corner map
            if ((row == 0 || row == (size - 1)) && (col == 0 || col == (size - 1)))
            {
                cornerMap.Add(symbol, cornerMap.GetValueOrDefault(symbol, 0) + 1);
            }

            if (cornerMap.GetValueOrDefault(symbol, 0) == 4)
            {
                return currentMove.getPlayer();
            }

            return null;
        }

        public Board updateBoardDetails(Board board)
        {
            //read the new board and update the hashmap accordingly
            //try to optimise the code, and reduce duplications
            return null;
        }

        private void initialiseMaps(int size)
        {
            for (int i = 0; i < size; i++)
            {
                rowMaps.Add(new Dictionary<char, int>());
                columnMaps.Add(new Dictionary<char, int>());
            }
        }

        private bool checkDraw()
        {
            //TODO:  optimise the TC with a counter for hashmaps
            foreach (Dictionary<char, int> map in rowMaps)
            {
                if (map.Count <= 1)
                    return false;
            }
            foreach (Dictionary<char,int> map in columnMaps)
            {
                if (map.Count() <= 1)
                    return false;
            }

            if (topRightDiagonalMap.Count() <= 1 || topLeftDiagonalMap.Count() <= 1 || cornerMap.Count() <= 1)
            {
                return false;
            }

            return true;
        }
    }
}
