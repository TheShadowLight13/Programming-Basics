using System;

class Diamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int width = 5 * n;
        int height = (3 * n) + 2;

        int dots = n - 1;
        int middleDots = width - (n * 2);

        int upperPart = n - 1;
        int downPart = height - (upperPart + 3);

        Console.WriteLine("{0}{1}{0}",
            new string('.', n), new string('*', width - (n * 2)));

        for (int i = 0; i < upperPart; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots), new string('.', middleDots));
            dots--;
            middleDots += 2;
        }

        Console.WriteLine(new string('*', width));

        dots = 1;
        middleDots = width - 4;

        for (int i = 0; i < downPart; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots), new string('.', middleDots));
            dots++;
            middleDots -= 2;
        }

        middleDots += 2;
        dots = (width - middleDots) / 2;

        Console.WriteLine("{0}{1}{0}", 
            new string('.', dots), new string('*', middleDots));
    }
}

