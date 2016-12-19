using System;
using System.Numerics;

class GameOfPetar
{
    static void Main()
    {
        BigInteger startNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger endNumber = BigInteger.Parse(Console.ReadLine());
        string replacementStr = Console.ReadLine();

        BigInteger sum = 0;

        while (startNumber != endNumber)
        {
            if (startNumber % 5 == 0)
            {
                sum += startNumber;
            }
            else
            {
                sum += (startNumber % 5);
            }
            startNumber++;
        }

        string strSum = sum.ToString();
        string digitToReplace;

        if (sum % 2 == 0)
        {
            digitToReplace = strSum[0].ToString();
        }
        else
        {
            digitToReplace = strSum[strSum.Length - 1].ToString();
        }

        strSum = strSum.Replace(digitToReplace, replacementStr);

        Console.WriteLine(strSum);
    }
}

