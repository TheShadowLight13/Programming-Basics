using System;

class StripedTowel
{
    static void Main()
    {
        int towelWidth = int.Parse(Console.ReadLine());

        int towelHeight = (int)Math.Floor(towelWidth * 1.5);

        for (int row = 0; row < towelHeight; row++)
        {
            bool isDot = false;
            bool isFirstOnlyOneDot = false;

            DrawCharacters(towelWidth, isDot, isFirstOnlyOneDot);
            row += 2;
            Console.WriteLine();

            if (row < towelHeight)
            {
                isDot = true;
                DrawCharacters(towelWidth, isDot, isFirstOnlyOneDot);
                Console.WriteLine();

                isDot = false;
                isFirstOnlyOneDot = true;

                DrawCharacters(towelWidth, isDot, isFirstOnlyOneDot);
                Console.WriteLine();
            }
        }
    }

    private static void DrawCharacters(int towelWidth, bool isDot,
        bool isFirstOnlyOneDot)
    {
     
        if (isFirstOnlyOneDot)
        {
            Console.Write('.');
            towelWidth -= 1;
        }
        
        for (int col = 0; col < towelWidth; col++)
        {
            if (isDot)
            {
                if (towelWidth - col >= 2)
                {
                    Console.Write('.');
                    Console.Write('.');
                    col++;
                }
                else
                {
                    Console.Write('.');
                }
            }
            else
            {
                Console.Write('#');
            }

            isDot = !isDot;
        }
    }
}

