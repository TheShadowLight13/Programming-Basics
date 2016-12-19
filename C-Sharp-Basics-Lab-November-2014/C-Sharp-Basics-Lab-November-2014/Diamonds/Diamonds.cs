using System;

class Diamonds
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());

        int dash = (width - 1) / 2;
        int middleDash = 1;
        int upperPart = (width - 3) / 2;
        int lowerPart = (width - 3) / 2;

        Console.WriteLine("{0}*{0}", new string('-', dash));

        dash = (width - 3) / 2;

        for (int upperRow = 0; upperRow < upperPart; upperRow++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', dash),
                new string('-', middleDash));

                dash--;
                middleDash += 2;    
        }

        dash = width - 2;
        Console.WriteLine("*{0}*", new string('-', dash));

        dash = 1;
        middleDash = width - (2 + 2 * dash);

        for (int lowerRow = 0; lowerRow < lowerPart; lowerRow++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', dash),
                new string('-', middleDash));

            dash++;
            middleDash -= 2;
        }

        dash = (width - 1) / 2;
        Console.WriteLine("{0}*{0}", new string('-', dash));
    }
}

