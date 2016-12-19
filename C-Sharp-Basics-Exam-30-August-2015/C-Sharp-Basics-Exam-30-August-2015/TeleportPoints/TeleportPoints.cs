using System;
using System.Linq;

class TeleportPoints
{
    static void Main()
    {
        double[] aCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray(); 
        double aXCoordinate = aCoordinates[0];
        double aYCoordinate = aCoordinates[1];

        double[] bCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double bXCoordinate = bCoordinates[0];
        double bYCoordinate = bCoordinates[1];

        double[] cCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double cXCoordinate = cCoordinates[0];
        double cYCoordinate = cCoordinates[1];

        double[] dCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double dXCoordinate = dCoordinates[0];
        double dYCoordinate = dCoordinates[1];

        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        int pointCounter = 0;

        // check right side
        for (double x = 0; x <= radius; x += step)
        {
            // check upper quadrant
            for (double y = 0; y <= radius; y += step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aXCoordinate && x < bXCoordinate) 
                        && (y < cYCoordinate && y > bYCoordinate))
                    {
                        pointCounter++;
                    }
                }
            }

            // check lower quadrant
            for (double y = -step; y >= -radius; y -= step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aXCoordinate && x < bXCoordinate) 
                        && (y < cYCoordinate && y > bYCoordinate))
                    {
                        pointCounter++;
                    }
                }
            }
        }

        // check left side
        for (double x = -step; x >= -radius; x -= step)
        {
            // check upper quadrant
            for (double y = 0; y <= radius; y += step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aXCoordinate && x < bXCoordinate) 
                        && (y < cYCoordinate && y > bYCoordinate))
                    {
                        pointCounter++;
                    }
                }
            }

            // check lower quadrant
            for (double y = -step; y >= -radius; y -= step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aXCoordinate && x < bXCoordinate) 
                        && (y < cYCoordinate && y > bYCoordinate))
                    {
                        pointCounter++;
                    }
                }
            }
        }

        Console.WriteLine(pointCounter);
    }
}

