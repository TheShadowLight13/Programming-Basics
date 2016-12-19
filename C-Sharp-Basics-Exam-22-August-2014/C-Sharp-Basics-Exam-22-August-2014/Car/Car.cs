using System;

class Car
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int carWidth = 3 * n;
        int roofHeight = n / 2;
        int bodyHeight = n / 2;
        int carWheelsHeight = (n / 2) - 1;
        int dots = n - 1;
        int midddleDots = (carWidth - 2 - (dots * 2));
        int dotsInWheel = 0;
        int asterisk = 1;

        Console.WriteLine("{0}{1}{0}",
                   new string('.', n),
                   new string('*', n));

        for (int roof = 0; roof < roofHeight - 1; roof++)
        {

            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', midddleDots));

            dots--;
            midddleDots += 2;
        }

        asterisk = (n / 2) + 1;
        dots = carWidth - (2 * asterisk);
        
        Console.WriteLine("{0}{1}{0}",
                 new string('*', asterisk),
                 new string('.', dots));


        asterisk = 1;
        dots = carWidth - (2 * asterisk);
        for (int body = 0; body < bodyHeight - 1; body++)
        {
            
            if (body == bodyHeight - 2)
            {
                asterisk = carWidth;
                Console.WriteLine("{0}", new string('*', asterisk));
            }
            else
            {
                Console.WriteLine("*{0}*", new string('.', dots));
            }
        }

        dots = n / 2;
        midddleDots = n - 2;
        dotsInWheel = (carWidth - ((dots * 2) + midddleDots + 4)) / 2;

        for (int carWheel = 0; carWheel < carWheelsHeight - 1; carWheel++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                new string('.', dots),
                new string('.', dotsInWheel),
                new string('.', midddleDots));
        }

        asterisk = dotsInWheel + 2;        
        Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', dots),
                new string('*', asterisk),
                new string('.', midddleDots));
    }
}

