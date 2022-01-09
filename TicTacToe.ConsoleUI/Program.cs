using System;

namespace TicTacToe.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool?[] board = new bool?[10];
            board[0] = true;
            //true = X, false = O

            //bool [0] holds the player turn while [1]-[9] hold the board. You can populate the board by copying the value of [0] onto another space on the board.

            /*                 [0]<----X or O based on the current player's turn.
             *              [1][2][3]
             *              [4][5][6]
             *              [7][8][9]
             */
        }

        public int PlayerMove(bool isX)
        //this method is used to declare a player's movement intentions. Outside this method, it will check if the move is valid and if not, loop through
        //the method again. If the move is valid, outside the method it will assign board[0] into the space of board[space] assigned here.
        {
            char player = isX ? 'X' : 'O';

            Console.WriteLine($"It is {player}'s turn. Which space would you like to move this turn?");

            int space = int.Parse(Console.ReadLine());

            return space;
        }

        public bool PlayerSwitch (bool isX) //used to alternate players. This method will be used to assign the value of board[0] after a turn has been made.
        {
            return !isX;
        }

        public void CheckWinner(bool?[] board)
        {
            //After each move this is called. It checks the board and if there is a winner, it declares them and ends the game.
            //If there is no winner, it does nothing and the game loop continues.
            for (int i = 1; i <= 9; i++)
            {

            }

            //I'm not sure how to make the check efficient in code terms. board[0] needs to be ignored in detecting a winner.
            //We need to parse through the scenarios, but I feel like scripting "if board[1], board[2], and board[3] are all the same, then the game is over"
            //for every possible scenario is inefficient.

            //For check horizontal matches, we'd only need to declare a starting point (like [1]) and then check it and the next two past it.
            //For vertical matches, we'd only need to declare a starting point like [2] and then check it and the next two by adding 3 (so [2][5][8]).
            //I also came up with a formula that could work if we made the board, and thus the number of pieces in a row required, variable
            //but that's not necessary.
            //The only "hard check" we'd need would be the diagonals: [1][5][9] and [3][5][7] since their patterns are unique to themselves.
        }

        public void CheckDraw(bool?[] board)
        {
            //This method is called after CheckWinner and check to see if the board is full. If it is, it declares a draw and ends the game.
            bool isNull = false;
            foreach (var space in board)
            {
                if (space == null){
                    isNull = true;
                }
            }

            if (isNull == false)
            {
                //the code that declares a draw and terminates the game.
            }
        }

    }
}
