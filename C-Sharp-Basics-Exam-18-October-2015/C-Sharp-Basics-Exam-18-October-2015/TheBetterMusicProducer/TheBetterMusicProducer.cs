using System;

class TheBetterMusicProducer
{
    static void Main()
    {
        int soldAlbumsEurope = int.Parse(Console.ReadLine());
        double albumPriceInEuro = double.Parse(Console.ReadLine());

        int soldAlbumsNorthAmerica = int.Parse(Console.ReadLine());
        double albumPriceInDollars = double.Parse(Console.ReadLine());

        int soldAlbumsSouthAmerica = int.Parse(Console.ReadLine());
        double albumPriceInPesos = double.Parse(Console.ReadLine());

        int concertsNumber = int.Parse(Console.ReadLine());
        double profitPerConcertInEuro = double.Parse(Console.ReadLine());

        double allAlbumsIncome = (soldAlbumsEurope * albumPriceInEuro * 1.94) +
            (soldAlbumsNorthAmerica * albumPriceInDollars * 1.72) + 
            ((soldAlbumsSouthAmerica * albumPriceInPesos) / 332.74);
        
        double albumsProducerTaxes = allAlbumsIncome * 0.35;
        double albumsIncomeOtherTaxes = (allAlbumsIncome - albumsProducerTaxes) * 0.2;
        
        double allAlbumsProfit = allAlbumsIncome - (albumsProducerTaxes + albumsIncomeOtherTaxes);
        double concertsProfit = (concertsNumber * profitPerConcertInEuro) * 1.94;

        if (concertsProfit > 100000)
        {
            concertsProfit = concertsProfit - (concertsProfit * 0.15);
        }

        if (allAlbumsProfit > concertsProfit)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", allAlbumsProfit);
        }
        else
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertsProfit);
        }
    }
}

