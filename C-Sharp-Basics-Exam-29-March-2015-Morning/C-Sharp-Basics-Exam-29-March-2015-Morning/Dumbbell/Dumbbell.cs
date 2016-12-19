using System;

class Dumbbell
{
    static void Main()
    {
        int dumbbellHeight = int.Parse(Console.ReadLine());

        int upperHeight = dumbbellHeight / 2;
        int lowerHeight = dumbbellHeight / 2;

        int dots = dumbbellHeight / 2;
        int ampersand = dots + 1;
        int asterisk = 0;
        int middleDots = dumbbellHeight;
        int equally = dumbbellHeight;

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', dots),
            new string('&', ampersand),
            new string('.', middleDots));

        asterisk = dumbbellHeight / 2;
        dots = ((3 * dumbbellHeight) - ((2 * 2) + (2 * asterisk) + middleDots)) / 2;
        
        for (int i = 0; i < upperHeight - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', dots),
                new string('*', asterisk),
                new string('.', middleDots));

            asterisk++;
            dots--;
        }

        Console.WriteLine("&{0}&{1}&{0}&",
            new string('*', asterisk),
            new string('=', equally));
        
        for (int i = 0; i < lowerHeight - 1; i++)
        {
            dots++;
            asterisk--;

            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', dots),
                new string('*', asterisk),
                new string('.', middleDots));
        }

        dots++;
        ampersand = dots + 1;

        Console.WriteLine("{0}{1}{2}{1}{0}", 
            new string('.', dots),
            new string('&', ampersand),
            new string('.', middleDots));
    }
}

