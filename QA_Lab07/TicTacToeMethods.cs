using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab07
{
    class TicTacToeMethods
    {

        string[,] tictacToe;

        //Creates the Board
        public Array createBoard()
        {
            tictacToe = new string[3, 3];
            return tictacToe;
        }


        //Returns current player
        public string currentPlayer(int player)
        {
            if (player == 1)
            {
                return "player1";
            }
            if (player == 2)
            {
                return "player2";
            }
            else
            {
                return "";
            }
        }


        //Changes current player
        public string changePlayer(int currentPlayer)
        {
            if (currentPlayer == 1)
            {
                return "player1";
            }
            if (currentPlayer == 2)
            {
                return "player2";
            }
            else
            {
                return "";
            }
        }


        //Makes a move
        public string makeMove(int player, int row, int col)
        {
            createBoard();
            if (player == 1)
            {
                tictacToe[row, col] = "x";
                return "x";
            }
            if (player == 2)
            {
                tictacToe[row, col] = "o";
                return "o";
            }
            else
            {
                return "";
            }
        }

        //Identifies space in use
        public bool spaceInUse(int row, int col)
        {
            createBoard();
            if (tictacToe[row, col] == "o")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
