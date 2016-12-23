using System;

class Rocket
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 3*n;

        int dots = (width - 2) / 2;
        int emptySpace = 0;
        int asterisk = 0;
        int slash = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}", 
                new string('.', dots), 
                new string(' ', emptySpace));
            dots--;
            emptySpace += 2;
        }

        dots = n/2;
        asterisk = width - (dots*2);

        Console.WriteLine("{0}{1}{0}",
            new string('.', dots),
            new string('*', asterisk));

        slash = width - ((dots*2) + 2);

        for (int i = 0; i < n * 2; i++)
        {
            Console.WriteLine("{0}|{1}|{0}",
                new string('.', dots),
                new string('\\', slash));
        }

        asterisk = slash;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}",
                new string('.', dots),
                new string('*', asterisk));

            dots--;
            asterisk += 2;
        }
    }
}

