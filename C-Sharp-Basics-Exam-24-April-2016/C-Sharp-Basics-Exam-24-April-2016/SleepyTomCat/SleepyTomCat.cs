using System;

class SleepyTomCat
{
    static void Main()
    {
        int holidays = int.Parse(Console.ReadLine());

        const int daysInYear = 365;
        const int holidayPlayTime = 127;
        const int workDayPlayTime = 63;
        const int playTimeNorm = 30000;

        int workDays = daysInYear - holidays;
        double totalPlayTime = (workDays * workDayPlayTime) + (holidays * holidayPlayTime);

        double diffPlayTime = Math.Abs(totalPlayTime - playTimeNorm);
        int diffHours = (int)(diffPlayTime / 60);
        int diffMinutes = (int)(diffPlayTime % 60);

        if (totalPlayTime > playTimeNorm)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", diffHours, diffMinutes);
        }
        else if (totalPlayTime < playTimeNorm)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", diffHours, diffMinutes);
        }
    }
}

