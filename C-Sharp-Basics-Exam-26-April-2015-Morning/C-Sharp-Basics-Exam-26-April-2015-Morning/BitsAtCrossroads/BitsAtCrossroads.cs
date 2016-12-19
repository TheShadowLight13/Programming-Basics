using System;

class BitsAtCrossroads
{

    static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        int[] matrix = new int[matrixSize];
        int crossRoads = 0;

        string command = Console.ReadLine();
        while (command != "end")
        {
            int row = int.Parse(command.Split()[0]);
            int column = int.Parse(command.Split()[1]);

            crossRoads++;

            matrix[row] |= 1 << column;

            // top-left
            FillPath(row - 1, column + 1, matrix, -1, 1, ref crossRoads);

            // bottom-right
            FillPath(row + 1, column - 1, matrix, 1, -1, ref crossRoads);

            // bottom-left
            FillPath(row + 1, column + 1, matrix, 1, 1, ref crossRoads);

            // top-right
            FillPath(row - 1, column - 1, matrix, -1, -1, ref crossRoads);

            command = Console.ReadLine();
        }

        foreach (var number in matrix)
        {
            Console.WriteLine((uint)number);
        }
        
        Console.WriteLine(crossRoads);
    }

    private static void FillPath(
        int currentRow,
        int currentColumn,
        int[] matrix,
        int rowUpdate,
        int colUpdate,
        ref int crossRoads)
    {
        while (AreCoordinatesValid(currentRow, currentColumn, matrix.Length))
        {
            if (((matrix[currentRow] >> currentColumn) & 1) == 1)
            {
                crossRoads++;
            }

            matrix[currentRow] |= 1 << currentColumn;

            currentRow += rowUpdate;
            currentColumn += colUpdate;
        }
    }

    private static bool AreCoordinatesValid(int row, int col, int size)
    {
        bool isRowValid = 0 <= row && row < size;
        bool isColumnValid = 0 <= col && col < size;

        return isRowValid && isColumnValid;
    }
}
