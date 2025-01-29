// Lisa Montoya, Peter Hamilton, Riley Wells, Jonathan Beales 1-12
// game of tic-tac-toe

using System;
using Mission4_Assignment;

class Program
{   
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; // Player 1: 'X', Player 2: 'O'
    static bool gameOver = false;
    static int result = 0;

    static void Main()
    {   // welcomes user and gives instructions
        Console.WriteLine("Welcome to the game of Tic Tac Toe!");
        Console.WriteLine("Player 1 has an X, Player 2 has a O.");
        int turn = 0;
        while (!gameOver && turn < 9)
        {   // prints board using the PrintBoard method
            TicTacTools.PrintBoard(board);
            // checks to see if user enters a position 1-9
            Console.WriteLine($"Player {currentPlayer}, enter a position between 1 and 9!");
            if (int.TryParse(Console.ReadLine(), out int position) && position >= 1 && position <= 9)
            {
                int index = position - 1;
                if (board[index] == 'X' || board[index] == 'O')
                {   // checks if spot is already taken
                    Console.WriteLine("That spot is already taken! Please choose another one!");
                }
                else
                {
                    if (currentPlayer == 1)
                    {
                        board[index] = 'X';
                    }
                    else
                    {
                        board[index] = 'O';
                    }
                    // checks for winner using the CheckForWinner method
                    result = TicTacTools.CheckForWinner(board);
                    if(result == 1)
                    {
                        TicTacTools.PrintBoard(board);
                        Console.WriteLine("Player 1 (X) wins!");
                        gameOver = true;

                    }
                    else if(result == 2)
                    {
                        TicTacTools.PrintBoard(board);
                        Console.WriteLine("Player 2 (0) wins!");
                        gameOver = true;
                    }
                    else
                    {   // increments turns
                        turn++;
                        if (currentPlayer == 1)
                        {
                            currentPlayer = 2;
                        }
                        else
                        {
                            currentPlayer = 1;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid position!");
            }
        }
        if (!gameOver) // If no one won, it is a tie
        {
            TicTacTools.PrintBoard(board);
            Console.WriteLine("It's a tie!");
        }
        Console.WriteLine("Thanks for Playing!");
    }
}

