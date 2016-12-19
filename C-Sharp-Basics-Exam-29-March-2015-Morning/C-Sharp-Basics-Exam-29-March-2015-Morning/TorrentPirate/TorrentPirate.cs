using System;

class TorrentPirate
{
    static void Main()
    {
        long downloadData = long.Parse(Console.ReadLine());
        long moviePrice = long.Parse(Console.ReadLine());
        long wifeSpending = long.Parse(Console.ReadLine());

        const double downloadSpeed = 2;
        const double filmSize = 1500;

        double downloadTime = (downloadData / downloadSpeed) / 3600;
        double downloadPrice = downloadTime * wifeSpending;
        double moviesDownloaded = downloadData / filmSize;
        double cinemaPrice = moviesDownloaded * moviePrice;

        if (downloadPrice <= cinemaPrice)
        {
            Console.WriteLine("mall -> {0:F2}lv", downloadPrice);
        }
        else
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }

    }
}

