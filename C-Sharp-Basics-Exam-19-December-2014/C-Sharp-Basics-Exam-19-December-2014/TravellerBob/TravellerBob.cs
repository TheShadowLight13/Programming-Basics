using System;

class TravellerBob
{
    static void Main()
    {
        string leapOrNormal = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());
        int normalMonths = 12 - (contractMonths + familyMonths);

        int contractTravels = (4 * 3) * contractMonths;
        int familyTravels = (2 * 2) * familyMonths;
        double normalTravels = (12 * normalMonths) * 0.6;

        double totalTravels = (contractTravels + familyTravels + normalTravels);
        if (leapOrNormal == "leap")
        {
            totalTravels *= 1.05;
        }

        Console.WriteLine(Math.Floor(totalTravels));

    }
}

