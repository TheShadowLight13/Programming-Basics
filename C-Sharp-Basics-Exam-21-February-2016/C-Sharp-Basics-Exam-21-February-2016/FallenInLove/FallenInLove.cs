using System;

class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = (n * 4) + 6;

        int dots = (width - 6) / 2;
        int middleDots = 0;
        int tilda = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                new string('~', tilda), 
                new string('.', dots),
                new string('.', middleDots));

            tilda++;
            dots -= 2;
            middleDots += 2;
        }

        dots = 1;
        tilda = n;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                new string('.', dots),
                new string('~', tilda),
                new string('.', middleDots));

            dots += 2;
            tilda--;
            middleDots -= 2;
        }

        dots = (width - 4) / 2;
        Console.WriteLine("{0}####{0}", new string('.', dots));

        dots = (width - 2) / 2;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}##{0}", new string('.', dots));
        }
    }
}

