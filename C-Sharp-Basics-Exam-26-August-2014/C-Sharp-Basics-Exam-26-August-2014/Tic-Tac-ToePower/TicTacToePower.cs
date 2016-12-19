using System;

class TicTacToePower
{
    static void Main()
    {
        int xCoordinate = int.Parse(Console.ReadLine());
        int yCoordinate = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine()) - 1;

        int index = 0;

        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                n++;
                index++;

                if ((row == yCoordinate) && (column == xCoordinate))
                {
                    ulong finalResult = (ulong)(Math.Pow(n, index));
                    Console.WriteLine(finalResult);
                    return;
                }
            }
        }
    }
}

