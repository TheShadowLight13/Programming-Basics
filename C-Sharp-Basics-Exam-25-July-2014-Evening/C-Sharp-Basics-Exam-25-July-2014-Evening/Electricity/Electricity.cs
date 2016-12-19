using System;
using System.Globalization;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        TimeSpan firstTime = TimeSpan.Parse("14:00");
        TimeSpan secondTime = TimeSpan.Parse("18:59");
        TimeSpan thirdTime = TimeSpan.Parse("19:00");
        TimeSpan fourthTime = TimeSpan.Parse("23:59");
        TimeSpan fifthTime = TimeSpan.Parse("00:00");
        TimeSpan sixthTime = TimeSpan.Parse("08:59");
        


        int totalFlats = floors * flats;
        double powerConsumption = 0;
        double totalPowerConsumption = 0;

        if (time >= firstTime && time <= secondTime)
        {
            powerConsumption = (2 * 100.53) + (2 * 125.90);
        }        
        else if (time >= thirdTime && time <= fourthTime)
        {
            powerConsumption = (7 * 100.53) + (6 * 125.90);
        }
        else if (time >= fifthTime && time <= sixthTime)
        {
            powerConsumption = (1 * 100.53) + (8 * 125.90);
        }

        totalPowerConsumption = totalFlats * powerConsumption;
        Console.WriteLine("{0} Watts", Math.Floor(totalPowerConsumption));
    }
}

