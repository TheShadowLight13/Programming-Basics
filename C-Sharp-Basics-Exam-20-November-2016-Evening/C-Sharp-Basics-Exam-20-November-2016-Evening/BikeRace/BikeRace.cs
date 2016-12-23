using System;

class BikeRace
{
    static void Main()
    {
        int juniorBikers = int.Parse(Console.ReadLine());
        int seniorBikers = int.Parse(Console.ReadLine());
        string traceType = Console.ReadLine();

        decimal juniorPrice = 0;
        decimal seniorPrice = 0;

        decimal totalDonation = 0;

        switch (traceType)
        {
            case "trail":
                juniorPrice = 5.50M;
                seniorPrice = 7.00M;

                totalDonation = (juniorBikers*juniorPrice) + (seniorBikers*seniorPrice);
                break;

            case "cross-country":
                juniorPrice = 8.00M;
                seniorPrice = 9.50M;

                totalDonation = (juniorBikers * juniorPrice) + (seniorBikers * seniorPrice);

                if (juniorBikers + seniorBikers >= 50)
                {
                    decimal discount = totalDonation*0.25M;
                    totalDonation -= discount;
                }

                break;

            case "downhill":
                juniorPrice = 12.25M;
                seniorPrice = 13.75M;

                totalDonation = (juniorBikers * juniorPrice) + (seniorBikers * seniorPrice);
                break;

            case "road":
                juniorPrice = 20.00M;
                seniorPrice = 21.50M;

                totalDonation = (juniorBikers * juniorPrice) + (seniorBikers * seniorPrice);
                break;
        }

        decimal expenses = totalDonation*0.05M;

        totalDonation -= expenses;

        Console.WriteLine("{0:F2}", totalDonation);
    }
}

