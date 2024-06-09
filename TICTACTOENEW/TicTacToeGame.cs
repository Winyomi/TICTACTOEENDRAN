﻿using System;

namespace TicTacToe
{
    public class TicTacToeGame : GameBase
    {
        public TicTacToeGame() : base()
        {
        }

        public override bool CheckWinner()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                {
                    return true;
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == currentPlayer && board[1, j] == currentPlayer && board[2, j] == currentPlayer)
                {
                    return true;
                }
            }

            // Check diagonals
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            {
                return true;
            }
            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
            {
                return true;
            }

            return false;
        }

        public bool IsDraw()
        {
            foreach (char cell in board)
            {
                if (cell == ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public bool MakeMove(int row, int col)
        {
            if (board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                return true;
            }
            return false;
        }
    }
}
