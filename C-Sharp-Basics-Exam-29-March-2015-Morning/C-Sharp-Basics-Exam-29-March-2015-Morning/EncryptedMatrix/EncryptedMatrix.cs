using System;

class EncryptedMatrix
{
    static string encryptedNumber = "";
    
    static void Main()
    {
        string message = Console.ReadLine();
        string matrixDirection = Console.ReadLine();

        string convertedMessage = "";
        for (int i = 0; i < message.Length; i++)
        {
            convertedMessage += (message[i] % 10);
        }

        for (int i = 0; i < convertedMessage.Length; i++)
        {
            string currentStrNum = convertedMessage[i].ToString();
            int convertedNum = int.Parse(currentStrNum);

            if ((convertedNum % 2 == 0) || convertedNum == 0)
            {
                encryptedNumber += (convertedNum * convertedNum);
            }
            else
            {
                CalcOddDigit(i, convertedMessage);
            }
        }

        if (matrixDirection == "\\")
        {
            PrintDiagonMatrix(matrixDirection);
        }
        else if (matrixDirection == "/")
        {
            PrintAntiDiagonMatrix(matrixDirection);
        }
        
    }
    private static void CalcOddDigit(int i, string convertedMessage)
    {
        if (i == 0 && (convertedMessage.Length >= 2))
        {
            string currentCh = convertedMessage[i].ToString();
            string nextCh = convertedMessage[i + 1].ToString();
            encryptedNumber += (int.Parse(currentCh) + int.Parse(nextCh));
        }
        else if (i == convertedMessage.Length - 1 && (convertedMessage.Length >= 2))
        {
            string previousCh = convertedMessage[i - 1].ToString();
            string currentCh = convertedMessage[i].ToString();
            encryptedNumber += (int.Parse(previousCh) + int.Parse(currentCh));
        }
        else if (i > 0 && (i < convertedMessage.Length) && (convertedMessage.Length >= 3))
        {
            string previousCh = convertedMessage[i - 1].ToString();
            string currentCh = convertedMessage[i].ToString();
            string nextCh = convertedMessage[i + 1].ToString();
            encryptedNumber += (int.Parse(previousCh) + int.Parse(currentCh) + int.Parse(nextCh));
        }
        else
        {
            string currentCh = convertedMessage[i].ToString();
            encryptedNumber += currentCh;
        }
    }

    private static void PrintDiagonMatrix(string matrixDirection)
    {
        int printCounter = 0;
        
        for (int row = 0; row < encryptedNumber.Length; row++)
        {
            for (int col = 0; col < encryptedNumber.Length; col++)
            {
                if (col == printCounter)
                {
                    Console.Write(encryptedNumber[row] + " ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
            printCounter++;
        }
    }

    private static void PrintAntiDiagonMatrix(string matrixDirection)
    {
        int printCounter = 0;

        for (int row = encryptedNumber.Length - 1; row >= 0; row--)
        {
            for (int col = encryptedNumber.Length - 1; col >= 0; col--)
            {
                if (col == printCounter)
                {
                    Console.Write(encryptedNumber[row] + " ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
            printCounter++;
        }
    }
}

