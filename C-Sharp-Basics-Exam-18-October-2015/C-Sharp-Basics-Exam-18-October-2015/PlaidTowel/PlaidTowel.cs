using System;

class PlaidTowel
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char backgroundSymbol = char.Parse(Console.ReadLine());
        char rhombusSymbol = char.Parse(Console.ReadLine());

        const int towelParts = 2;
        
        int towelHeight = (size * 4) + 1;
        int towelWidth = towelHeight;
        int upperSideLength = (towelHeight / 2);

        int backgroundSymbolSide = size;
        int backgroundSymbolInRhombus = 1;
        int backgroundSymbolMiddleSide = towelWidth - ((2 * backgroundSymbolSide) + 2);


        Console.WriteLine("{0}{1}{2}{1}{0}",
                   new string(backgroundSymbol, backgroundSymbolSide), rhombusSymbol,
                   new string(backgroundSymbol, backgroundSymbolMiddleSide));

        backgroundSymbolSide = size - 1;
        backgroundSymbolMiddleSide = towelWidth - ((2 * backgroundSymbolSide) + 4 + 
            (2 * backgroundSymbolInRhombus));

        for (int i = 0; i < towelParts; i++)
        {
            
            backgroundSymbolSide = size - 1;
            backgroundSymbolInRhombus = 1;
            backgroundSymbolMiddleSide = towelWidth - ((2 * backgroundSymbolSide) + 4 +
                (2 * backgroundSymbolInRhombus));
                
            for (int upperSide = 0; upperSide < upperSideLength; upperSide++)
            {

                if (upperSide == size - 1)
                {
                    Console.WriteLine("{0}{1}{0}{1}{0}", rhombusSymbol,
                        new string(backgroundSymbol, backgroundSymbolInRhombus));

                }
                else if ((upperSide < size - 1) || (upperSide > size - 1 && upperSide < upperSideLength - 1))
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                   new string(backgroundSymbol, backgroundSymbolSide), rhombusSymbol,
                   new string(backgroundSymbol, backgroundSymbolInRhombus),
                   new string(backgroundSymbol, backgroundSymbolMiddleSide));
                }
                else if (upperSide == upperSideLength - 1)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string(backgroundSymbol, size), rhombusSymbol,
                        new string(backgroundSymbol, backgroundSymbolMiddleSide));
                }

                if (upperSide >= size - 1)
                {
                    backgroundSymbolSide++;
                    backgroundSymbolInRhombus -= 2;
                    backgroundSymbolMiddleSide += 2;
                }
                else
                {
                    backgroundSymbolSide--;
                    backgroundSymbolInRhombus += 2;
                    backgroundSymbolMiddleSide -= 2;
                }
            }
        }
    }
}

