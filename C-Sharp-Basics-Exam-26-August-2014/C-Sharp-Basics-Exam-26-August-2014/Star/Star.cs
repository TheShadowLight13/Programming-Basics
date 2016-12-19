using System;

class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int starWidth = (2 * n) + 1;
        int topHeight = n / 2;
        int middleHeight = n / 2;
        int legsHeight = (n / 2) + 1;

        int asterisk = 0;
        int dots = (starWidth - 1) / 2;
        int middleDots = 0;
        int dotsInLegs = 0;

        Console.WriteLine("{0}*{0}", new string('.', dots));

        dots = (starWidth - 3) / 2;
        middleDots = 1;
        
        for (int i = 0; i < topHeight - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", 
                new string('.', dots),
                new string('.', middleDots));
            
            dots--;
            middleDots += 2;
        }
        
        asterisk = (n / 2) + 1;
        dots = starWidth - (2 * asterisk);
        Console.WriteLine("{0}{1}{0}", 
            new string('*', asterisk),
            new string('.', dots));

        dots = 1;
        middleDots = starWidth - 4;

        for (int i = 0; i < middleHeight - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));
            
            dots++;
            middleDots -= 2;
        }

        dots = n / 2;
        dotsInLegs = (starWidth - (dots * 2) - 3) / 2;
        Console.WriteLine("{0}*{1}*{1}*{0}",
            new string('.', dots),
            new string('.', dotsInLegs));

        dots--;
        middleDots = 1;
        
        for (int i = 0; i < legsHeight - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
            new string('.', dots),
            new string('.', dotsInLegs),
            new string('.', middleDots));

            dots--;
            middleDots += 2;
        }
        asterisk = (n / 2) + 1;
        dots = starWidth - (2 * asterisk);
        
        Console.WriteLine("{0}{1}{0}",
            new string('*', asterisk),
            new string('.', dots));
    }
}

