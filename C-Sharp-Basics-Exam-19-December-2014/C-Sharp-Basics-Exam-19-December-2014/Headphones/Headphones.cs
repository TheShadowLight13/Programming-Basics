using System;

class Headphones
{
    static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());

        int width = (diameter * 2) + 1;
        int asterisk = diameter + 2;
        int dash = (width - asterisk) / 2;
        int middleDash = 0;

        Console.WriteLine("{0}{1}{0}",
            new string('-', dash),
            new string('*', asterisk));

        middleDash = asterisk - 2;
        dash = (width - (middleDash + 2)) / 2;

        for (int i = 0; i < diameter - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', dash),
                new string('-', middleDash));
        }

        asterisk = 1;
        bool isEqualDiameter = false;

        for (int i = 0; i < diameter; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('-', dash),
                new string('*', asterisk),
                new string('-', middleDash));

            if (asterisk == diameter)
            {
                isEqualDiameter = true;
            }

            if (isEqualDiameter)
            {
                dash++;
                middleDash += 2;
                asterisk -= 2;
            }
            else
            {
                dash--;
                middleDash -= 2;
                asterisk += 2;
            }
        }
    }
}

