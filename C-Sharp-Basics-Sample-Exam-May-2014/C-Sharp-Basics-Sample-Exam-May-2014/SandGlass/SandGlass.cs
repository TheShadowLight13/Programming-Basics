using System;

class SandGlass
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int dots = 0;
        int asterisk = height;

        Console.WriteLine("{0}", new string('*', height));

        for (int i = 0; i < height - 2; i++)
        {
            if (i < height / 2)
            {
                dots++;
                asterisk -= 2;

                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('*', asterisk));

            }
            else
            {
                dots--;
                asterisk += 2;

                Console.WriteLine("{0}{1}{0}",
                  new string('.', dots),
                  new string('*', asterisk));

            }
        }

        Console.WriteLine("{0}", new string('*', height));
    }
}

