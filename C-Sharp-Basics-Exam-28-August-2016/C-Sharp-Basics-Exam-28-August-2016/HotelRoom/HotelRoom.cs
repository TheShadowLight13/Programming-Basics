using System;

class HotelRoom
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        double studioPrice = 0;
        double apartmentPrice = 0;
        double studioDiscountRate = 0;
        double apartmentDiscountRate = 0;

        switch (month)
        {
            case "May":
            case "October": studioPrice = 50; apartmentPrice = 65; break;
            case "June":
            case "September": studioPrice = 75.20; apartmentPrice = 68.70; break;
            case "July":
            case "August": studioPrice = 76; apartmentPrice = 77; break;
        }

        if (nightsCount > 14 && (month.Equals("May") || month.Equals("October")))
        {
            studioDiscountRate = 0.3;
        }
        else if (nightsCount > 14 && (month.Equals("June") || month.Equals("September")))
        {
            studioDiscountRate = 0.2;
        }
        else if (nightsCount > 7 && (month.Equals("May") || month.Equals("October")))
        {
            studioDiscountRate = 0.05;
        }

        apartmentDiscountRate = nightsCount > 14 ? 0.1 : 0;

        double studioDiscount = studioPrice * studioDiscountRate;
        double apartmentDiscount = apartmentPrice * apartmentDiscountRate;

        double totalStudioPrice = (studioPrice - studioDiscount) * nightsCount;
        double totalApartmentPrice = (apartmentPrice - apartmentDiscount) * nightsCount;

        Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
    }
}

