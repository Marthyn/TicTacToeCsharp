using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Game
    {
        private int[,] board = new int[3, 3];
        private Player player1, player2;
        private Player currentPlayer;
        Random randomGen = new System.Random();
        public Game(Player p1, Player p2)
        {
            this.player1 = p1;
            this.player2 = p2;


            int num = randomGen.Next(0, 2);
            if (num == 1)
            {
                currentPlayer = player1;
            }
            else
            {
                currentPlayer = player2;
            }


            MessageBox.Show(currentPlayer.getName() + " will start");
        }

        public bool boardFull()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool isAwin(int player)
        {
            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
            {
                return true;
            }
            if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
            {
                return true;
            }
            if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
            {
                return true;
            }
            if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
            {
                return true;
            }
            if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
            {
                return true;
            }
            if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)
            {
                return true;
            }
            if (board[1, 1] == player && board[2, 2] == player && board[0, 0] == player)
            {
                return true;
            }
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                return true;
            }
            // no win found
            return false;
        }



        public bool changeField(int no)
        {
            if (board[no / 3, no % 3] == 0)
            {
                board[no / 3, no % 3] = currentPlayer.getNumber();

                if (isAwin(currentPlayer.getNumber()))
                {
                    return true;
                }
                else
                {
                    if (currentPlayer == player1)
                    {
                        currentPlayer = player2;
                    }
                    else
                    {
                        currentPlayer = player1;
                    }
                    return false;
                }


            }
            else
            {
                return false;
            }


        }

        public int[,] getBoard()
        {
            return board;
        }

        public Player getCurrentPlayer()
        {
            if (player1.getNumber() == currentPlayer.getNumber())
            {
                return player1;
            }
            else
            {
                return player2;
            }
        }
    }
}
