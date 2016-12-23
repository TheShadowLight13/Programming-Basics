using System;

class Flowers
{
    static void Main()
    {
        int chrysanthemumsCount = int.Parse(Console.ReadLine());
        int rosesCount = int.Parse(Console.ReadLine());
        int tulipsCount = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        bool isHoliday = Console.ReadLine().Equals("Y");

        decimal chrysanthemumsPrice = 0;
        decimal rosesPrice = 0;
        decimal tulipsPrice = 0;

        decimal totalPrice = 0;

        switch (season)
        {
            case "Spring":
            case "Summer":

                chrysanthemumsPrice = 2.00M;
                rosesPrice = 4.10M;
                tulipsPrice = 2.50M;

                break;

            case "Autumn":
            case "Winter":

                chrysanthemumsPrice = 3.75M;
                rosesPrice = 4.50M;
                tulipsPrice = 4.15M;
            
                break;
        }

        totalPrice = (chrysanthemumsCount * chrysanthemumsPrice) + (rosesCount * rosesPrice) +
                                 (tulipsCount * tulipsPrice);

        if (isHoliday)
        {
            totalPrice = totalPrice + (totalPrice * 0.15M);
        }

        if (tulipsCount > 7 && season.Equals("Spring"))
        {
            totalPrice = totalPrice - (totalPrice * 0.05M);
        }

        if (rosesCount >= 10 && season.Equals("Winter"))
        {
            totalPrice = totalPrice - (totalPrice * 0.10M);
        }

        if (chrysanthemumsCount + rosesCount + tulipsCount > 20)
        {
            totalPrice = totalPrice - (totalPrice * 0.20M);
        }

        totalPrice += 2;

        Console.WriteLine("{0:F2}", totalPrice);

    }
}

