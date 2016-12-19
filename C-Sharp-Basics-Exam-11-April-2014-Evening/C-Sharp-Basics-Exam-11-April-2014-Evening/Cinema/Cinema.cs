using System;
using System.Threading;
using System.Globalization;

class Cinema
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        string filmType = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int column = int.Parse(Console.ReadLine());
        int peopleInHall = row * column;

        switch (filmType)
        {
            case "Normal":
                Console.WriteLine("{0:F2} leva", peopleInHall * 7.50);
                break;
            case "Premiere":
                Console.WriteLine("{0:F2} leva", peopleInHall * 12.00);
                break;
            case "Discount":
                Console.WriteLine("{0:F2} leva", peopleInHall * 5.00);
                break;
        }
    }
}

