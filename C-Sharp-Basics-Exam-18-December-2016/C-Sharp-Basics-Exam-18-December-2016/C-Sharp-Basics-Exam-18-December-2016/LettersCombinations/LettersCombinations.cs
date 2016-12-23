using System;

class LettersCombinations
{
    static void Main()
    {
        char startLetter = char.Parse(Console.ReadLine());
        char endLetter = char.Parse(Console.ReadLine());
        char forbiddenLetter = char.Parse(Console.ReadLine());

        int wordsCount = 0;

        for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
        {
            for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
            {
                for (char thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                {
                    string lettersToPrint = string.Format("{0}{1}{2}",
                        firstLetter, secondLetter, thirdLetter);

                    if (!lettersToPrint.Contains(forbiddenLetter.ToString()))
                    {
                        Console.Write(lettersToPrint);
                        Console.Write(" ");
                        wordsCount++;
                    }
                }
            }
        }

        Console.WriteLine(wordsCount);
    }
}

