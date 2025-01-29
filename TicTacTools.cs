namespace Mission4_Assignment;

public class TicTacTools
{
    // Recieve the board array from driver class
    // prints the boardArray
    public static void PrintBoard(char[] boardArray)
    {
        Console.WriteLine($"{boardArray[0]} | {boardArray[1]} | {boardArray[2]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{boardArray[3]} | {boardArray[4]} | {boardArray[5]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{boardArray[6]} | {boardArray[7]} | {boardArray[8]}");
    }

    // method that checks for a winner
    public static int CheckForWinner(char[] boardArray)
    {
        List<int[]> winConditions = new List<int[]>
        {   // winning combinations
            new int[] {0, 1, 2 }, new int[] {3, 4, 5 }, new int[] {6, 7, 8 },
            new int[] {0, 3, 6 }, new int[] {1, 4, 7 }, new int[] {2, 5, 8 },
            new int[] {0, 4, 8 }, new int[] {2, 4, 6 }
        };

        // checking to see if teither player has a winning combination
        foreach (var condition in winConditions)
        {
            if (boardArray[condition[0]] != ' ' &&
                    boardArray[condition[0]] == boardArray[condition[1]] &&
                    boardArray[condition[1]] == boardArray[condition[2]])
            {
                if (boardArray[condition[0]] == 'X')
                {
                    return 1;
                }
                else if (boardArray[condition[0]] == 'O')
                {
                    return 2;
                }
            }

        }

        return 0;

    }
    
}
