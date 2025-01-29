using System;
using Mission4_Assignment;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; // Player 1: 'X', Player 2: 'O'
    static bool gameOver = false;
    static int result = 0;

    static void Main()
    {
        Console.WriteLine("Welcome to the game of Tic Tac Toe!");
        Console.WriteLine("Player 1 has an X, Player 2 has a O.");
        
        for (int turn = 0; turn < 9; turn++)
        {
            //TicTacTools.PrintBoard(board);
            Console.WriteLine($"Player {currentPlayer}, enter a position between 1 and 9!");
            if (int.TryParse(Console.ReadLine(), out int position) && position >= 1 && position <= 9)
            {
                int index = position - 1;
                if (board[index] == 'X' || board[index] == 'O')
                {
                    Console.WriteLine("That spot is already taken! Please choose another one!");
                    turn--;
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
            else
            {
                Console.WriteLine("Please enter a valid position!");
                turn--;
            }
        }
        result = TicTacTools.CheckForWinner(board);
        if (result == 0)
        {
            Console.WriteLine("No one wins!");
        }
        else if(result == 1)
        {
            Console.WriteLine("Player 1 (X) wins!");
            
        }
        else if(result == 2)
        {
            Console.WriteLine("Player 2 (0) wins!");
        }
        Console.WriteLine("Thank you for playing!");
        
    }
}

