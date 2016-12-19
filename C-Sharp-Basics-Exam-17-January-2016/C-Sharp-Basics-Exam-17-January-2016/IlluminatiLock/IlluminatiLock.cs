using System;

class IlluminatiLock
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int eyeHeight = n + 1;
        int eyeWidth = 3 * n;
        int eyeUpperSide = (eyeHeight - 6) / 2;
        int eyeLowerSide = (eyeHeight - 6) / 2;

        int dots = n - 2;
        int numberSign = 3;
        int middleDots = n - 2;
        int dotsBetweeenNumberSign = 0;

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', dots),
            new string('#', numberSign),
            new string('.', middleDots));


        dots = n - 4;
        middleDots = n - 2;
        dotsBetweeenNumberSign = (eyeWidth - ((2 * dots) + middleDots + 6)) / 2;

        for (int i = 0; i < eyeUpperSide; i++)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}",
                new string('.', dots),
                new string('.', dotsBetweeenNumberSign),
                new string('.', middleDots));

            dots -= 2;
            dotsBetweeenNumberSign += 2;

        }

        dots = 1;
        middleDots = n - 2;
        dotsBetweeenNumberSign = (eyeWidth - ((2 * dots) + middleDots + 6)) / 2;

        Console.WriteLine("{0}##{1}#{2}#{1}##{0}",
            new string('.', dots),
            new string('.', dotsBetweeenNumberSign),
            new string('.', middleDots));

        Console.WriteLine("{0}##{1}#{2}#{1}##{0}",
          new string('.', dots),
          new string('.', dotsBetweeenNumberSign),
          new string('.', middleDots));

        dots = 3;
        middleDots = n - 2;
        dotsBetweeenNumberSign = (eyeWidth - ((2 * dots) + middleDots + 6)) / 2;

        for (int i = 0; i < eyeLowerSide; i++)
        {
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}",
                new string('.', dots),
                new string('.', dotsBetweeenNumberSign),
                new string('.', middleDots));

            dots += 2;
            dotsBetweeenNumberSign -= 2;

        }

        dots = n - 2;
        middleDots = n - 2;
        numberSign = 3;

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', dots),
            new string('#', numberSign),
            new string('.', middleDots));

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
    }
}

