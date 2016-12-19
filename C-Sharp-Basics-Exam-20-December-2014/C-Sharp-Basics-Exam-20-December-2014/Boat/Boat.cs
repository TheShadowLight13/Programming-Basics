using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sailHeight = n;
        int bodyHeight = (n - 1) / 2;
        
        int asterisk = 1;
        int leftDots = (2 * n) - n - 1;
        int rightDots = (2 * n) - leftDots - 1;

        for (int top = 0; top < sailHeight; top++)
        {
            Console.WriteLine("{0}{1}{2}",
                new string('.', leftDots),
                new string('*', asterisk),
                new string('.', rightDots));

            if (top < sailHeight / 2)
            {
                asterisk += 2;
                leftDots -= 2;
            }
            else
            {
                asterisk -= 2;
                leftDots += 2;
            }            
        }

        asterisk = 2 * n;
        Console.WriteLine(new string('*', asterisk));

        leftDots = 1;
        rightDots = 1;
        asterisk = (2 * n) - leftDots - rightDots;
        
        for (int body = 0; body < bodyHeight - 1; body++)
        {
            Console.WriteLine("{0}{1}{2}",
                new string('.', leftDots),
                new string('*', asterisk),
                new string('.', rightDots));

            asterisk -= 2;
            leftDots++;
            rightDots++;
        }

    }
}

