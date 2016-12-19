using System;

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int wandWidth = (3 * n) + 2;
        int upperPart = (n / 2 + 3);
        int middlePart = n;
        int lowerPart = n + 1;

        int dots = (wandWidth - 1) / 2;
        int dotsInStar = n / 2;
        int dotsBetweenStar = 0;
        int middleDots = 1;
        int asterisk = 0;

        Console.WriteLine("{0}*{0}", new string('.', dots));

        dots = (wandWidth - 3) / 2;

        for (int i = 0; i < upperPart - 1; i++)
        {
            if (i != upperPart - 2)
            {
                Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));

                dots--;
                middleDots += 2;
            }
            else
            {
                asterisk = n;
                Console.WriteLine("{0}{1}{0}",
                    new string('*', asterisk),
                    new string('.', middleDots));
            }
        }

        dots = 0;
        middleDots = wandWidth - ((dots * 2) + 2);

        for (int i = 0; i < middleDots - 1; i++)
        {
            if (i < n / 2)
            {
                dots++;
                middleDots -= 2;

                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', dots),
                    new string('.', middleDots));
            }
            else
            {
                middleDots = n;
                dots--;
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                    new string('.', dots),
                    new string('.', dotsInStar),
                    new string('.', dotsBetweenStar),
                    new string('.', middleDots));

                dotsBetweenStar++;
            }
        }

        asterisk = (n / 2) + 1;
        Console.WriteLine("{0}{1}*{2}*{1}{0}",
            new string('*', asterisk),
            new string('.', dotsBetweenStar),
            new string('.', middleDots));

        dots = n;

        for (int i = 0; i < lowerPart; i++)
        {
            if (i != lowerPart - 1)
            {
                Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));
            }
            else
            {
                asterisk = middleDots + 2;
                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('*', asterisk));
            }
        }
    }
}

