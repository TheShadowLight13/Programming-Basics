using System;

class KnightPath
{
    static int currentCellRow = 0;
    static int currentCellCol = 0;

    static void Main()
    {
        int[] chessBoard = new int[8];
        chessBoard[0] = 1;

        string input = Console.ReadLine();
        while (input != "stop")
        {
            string[] commands = input.Split();
            string firstCommand = commands[0];
            string secondCommand = commands[1];

            ExecuteCommand(firstCommand, secondCommand, chessBoard);

            input = Console.ReadLine();
        }

        bool wholeZeroMap = true;

        foreach (int number in chessBoard)
        {
            if (number != 0)
            {
                Console.WriteLine(number);
                wholeZeroMap = false;
            }
        }

        if (wholeZeroMap)
        {
            Console.WriteLine("[Board is empty]");
        }
    }

    private static void ExecuteCommand(string firstCommand, string secondCommand, int[] chessBoard)
    {
        if (firstCommand == "left" && currentCellCol + 2 <= 7)
        {

            if (secondCommand == "up" && currentCellRow - 1 >= 0)
            {
                currentCellCol += 2;
                currentCellRow--;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;

            }
            else if (secondCommand == "down" && currentCellRow + 1 <= 7)
            {
                currentCellCol += 2;
                currentCellRow++;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;
            }
        }
        else if (firstCommand == "right" && currentCellCol - 2 >= 0)
        {

            if (secondCommand == "up" && currentCellRow - 1 >= 0)
            {
                currentCellCol -= 2;
                currentCellRow--;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;

            }
            else if (secondCommand == "down" && currentCellRow + 1 <= 7)
            {
                currentCellCol -= 2;
                currentCellRow++;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;
            }
        }
        else if (firstCommand == "up" && currentCellRow - 2 >= 0)
        {

            if (secondCommand == "left" && currentCellCol + 1 <= 7)
            {
                currentCellRow -= 2;
                currentCellCol++;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;
            }
            else if (secondCommand == "right" && currentCellCol - 1 >= 0)
            {
                currentCellRow -= 2;
                currentCellCol--;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;
            }
        }
        else if (firstCommand == "down" && currentCellRow + 2 <= 7)
        {

            if (secondCommand == "left" && currentCellCol + 1 <= 7)
            {
                currentCellRow += 2;
                currentCellCol++;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;
            }
            else if (secondCommand == "right" && currentCellCol - 1 >= 0)
            {
                currentCellRow += 2;
                currentCellCol--;
                chessBoard[currentCellRow] ^= 1 << currentCellCol;
            }
        }
    }
}

