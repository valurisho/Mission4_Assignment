namespace Mission4_Assignment;

public class TicTacTools
{
    // Recieve the board array from driver class
    public static void PrintBoard(int[] boardArray)
    {
        Console.WriteLine($"{boardArray[0]} | {boardArray[1]} | {boardArray[2]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{boardArray[3]} | {boardArray[4]} | {boardArray[5]}");
        Console.WriteLine("--+---+--");
        Console.WriteLine($"{boardArray[6]} | {boardArray[7]} | {boardArray[8]}");
    }

    
}