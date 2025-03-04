﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models.Enums;

namespace TicTacToe.Models
{
    public class Game
    {
        private Board board;
        private List<Player> players;
        private GameState gameState;
        private Player currentPlayer;
        private Player winner;
        private List<Move> moves;
        private List<Board> boardState;

        public Game(Board board, List<Player> players)
        {
            this.board = board;
            this.players = players;
            this.gameState = GameState.YET_TO_START;
            this.moves = new List<Move>();
            this.boardState = new List<Board>();
        }
        public Board getBoard()
        {
            return board;
        }

        public void setBoard(Board board)
        {
            this.board = board;
        }

        public List<Player> getPlayers()
        {
            return players;
        }

        public void setPlayers(List<Player> players)
        {
            this.players = players;
        }

        public GameState getGameState()
        {
            return gameState;
        }

        public void setGameState(GameState gameState)
        {
            this.gameState = gameState;
        }

        public Player getCurrentPlayer()
        {
            return currentPlayer;
        }

        public void setCurrentPlayer(Player currentPlayer)
        {
            this.currentPlayer = currentPlayer;
        }

        public Player getWinner()
        {
            return winner;
        }

        public void setWinner(Player winner)
        {
            this.winner = winner;
        }

        public List<Move> getMoves()
        {
            return moves;
        }

        public void setMoves(List<Move> moves)
        {
            this.moves = moves;
        }

        public List<Board> getBoardState()
        {
            return boardState;
        }

        public void setBoardState(List<Board> boardState)
        {
            this.boardState = boardState;
        }

    }
}
