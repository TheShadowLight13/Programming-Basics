using System;

class HouseWithWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int houseWidth = (2 * n) - 1;
        int houseHeight = (2 * n) + 2;
        int roofHeight = n;
        int houseBaseHeight = n + 2;
        int windowHeight = n / 2;
        int windowWidth = n - 3;
        
        int dots = (houseWidth - 1) / 2;
        int middleDots = 1;
        int asterisk = 1;

        Console.WriteLine("{0}*{0}", new string('.', dots));
        
        dots = (houseWidth - 2 - middleDots) / 2;
        for (int i = 0; i < roofHeight - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', dots),
                new string('*', asterisk),
                new string('.', middleDots));
            
            dots--;
            middleDots += 2;
        }

        Console.WriteLine(new string('*', houseWidth));

        dots = houseWidth - 2;
        for (int i = 0; i < houseBaseHeight - 2; i++)
        {

            if (((n - windowHeight) / 2) == i)
            {
                dots = (houseWidth - 2 - windowWidth) / 2;
                asterisk = windowWidth;
                
                for (int j = 0; j < windowHeight; j++)
                {
                    Console.WriteLine("*{0}{1}{0}*",
                        new string('.', dots),
                        new string('*', asterisk));
                }
                i += windowHeight - 1;
                
            }
            else
            {
                dots = houseWidth - 2;
                Console.WriteLine("*{0}*", new string('.', dots));
            }
            
        }

        
        Console.WriteLine(new string('*', houseWidth));
    }
}

