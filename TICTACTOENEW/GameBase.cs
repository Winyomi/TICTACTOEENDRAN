using System;

namespace TicTacToe
{
    public abstract class GameBase
    {
        protected char[,] board;
        protected char currentPlayer;

        public GameBase()
        {
            board = new char[3, 3];
            currentPlayer = 'X';
            InitializeBoard();
        }

        protected void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        public char CurrentPlayer => currentPlayer;

        public void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }

        public abstract bool CheckWinner();
    }
}
