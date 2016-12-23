using System;

class ChristmasHat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 4 * n + 1;
        int height = 2 * n + 5;

        int dots = (width - 3) / 2;
        int asterisk = 2;
        int dash = 1;


        Console.WriteLine("{0}/|\\{0}", new string('.', dots));
        Console.WriteLine("{0}\\|/{0}", new string('.', dots));

        Console.WriteLine("{0}***{0}", new string('.', dots));

        dots--;

        for (int i = 0; i < n * 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', dots),
                new string('-', dash));

            dots--;
            dash++;
        }

        asterisk = width;

        Console.WriteLine("{0}", new string('*', asterisk));

        for (int i = 0; i < width / 2; i++)
        {
            Console.Write('*');
            Console.Write('.');
        }

        Console.WriteLine('*');

        Console.WriteLine("{0}", new string('*', asterisk));
    }
}

