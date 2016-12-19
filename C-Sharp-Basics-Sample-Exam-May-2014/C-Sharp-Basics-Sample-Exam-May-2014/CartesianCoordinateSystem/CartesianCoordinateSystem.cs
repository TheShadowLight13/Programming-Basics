using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        decimal xCoordinate = decimal.Parse(Console.ReadLine());
        decimal yCoordinate = decimal.Parse(Console.ReadLine());

        if (xCoordinate == 0 && yCoordinate == 0)
        {
            Console.WriteLine("0");
        }
        else if (xCoordinate > 0 && yCoordinate > 0)
        {
            Console.WriteLine("1");
        }
        else if (xCoordinate < 0 && yCoordinate > 0)
        {
            Console.WriteLine("2");
        }
        else if (xCoordinate < 0 && yCoordinate < 0)
        {
            Console.WriteLine("3");
        }
        else if (xCoordinate > 0 && yCoordinate < 0)
        {
            Console.WriteLine("4");
        }
        else if (xCoordinate == 0)
        {
            Console.WriteLine("5");
        }
        else if (yCoordinate == 0)
        {
            Console.WriteLine("6");
        }
    }
}

