using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int lineWidth = n * 3;
        int sunBeamLength = n - 1;
        int sunBeamBase = n / 2;
        
        int dots = (lineWidth - 1) / 2;
        int middleDots = 0;
        int asterisk = 1;

        Console.WriteLine("{0}*{0}", new string('.', dots));

        dots = 1;
        middleDots = (lineWidth - ((2 * dots) + 3)) / 2;

        for (int i = 0; i < sunBeamLength; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));

            dots++;
            middleDots--;
        }

        dots = (lineWidth - n) / 2;
        asterisk = n;
        
        for (int i = 0; i < sunBeamBase; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', dots),
                new string('*', asterisk));
        }

        asterisk = lineWidth;
        Console.WriteLine(new string('*', asterisk));

        asterisk = n;
        
        for (int i = 0; i < sunBeamBase; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', dots),
                new string('*', asterisk));
        }

        dots--;
        middleDots = (lineWidth - ((2 * dots) + 3)) / 2;

        for (int i = 0; i < sunBeamLength; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));

            dots--;
            middleDots++;
        }

        dots = (lineWidth - 1) / 2;
        Console.WriteLine("{0}*{0}", new string('.', dots));

    }
}

