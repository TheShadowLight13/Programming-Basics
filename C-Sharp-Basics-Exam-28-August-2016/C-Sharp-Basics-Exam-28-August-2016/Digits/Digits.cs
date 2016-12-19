using System;

class Digits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int rowsCount = (number / 100) + (number % 100 / 10);
        int colsCount = (number / 100) + (number % 10);

        int currentNum = number;

        for (int row = 0; row < rowsCount; row++)
        {
            for (int col = 0; col < colsCount; col++)
            {
                if (currentNum % 5 == 0)
                {
                    currentNum -= (number / 100);
                }
                else if (currentNum % 3 == 0)
                {
                    currentNum -= (number % 100 / 10);
                }
                else
                {
                    currentNum += (number % 10);
                }
                Console.Write("{0} ", currentNum);
            }
            Console.WriteLine();
        }
    }
}

