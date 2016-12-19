using System;

class Tetris
{
    static void Main()
    {
        string strHeightWidth = Console.ReadLine();
        int fieldHeight = int.Parse(strHeightWidth.Split()[0]);
        int fieldWidth = int.Parse(strHeightWidth.Split()[1]);

        char[,] gameField = new char[fieldHeight, fieldWidth];

        for (int row = 0; row < fieldHeight; row++)
        {
            string currentLine = Console.ReadLine();
            
            for (int col = 0; col < fieldWidth; col++)
            {
                gameField[row, col] = currentLine[col];
            }
        }

        int iCounter = 0;
        int lCounter = 0;
        int jCounter = 0;
        int oCounter = 0;
        int zCounter = 0;
        int sCounter = 0;
        int tCounter = 0;

        
        // Check for I tetriminos
        for (int col = 0; col < fieldWidth; col++)
        {
            for (int row = 0; row < fieldHeight - 3; row++)
            {
                char firstSymbol = gameField[row, col];
                char secondSymbol = gameField[row + 1, col];
                char thirdSymbol = gameField[row + 2, col];
                char fourthSymbol = gameField[row + 3, col];

                if (firstSymbol == 'o' && secondSymbol == 'o' && thirdSymbol == 'o'
                    && fourthSymbol == 'o')
                {
                    iCounter++;
                }

            }
        }

        // Check for L tetriminos
        for (int col = 0; col < fieldWidth - 1; col++)
        {
            for (int row = 0; row < fieldHeight - 2; row++)
            {
                char firstSymbol = gameField[row, col];
                char secondSymbol = gameField[row + 1, col];
                char thirdSymbol = gameField[row + 2, col];
                char fourthSymbol = gameField[row + 2, col + 1];

                if (firstSymbol == 'o' && secondSymbol == 'o' && thirdSymbol == 'o'
                    && fourthSymbol == 'o')
                {
                    lCounter++;
                }
            }
        }

        // Check for J tetriminos
        for (int col = 1; col < fieldWidth; col++)
        {
            for (int row = 0; row < fieldHeight - 2; row++)
            {
                char firstSymbol = gameField[row, col];
                char secondSymbol = gameField[row + 1, col];
                char thirdSymbol = gameField[row + 2, col];
                char fourthSymbol = gameField[row + 2, col - 1];

                if (firstSymbol == 'o' && secondSymbol == 'o' && thirdSymbol == 'o'
                    && fourthSymbol == 'o')
                {
                    jCounter++;
                }

            }
        }

        // Check for O tetriminos
        for (int col = 0; col < fieldWidth - 1; col++)
        {
            for (int row = 0; row < fieldHeight - 1; row++)
            {
                char firstSymbol = gameField[row, col];
                char secondSymbol = gameField[row + 1, col];
                char thirdSymbol = gameField[row, col + 1];
                char fourthSymbol = gameField[row + 1, col + 1];

                if (firstSymbol == 'o' && secondSymbol == 'o' && thirdSymbol == 'o'
                    && fourthSymbol == 'o')
                {
                    oCounter++;
                }
            }
        }

        // Check for Z tetriminos
        for (int col = 0; col < fieldWidth - 2; col++)
        {
            for (int row = 0; row < fieldHeight - 1; row++)
            {
                char firstSymbol = gameField[row, col];
                char secondSymbol = gameField[row, col + 1];
                char thirdSymbol = gameField[row + 1, col + 1];
                char fourthSymbol = gameField[row + 1, col + 2];

                if (firstSymbol == 'o' && secondSymbol == 'o' && thirdSymbol == 'o'
                    && fourthSymbol == 'o')
                {
                    zCounter++;
                }
            }
        }

        // Check for S tetriminos
        for (int col = 1; col < fieldWidth - 1; col++)
        {
            for (int row = 0; row < fieldHeight - 1; row++)
            {
                char firstSymbol = gameField[row, col];
                char secondSymbol = gameField[row, col + 1];
                char thirdSymbol = gameField[row + 1, col - 1];
                char fourthSymbol = gameField[row + 1, col];

                if (firstSymbol == 'o' && secondSymbol == 'o' && thirdSymbol == 'o'
                    && fourthSymbol == 'o')
                {
                    sCounter++;
                }
            }
        }

        // Check for T tetriminos
        for (int col = 0; col < fieldWidth - 2; col++)
        {
            for (int row = 0; row < fieldHeight - 1; row++)
            {
                char firstSymbol = gameField[row, col];
                char secondSymbol = gameField[row, col + 1];
                char thirdSymbol = gameField[row, col + 2];
                char fourthSymbol = gameField[row + 1, col + 1];

                if (firstSymbol == 'o' && secondSymbol == 'o' && thirdSymbol == 'o'
                    && fourthSymbol == 'o')
                {
                    tCounter++;
                }
            }
        }

        
        Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}",
            iCounter, lCounter, jCounter, oCounter, zCounter, sCounter, tCounter);
    }
}

