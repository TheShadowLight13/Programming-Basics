using System;

class AceOfDiamonds
{
    static void Main()
    {
        uint width = uint.Parse(Console.ReadLine());
        uint height = width;

        Console.WriteLine(new string('*', (int)width));

        uint middlePartHeight = height - 2;

        uint dash = (width - 3) / 2;
        uint atSymbol = 1;

        for (int row = 0; row < middlePartHeight; row++)
        {

            Console.WriteLine("*{0}{1}{0}*",
            new string('-', (int)dash),
            new string('@', (int)atSymbol));

            if (row >= middlePartHeight / 2)
            {
                atSymbol -= 2;
                dash++;
            }
            else
            {
                atSymbol += 2;
                dash--;
            }

        }

        Console.WriteLine(new string('*', (int)width));
    }
}

