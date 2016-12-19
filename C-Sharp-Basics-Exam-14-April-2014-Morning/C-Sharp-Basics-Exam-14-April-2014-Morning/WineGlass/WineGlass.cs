using System;

class WineGlass
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int dots = 1;
        int asterisk = height - 4;
        int stemHeight = (height >= 12) ? (height / 2 - 2) : (height / 2 - 1);
        int endBottom = height - ((height / 2) + stemHeight);

        Console.WriteLine("\\{0}/", new string('*', height - 2));
        
        for (int i = 0; i < height / 2 - 1; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}",
                new string('.', dots),
                new string('*', asterisk));

            dots++;
            asterisk -= 2;

        }

        dots = (height / 2) - 1;
        for (int i = 0; i < stemHeight; i++)
        {
            Console.WriteLine("{0}||{0}", new string('.', dots));
        }

        for (int i = 0; i < endBottom; i++)
        {
            Console.WriteLine("{0}", new string('-', height));
        }
    }
}

