using System;

class Axe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 5 * n;

        int asterisk = 0;
        int leftDash = 3 * n;
        int middleDash = 0;
        int rightDash = width - (leftDash + 2);

        // Print front part of axe
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDash),
                new string('-', middleDash),
                new string('-', rightDash));

            if (i != n - 1)
            {
                middleDash++;
                rightDash--;
            }
        }

        asterisk = leftDash;

        // Print handle of axe
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('*', asterisk),
                new string('-', middleDash),
                new string('-', rightDash));
        }


        // Print back part of axe
        for (int i = 0; i < n / 2; i++)
        {
            if (i != n / 2 - 1)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDash),
                    new string('-', middleDash),
                    new string('-', rightDash));
            }
            else
            {
                asterisk = middleDash;

                Console.WriteLine("{0}*{1}*{2}",
                   new string('-', leftDash),
                   new string('*', asterisk),
                   new string('-', rightDash));
            }

            leftDash--;
            middleDash += 2;
            rightDash--;

        }
    }
}

