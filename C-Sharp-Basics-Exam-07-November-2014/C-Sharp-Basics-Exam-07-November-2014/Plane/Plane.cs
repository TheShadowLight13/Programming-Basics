using System;

class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int planeWidth = 3 * n;
        int noseHeight = n + 1;
        int wingsHeight = n / 2;
        int wingsCurveHeight = (n / 2) - 1;
        int backSideHeight = n;

        int dots = (planeWidth - 1) / 2;
        int middleDots = 1;
        int dotsInWings = 0;
        int dotsBetweenWings = 0;
        int asterisk = 1;

        Console.WriteLine("{0}*{0}", new string('.', dots));

        dots = (planeWidth - 3) / 2;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));

            if (i >= n - wingsCurveHeight - 1)
            {
                dots -= 2;
                middleDots += 4;
            }
            else
            {
                dots--;
                middleDots += 2;
            } 
            
        }

        dotsInWings = (planeWidth - n - 4) / 2;
        middleDots = n;
        
        Console.WriteLine("*{0}*{1}*{0}*",
            new string('.', dotsInWings),
            new string('.', middleDots));

        dotsBetweenWings = 1;
        dotsInWings = (planeWidth - (middleDots + (dotsBetweenWings * 2) + 6)) / 2;
        
        for (int i = 0; i < wingsHeight - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                new string('.', dotsInWings),
                new string('.', dotsBetweenWings),
                new string('.', middleDots));

            dotsBetweenWings += 2;
            dotsInWings -= 2;
        }

        dots = (planeWidth - middleDots - 2) / 2;
        
        for (int i = 0; i < backSideHeight - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', dots),
                new string('.', middleDots));

            dots--;
            middleDots += 2;
        }

        asterisk = planeWidth;
        Console.WriteLine(new string('*', asterisk));
    }
}

