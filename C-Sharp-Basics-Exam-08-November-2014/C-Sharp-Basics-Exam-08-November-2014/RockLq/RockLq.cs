using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int upperHeight = (n / 2) + 1;
        int wingsHeight = n / 2;
        int lowerHeight = (2 * n) - upperHeight - wingsHeight;

        int dots = n;
        int middleDots = dots + 2;
        int dotsInWings = 0;
        int dotsBetweenWings = 0;
        int asterisk = n;

        Console.WriteLine("{0}{1}{0}", 
            new string('.', n),
            new string('*', n));

        dots = dots - 2;
        for (int i = 0; i < upperHeight - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));
            
            dots -= 2;
            middleDots += 4;
        }

        middleDots = n;
        dotsInWings = (width - (middleDots + 4)) / 2;
        
        Console.WriteLine("*{0}*{1}*{0}*",
            new string('.', dotsInWings),
            new string('.', middleDots));

        dotsInWings -= 2;
        dotsBetweenWings = 1;
        for (int i = 0; i < wingsHeight - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                new string('.', dotsInWings),
                new string('.', dotsBetweenWings),
                new string('.', middleDots));

            dotsInWings -= 2;
            dotsBetweenWings += 2;
        }

        dots = (width - (middleDots + 2)) / 2;
        
        for (int i = 0; i < lowerHeight - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));

            dots--;
            middleDots += 2;
        }

        asterisk = width;
        Console.WriteLine(new string('*', asterisk));
    }
}

