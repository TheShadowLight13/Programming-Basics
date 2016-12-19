using System;
using System.Collections.Generic;

class GameOfLife
{
    static void Main()
    {
        int[] matrix = new int[10];

        List<int> positionsWithDeadCells = new List<int>();
        List<int> positionsWithLiveCells = new List<int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            matrix[row] |= (1 << column);
        }

        int liveNeighbours = 0;

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix.Length; col++)
            {
                liveNeighbours = 0;

                //above
                NumberOfLiveNeighbours(row - 1, col, ref liveNeighbours, matrix);

                //above left
                NumberOfLiveNeighbours(row - 1, col + 1, ref liveNeighbours, matrix);

                //above right
                NumberOfLiveNeighbours(row - 1, col - 1, ref liveNeighbours, matrix);

                //left
                NumberOfLiveNeighbours(row, col + 1, ref liveNeighbours, matrix);

                //right
                NumberOfLiveNeighbours(row, col - 1, ref liveNeighbours, matrix);

                //under
                NumberOfLiveNeighbours(row + 1, col, ref liveNeighbours, matrix);

                //under left
                NumberOfLiveNeighbours(row + 1, col + 1, ref liveNeighbours, matrix);

                //under right
                NumberOfLiveNeighbours(row + 1, col - 1, ref liveNeighbours, matrix);

                if (((matrix[row] >> col) & 1) == 1)
                {
                    if (liveNeighbours < 2 || liveNeighbours > 3)
                    {
                        positionsWithDeadCells.Add(row);
                        positionsWithDeadCells.Add(col);
                    }
                }
                else if (((matrix[row] >> col) & 1) == 0)
                {
                    if (liveNeighbours == 3)
                    {
                        positionsWithLiveCells.Add(row);
                        positionsWithLiveCells.Add(col);
                    }
                }
            }
        }

        for (int i = 0; i < positionsWithLiveCells.Count; i += 2)
        {
            int row = positionsWithLiveCells[i];
            int col = positionsWithLiveCells[i + 1];

            matrix[row] |= 1 << col;
        }

        for (int i = 0; i < positionsWithDeadCells.Count; i += 2)
        {
            int row = positionsWithDeadCells[i];
            int col = positionsWithDeadCells[i + 1];

            matrix[row] ^= 1 << col;
        }

        foreach (var number in matrix)
        {
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(10, '0'));
        }
    }

    private static void NumberOfLiveNeighbours(int row, int column,
                                           ref int liveNeighbours, int[] matrix)
    {
        if (IsValidCoordinates(row, column))
        {
            int currentBit = (matrix[row] >> column) & 1;

            if (currentBit == 1)
            {
                liveNeighbours++;
            }
        }
    }

    private static bool IsValidCoordinates(int currentRow, int currentColumn)
    {
        bool isValidRow = (currentRow >= 0 && currentRow <= 9);
        bool isValidCol = (currentColumn >= 0 && currentColumn <= 9);

        return isValidRow && isValidCol;
    }
}

