using System;
using System.Threading;
using System.Globalization;

class FunMatrices
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double[,] matrix = new double[4, 4];

        double startNumber = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        // Fill cells with numbers

        double previousCellValue = 0;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (row == 0 && col == 0)
                {
                    matrix[row, col] = startNumber;
                    previousCellValue = matrix[row, col];
                }
                else
                {
                    matrix[row, col] = previousCellValue + step;
                    previousCellValue = matrix[row, col];
                }
            }
        }

        // Get orders and change values in cells

        string orders = Console.ReadLine();

        while (orders != "Game Over!")
        {
            int row = int.Parse(orders.Split()[0]);
            int col = int.Parse(orders.Split()[1]);
            string command = orders.Split()[2];
            double num = double.Parse(orders.Split()[3]); 

            if (command.Equals("multiply"))
            {
                matrix[row, col] *= num;
            }
            else if (command.Equals("sum"))
            {
                matrix[row, col] += num;
            }
            else if (command.Equals("power"))
            {
                matrix[row, col] = Math.Pow(matrix[row, col], num);
            }

            orders = Console.ReadLine();
        }

        // Get largest row

        double largestRow = Double.MinValue;
        int largestRowIndex = 0;

        for (int row = 0; row < 4; row++)
        {
            double currentRowSum = 0;
            
            for (int col = 0; col < 4; col++)
            {
                currentRowSum += matrix[row, col];
            }

            if (currentRowSum > largestRow)
            {
                largestRow = currentRowSum;
                largestRowIndex = row;
            }
        }

        // Get largest column

        double largestCol = double.MinValue;
        int largestColIndex = 0;

        for (int col = 0; col < 4; col++)
        {
            double currentColSum = 0;
            
            for (int row = 0; row < 4; row++)
            {
                currentColSum += matrix[row, col];
            }

            if (currentColSum > largestCol)
            {
                largestCol = currentColSum;
                largestColIndex = col;
            }
        }

        // Get left diagonal sum

        double leftDiagonalSum = 0;
        
        for (int row = 0, col = 0; row < 4; row++, col++)
        {
            leftDiagonalSum += matrix[row, col];
        }

        // Get right diagonal sum

        double rightDiagonalSum = 0;

        for (int row = 3, col = 0; row >= 0; row--, col++)
        {
            rightDiagonalSum += matrix[row, col];
        }

        // Get largest diagonal

        string largestDiagonal = "";
        double largestDiagonalValue = 0;

        if (leftDiagonalSum >= rightDiagonalSum)
        {
            largestDiagonalValue = leftDiagonalSum;
            largestDiagonal = "LEFT-DIAGONAL";
        }
        else
        {
            largestDiagonalValue = rightDiagonalSum;
            largestDiagonal = "RIGHT-DIAGONAL";
        }

        // Print largest sum

        if (largestRow >= largestCol && largestRow >= largestDiagonalValue)
        {
            Console.WriteLine("ROW[{0}] = {1:F2}", largestRowIndex, largestRow);
        }
        else if (largestCol > largestRow && largestCol >= largestDiagonalValue)
        {
            Console.WriteLine("COLUMN[{0}] = {1:F2}", largestColIndex, largestCol);
        }
        else
        {
            Console.WriteLine("{0} = {1:F2}", largestDiagonal, largestDiagonalValue);
        }
    }
}

