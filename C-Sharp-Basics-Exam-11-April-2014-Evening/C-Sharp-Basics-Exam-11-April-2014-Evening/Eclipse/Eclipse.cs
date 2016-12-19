using System;

class Eclipse
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int emptySpace = height - 1;
        int asterisk = (height * 2) - 2;
        int slash = (height * 2) - 2;
        int dash = height - 1;

        Console.WriteLine(" {0} {1} {0} ",
            new string('*', asterisk),
            new string(' ', emptySpace));

        for (int i = 0; i < height - 2; i++)
        {
            if (i == ((height - 2) / 2))
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                new string('/', slash),
                new string('-', dash));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                new string('/', slash),
                new string(' ', emptySpace));
            }
        }

        Console.WriteLine(" {0} {1} {0} ",
           new string('*', asterisk),
           new string(' ', emptySpace));
    }
}

