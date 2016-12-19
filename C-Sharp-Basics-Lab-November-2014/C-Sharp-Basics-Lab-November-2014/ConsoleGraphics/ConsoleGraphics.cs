using System;

class ConsoleGraphics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2;

        Console.WriteLine(new string('*', width));
        Console.WriteLine(new string('*', width));

        int columnHeight = n - 1;
        int columnWidth = (n / 2) + 1;
        int emptySpace = width - (2 * columnWidth);

        for (int i = 0; i < columnHeight; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('*', columnWidth),
                new string(' ', emptySpace));
        }

        Console.WriteLine(new string('~', width));
        Console.WriteLine(new string('~', width));
    }
}

