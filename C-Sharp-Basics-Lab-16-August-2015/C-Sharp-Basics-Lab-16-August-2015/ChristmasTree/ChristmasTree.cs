using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = (n * 2) + 1;
        int treePartsHeight = (n / 2) + 1;

        int crownWidth = 1;
        int emptySpace = (width - crownWidth) / 2;

        for (int upperPart = 0; upperPart < treePartsHeight; upperPart++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('\'', emptySpace),
                new string('^', crownWidth));

            crownWidth += 2;
            emptySpace--;
        }

        crownWidth = 3;
        emptySpace = (width - crownWidth) / 2;

        for (int lowerPart = 0; lowerPart < treePartsHeight; lowerPart++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('\'', emptySpace),
                new string('^', crownWidth));

            crownWidth += 2;
            emptySpace--;
        }

        emptySpace = (width - 2) / 2;

        for (int stalk = 0; stalk < treePartsHeight; stalk++)
        {
            Console.WriteLine("{0}| |{0}", new string('\'', emptySpace));
        }

        Console.WriteLine(new string('-', width));
    }
}

